using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace U64DebugReceiver
{
    public partial class Form1 : Form
    {
        private bool stopped;
        private List<byte> dump;

        public Form1()
        {
            InitializeComponent();
            btnCaptureStop.Enabled = false;
            btnSaveDump.Enabled = false;
        }

        private void btnCaptureStop_Click(object sender, EventArgs e) => stopped = true;

        private void btnCaptureStart_Click(object sender, EventArgs e)
        {
            stopped = false;
            btnCaptureStart.Enabled = false;
            btnCaptureStop.Enabled = true;
            btnSaveDump.Enabled = false;
            dump = null;
            System.GC.Collect();
            Thread myThread = new Thread(() =>
            {
                var udpClient = new UdpClient((int) nupPort.Value);
                udpClient.Client.ReceiveTimeout = 5000;
                udpClient.JoinMulticastGroup(IPAddress.Parse(tbIP.Text), 50);

                var remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);

                int lastNumber = -1;
                var result = new List<List<byte>>();
                while (!stopped)
                {
                    byte[] receivedResults = udpClient.Receive(ref remoteEndPoint);

                    int number = (receivedResults[1] << 8) | receivedResults[0];
                    
                    if (lastNumber != -1 && (ushort)(lastNumber + 1) != number)
                    {
                        Text = $"number {number}, {number - lastNumber}";
                    }
                    lastNumber = number;

                    var receivedBytes4 = receivedResults.Skip(4).ToList();
                    result.Add(receivedBytes4);
                }

                udpClient.Close();
                btnCaptureStart.Enabled = true;
                btnCaptureStop.Enabled = false;

                if (result.Any())
                {
                    dump = new List<byte>();
                    foreach (List<byte> j in result)
                        dump.AddRange(j);
                    btnSaveDump.Enabled = true;
                }
                else
                {
                    dump = null;
                    btnSaveDump.Enabled = false;
                }

                result = null;
                System.GC.Collect();
            });
            myThread.Start();

        }

        private void btnSaveDump_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "U64 Debug Stream (*.bin)|*.bin›", // |All files (*.*)|*.*
                FilterIndex = 0,
                RestoreDirectory = true
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog1.FileName, dump.ToArray());
            }

        }
    }
}
    