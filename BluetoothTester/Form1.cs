using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BluetoothTester
{
    public partial class Form1 : Form
    {
        BluetoothClient client = new BluetoothClient(); // 藍芽庫
        BluetoothRadio radio = null; // 藍芽裝置
        IReadOnlyCollection<BluetoothDeviceInfo> devices = null;
        BluetoothAddress blueAddress = null; // 藍芽裝置地址
        Stream peerStream = null; // 資料流

        public Form1()
        {
            InitializeComponent();
            radio = BluetoothRadio.Default; // 獲取預設藍芽裝置
            radio.Mode = RadioMode.Connectable; // 允許藍芽可以被搜尋到
        }

        private void btnSearchBluetooth_Click(object sender, EventArgs e)
        {
            listBluetooth.Items.Clear();
            devices = client.DiscoverDevices(500); // 開始搜尋藍芽裝置
            foreach (BluetoothDeviceInfo deviceInfo in devices)
            {
                Console.WriteLine(deviceInfo.DeviceAddress);
                Console.WriteLine(deviceInfo.DeviceName);
                listBluetooth.Items.Add("[" + deviceInfo.DeviceAddress + "] " + deviceInfo.DeviceName);
                //blueAddress = item.DeviceAddress;
            }
        }

        private void btnLinkStart_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (BluetoothDeviceInfo deviceInfo in devices)
            {
                if (i == listBluetooth.SelectedIndex)
                {
                    blueAddress = deviceInfo.DeviceAddress;
                    break;
                }
                i++;
            }
            if (blueAddress != null)
            {
                BluetoothEndPoint ep = new BluetoothEndPoint(blueAddress, BluetoothService.SerialPort);
                Console.WriteLine("正在连接");
                client.Connect(ep); // 配对
                Console.WriteLine("连接成功！");
                Stream peerStream = client.GetStream(); // 建立資料流
            }
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            if (client.Connected)
            {
                string str = txtMessage.Text;
                byte[] decBytes = Encoding.ASCII.GetBytes(str);
                peerStream.Write(decBytes, 0, str.Length); // 发送指令
                Console.WriteLine("发送成功！");
            }
        }
    }
}
