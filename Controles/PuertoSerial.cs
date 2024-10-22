using System.IO.Ports;
namespace Controles
{
    public class PuertoSerial
    {
        public SerialPort SerialPort;
        public PuertoSerial()
        {
            SerialPort = new SerialPort();
            SerialPort.DataReceived +=ControlForm. SerialPort_DataReceived;
        }
        public PuertoSerial(int baudRate, Parity parity, int dataBits,StopBits  stopBits) 
        {
            SerialPort = new SerialPort
            {
                BaudRate = baudRate,
                Parity = parity,
                DataBits = dataBits,
                StopBits = stopBits
            };
            SerialPort.DataReceived += ControlForm.SerialPort_DataReceived;
        }
        public string[] Serialports
        {
            get
            {
                return SerialPort.GetPortNames();
            }
        }
        public Array Parities
        {
            get
            {
                return Enum.GetValues(typeof(Parity));
            }
        }
        public Array StopBits
        {
            get
            {
                return Enum.GetValues(typeof(StopBits));
            }
        }
        public void WriteData( string data)
        {
            SerialPort.Write(data);
        }
        public void OpenDevice(string PortName)
        {
            try
            {
                if (SerialPort.IsOpen)
                {
                    SerialPort.Close();
                }
                SerialPort.PortName = PortName;
                SerialPort.Open();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void CloseDevice()
        {
        
            SerialPort.Close();
        }
    }
}
