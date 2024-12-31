namespace SatelliteAntennaControlSystem
{
    public partial class MainControlPanel : Form
    {
        SatelitteSystem FormSys;
        public MainControlPanel(SatelitteSystem sys)
        {
            InitializeComponent();
            FormSys = sys;
        }

        private void UpHorizontButton_Click(object sender, EventArgs e)
        {
            float angle = (float)PointControllerNumericUpDown.Value;

            FormSys.rotate(FormSys.angle_value, FormSys.horizont_value + angle);
            refreshDataToolStripMenuItem_Click(sender, e);
        }

        private void DownHorizontButton_Click(object sender, EventArgs e)
        {
            float angle = (float)PointControllerNumericUpDown.Value;

            FormSys.rotate(FormSys.angle_value, FormSys.horizont_value - angle);
            refreshDataToolStripMenuItem_Click(sender, e);
        }

        private void UpAngleButton_Click(object sender, EventArgs e)
        {
            float angle = (float)PointControllerNumericUpDown.Value;

            FormSys.rotate(FormSys.angle_value + angle, FormSys.horizont_value);
            refreshDataToolStripMenuItem_Click(sender, e);
        }

        private void DownAngleButton_Click(object sender, EventArgs e)
        {
            float angle = (float)PointControllerNumericUpDown.Value;

            FormSys.rotate(FormSys.angle_value - angle, FormSys.horizont_value);
            refreshDataToolStripMenuItem_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualAngleValue.Text = "?";
            ActualHorizontValue.Text = "?";
            SystemStatusLabel.Text = "?";
            if (FormSys.client.tcpClient.Connected)
            {
                connectionStatusToolStripMenuItem.Text = "����������";
                refreshDataToolStripMenuItem_Click(sender, e);
            }
            else
            {
                connectionStatusToolStripMenuItem.Text = "�� ����������";
            }
        }

        private void ActivatingSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSys.systemActivateDeactivate();
            refreshDataToolStripMenuItem_Click(sender, e);
        }


        private void SemiAutomaticSetPositionButton_Click(object sender, EventArgs e)
        {
            FormSys.rotate((float)SemiAutoAngleNumericUpDown.Value, (float)SemiAutoHorizontNumericUpDown.Value);
            refreshDataToolStripMenuItem_Click(sender, e);
        }

        private void refreshDataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormSys.readInformation();
            refresh_fields();
        }

        private void refresh_fields()
        {
            ActualAngleValue.Text = FormSys.angle_value.ToString();
            ActualHorizontValue.Text = FormSys.horizont_value.ToString();
            //SemiAutoAngleNumericUpDown.Value = (decimal)FormSys.angle_value;
            //SemiAutoHorizontNumericUpDown.Value = (decimal)FormSys.horizont_value;
            if (FormSys.is_activated) { SystemStatusLabel.Text = "��������"; }
            else { SystemStatusLabel.Text = "���������"; }
        }

        private void connectionStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (FormSys.client.tcpClient.Connected)
            {
                connectionStatusToolStripMenuItem.Text = "����������";
                MessageBox.Show("����������");
                refreshDataToolStripMenuItem_Click(sender, e);

            }
            else
            {
                connectionStatusToolStripMenuItem.Text = "�� ����������";
                MessageBox.Show("�� ����������, ������� ���������������");
                FormSys.client.reconnection();
            }
        }

        private void MainControlPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormSys.client.disconnect();
        }
    }
}