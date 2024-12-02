using Controles;
namespace CaidaPresion
{
    public partial class frmCalibracion : Form
    {
       public PuertoSerial puertoSerial {  get; set; }
        public string Dato { get; set; }
        public frmCalibracion()
        {
            InitializeComponent();
            puertoSerial = new PuertoSerial();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ControlForm.FillCombo(puertoSerial.Serialports, cmbSerialPort);
            ControlForm.FillCombo(puertoSerial.StopBits, cmbStopBits);
            ControlForm.FillCombo(puertoSerial.Parities, cmbParity);
            ControlForm.FillCombo(puertoSerial.Serialports, cmbSerialPort);
            if (cmbSerialPort.Items.Count == 0)
            {
                MessageBox.Show("No hay Dispositivos disponibles", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                puertoSerial.OpenDevice(cmbSerialPort.Text);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }


        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
