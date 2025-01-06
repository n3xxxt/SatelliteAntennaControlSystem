using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SatelliteAntennaControlSystem
{
    public class SatelitteSystem
    {      

        private static readonly Mutex mutex = new Mutex();
        public TCPclient client;

        const int ACTUAL_ANGLE_INDEX = 1;
        const int ACTUAL_HORIZONT_INDEX = 2;
        const int IS_SYSTEM_ACTIVATED_INDEX = 3;
        const int MAX_ANGLE_INDEX = 4;
        const int MIN_ANGLE_INDEX = 5;
        const int MAX_HORIZONT_INDEX = 6;
        const int MIN_HORIZONT_INDEX = 7;

        private float MAX_ANGLE { get; set; } 
        private float MIN_ANGLE { get; set; }

        private float MAX_HORIZONT { get; set; }
        private float MIN_HORIZONT { get; set; }

        public bool is_activated { get; set; }
        public bool sReading { get; set; }

        public float horizont_value { get; set; }
        public float angle_value { get; set; }

        public List<Satelitte> fileSatellites = new List<Satelitte>();

        //Серверная информация тоже должная быть здесь (соединение)

        public SatelitteSystem()
        {   
            try
            {
                client = new TCPclient("192.168.4.1", 8080);
                sReading = true;

                horizont_value = 90;


                var readThread = new Thread(serverReading);
                readThread.Start();


                readInformation();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }           
            
        }

        private void serverReading()
        {
            try
            {
                byte[] buffer = new byte[256];
                while (sReading)
                {
                    if (client.tcpClient != null & client.stream != null)
                    {
                        
                        //mutex.WaitOne();
                        int bytesRead = client.stream.Read(buffer, 0, buffer.Length);
                        if (bytesRead > 0)
                        {
                            string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                            if (response.StartsWith("SYSTEM_INFORMATION"))
                            {
                                var inf = response.Split(";");
                                angle_value = float.Parse(inf[ACTUAL_ANGLE_INDEX].Replace(".", ","));
                                horizont_value = float.Parse(inf[ACTUAL_HORIZONT_INDEX].Replace(".", ","));
                                is_activated = bool.Parse(inf[IS_SYSTEM_ACTIVATED_INDEX]);
                                MAX_ANGLE = int.Parse(inf[MAX_ANGLE_INDEX]);
                                MIN_ANGLE = int.Parse(inf[MIN_ANGLE_INDEX]);
                                MAX_HORIZONT = int.Parse(inf[MAX_HORIZONT_INDEX]);
                                MIN_HORIZONT = int.Parse(inf[MIN_HORIZONT_INDEX]);
                            }
                            else
                            {
                                MessageBox.Show(response);
                                switch (response)
                                {
                                    case ("POSITION_IS_SET"):
                                        {
                                            MessageBox.Show("Положение антенны установлено");
                                            break;
                                        }
                                    case ("SYSTEM_ACTIVATED"):
                                        {
                                            is_activated = true;
                                            MessageBox.Show("Система активирована");
                                            break;
                                        }
                                    case ("SYSTEM_DEACTIVATED"):
                                        {
                                            is_activated = false;
                                            MessageBox.Show("Система дективирована");
                                            break;
                                        }
                                    case ("ERROR_IN_SETTING_POSITION"):
                                        {
                                            MessageBox.Show("Ошибка при установке положения антенны");
                                            break;
                                        }

                                }//switch
                            }// if response
                        }// if butesRead > 0
                        //mutex.ReleaseMutex();
                        

                    }// if tcpClient != null

                }// while sReading
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка чтения: {ex.Message}");
                client.reconnection();
            }
        }

        public bool readInformation()
        {

            try
            {
                if (client.tcpClient == null)
                {
                    MessageBox.Show("Не установлено подключение с сервером");
                    client.reconnection();
                    return false;
                }
                else
                {
                    // Пытаемся захватить мьютекс
                    mutex.WaitOne();

                    client.sendMessage("CHECK_SYSTEM");

                    mutex.ReleaseMutex(); // Освобождаем мьютекс

                    return true;
                }// if (client.tcpClient == null)                  
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                client.reconnection();
                return false;
            }
        }

        public bool rotate(float angle, float horizont)
        {
            try
            {
                if (client.tcpClient == null)
                {
                    MessageBox.Show("Не установлено подключение с сервером");
                    client.reconnection();
                    return false;
                }
                else
                {
                    // Пытаемся захватить мьютекс
                    mutex.WaitOne();

                    client.sendMessage($"SET_POSITION;{angle};{horizont}");

                    mutex.ReleaseMutex(); // Освобождаем мьютекс
                    return true;
                }// if (client.tcpClient == null)

            }
            catch (Exception ex)
            {                
                MessageBox.Show(ex.Message);
                client.reconnection();
                return false;
            }
            
        }

        public bool systemActivateDeactivate()
        {

            try
            {

            
                if (client.tcpClient == null)
                {
                    MessageBox.Show("Не установлено подключение с сервером");
                    client.reconnection();
                    return false;
                }
                else
                {
                    // Пытаемся захватить мьютекс
                    mutex.WaitOne();

                    if (!is_activated)
                    {
                        client.sendMessage("ACTIVATE_SYSTEM");
                        is_activated = true;
                        mutex.ReleaseMutex(); // Освобождаем мьютекс
                        return is_activated;
                    }
                    else
                    {
                        client.sendMessage("DEACTIVATE_SYSTEM");
                        is_activated = false;
                        mutex.ReleaseMutex(); // Освобождаем мьютекс
                        return is_activated;
                    }
                }// if (client.tcpClient == null)                  
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                client.reconnection();
                return false;
            }

        }

    }
}
