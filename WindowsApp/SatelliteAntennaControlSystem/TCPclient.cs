using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SatelliteAntennaControlSystem
{
    public class TCPclient
    {
        string serverIp;
        int port;
        public NetworkStream stream;
        public TcpClient tcpClient;
        


        public TCPclient(string serverIp, int port)
        {
            this.serverIp = serverIp;
            this.port = port;
            try
            {
                tcpClient = new TcpClient(serverIp, port);
                stream = tcpClient.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        public bool disconnectClient()
        {
            try
            {
                tcpClient.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public void sendMessage(string message)
        {
            if (!tcpClient.Connected) return;

            try
            {
                byte[] messageBytes = Encoding.UTF8.GetBytes(message);
                stream.Write(messageBytes, 0, messageBytes.Length);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void reconnection()
        {         
            if (tcpClient.Connected) 
                tcpClient.Close();
            try
            {
                tcpClient = new TcpClient(serverIp, port);
                stream = tcpClient.GetStream();
                MessageBox.Show("Подключено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void disconnect()
        {
            tcpClient?.Close();
        }

    }
}
