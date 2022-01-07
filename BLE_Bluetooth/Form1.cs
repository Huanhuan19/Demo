using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using BLECode;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        BluetoothLECode bluetooth;
        string BluetoothLE = "";
        public Form1()
        {
            InitializeComponent();

            BluetoothLE= System.Configuration.ConfigurationManager.AppSettings["BluetoothLE"];
            string _serviceGuid = "0000ffe0-0000-1000-8000-00805f9b34fb";//"ba11f08c-5f14-0b0d-1080-007cbe423ed2";
            string _notifyCharacteristicGuid = "0000ffe1-0000-1000-8000-00805f9b34fb";
            string  _writeCharacteristicGuid = "0000ffe2-0000-1000-8000-00805f9b34fb";//"0000cd02-0000-1000-8000-00805f9b34fb";
            bluetooth = new BluetoothLECode(_serviceGuid, _writeCharacteristicGuid, _notifyCharacteristicGuid);
            bluetooth.ValueChanged += Bluetooth_ValueChanged;
        }
        private void ShowInfo(string info)
        {
            info = info.Trim();
            if (info == "") return;
            richTextBox1.Text = DateTime.Now.ToString("mm:ss ") + info + "\n" + richTextBox1.Text;
            if (richTextBox1.Text.Length > 10240) richTextBox1.Text = "";
        }
        bool cl = true;
        private void Bluetooth_ValueChanged(MsgType type, string str, byte[] data)
        {
            if (cl)
            {
                try { Invoke(new MethodInvoker(delegate { ShowInfo(str); })); }
                catch (Exception) { }
                if("WriteTure"==str)
                {
                    byte[] sendData = new byte[] { (byte)0xAA, 0x55, 0x04, (byte)0xB1, 0x00, 0x00, (byte)0xB5 };
                    bluetooth.Write(sendData);
                }

                //if("设备已连接"==str)
                //{

                    //cl = false;
                
               // }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             OnBLEAdded();
        }

        private async void OnBLEAdded()
        {
           // await bluetooth.SelectDevice("BluetoothLE#BluetoothLE74:40:bb:dd:7b:9c-08:7c:be:42:3e:d2");
            await bluetooth.SelectDevice(BluetoothLE);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] buffer = StringToBuffer(tbSend.Text);
            bluetooth.Write(buffer);
        }

        public static byte[] StringToBuffer(string pStr)
        {
            try
            {
                pStr=pStr.Replace(" ", "");
                int len = pStr.Length / 2;
                byte[] buffer = new byte[len];
                for (int i = 0; i < len; i++)
                {
                    buffer[i] = Convert.ToByte(pStr.Substring(i * 2, 2), 16);
                }
                return buffer;
            }
            catch (Exception ex)
            {
                throw new Exception("字符串转换失败：" + ExToString(ex));
            }
        }

        public static string ExToString(Exception ex)
        {

            string[] sources = ex.StackTrace.Split(new char[] { '\r', '\n' });
            string s = "";
            try
            {
                foreach (string source in sources)
                {
                    if (source.IndexOf(".cs") > 0)
                    {
                        int from = source.LastIndexOf(@"\") + 1;
                        s = source.Substring(from).Replace(".aspx", "").Replace(".cs", "").Replace(":行号 ", " ");
                        break;
                    }
                }

            }
            catch
            {
                s = "";
            }
            return ex.Message.Replace("\r\n", " ") + " " + s;
        }
    }
}
