using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubZeroWrapper
{
    public partial class SubZero : Form
    {
        public SubZero()
        {
            InitializeComponent();
        }

        public static string PointerAddress = Addresses.VMCall + Addresses.KeyPointer + Addresses.YieldString + Addresses.dwTable;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        public NamedPipeServerStream pipeServer = null;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]

        private static extern bool WaitNamedPipe(string name, int timeout);
        public static bool NamedPipeExist(string pipeName)
        {
            bool result;
            try
            {
                int timeout = 0;
                if (!WaitNamedPipe(Path.GetFullPath(string.Format("\\\\.\\pipe\\{0}", pipeName)), timeout))
                {
                    int lastWin32Error = Marshal.GetLastWin32Error();
                    if (lastWin32Error == 0)
                    {
                        result = false;
                        return result;
                    }
                    if (lastWin32Error == 2)
                    {
                        result = false;
                        return result;
                    }
                }
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }
            return result;
        }

        public bool isalreadyattached1 = false;

        public bool firstexecute1 = true;

        public async void Execute(string input1)
        {
            if (isalreadyattached1 == true)
            {
                if (firstexecute1 == true)
                {
                    firstexecute1 = false;
                    using (pipeServer)
                    {
                        using (StreamWriter streamWriter = new StreamWriter(pipeServer, System.Text.Encoding.Default, 999999))
                        {
                            streamWriter.Write(input1);
                            streamWriter.Dispose();
                        }
                    }
                    pipeServer = new NamedPipeServerStream("pHSnj5zbUpK4YpcnRr3y", PipeDirection.Out);
                }
                else
                {
                    using (pipeServer)
                    {
                        await pipeServer.WaitForConnectionAsync();
                        using (StreamWriter streamWriter = new StreamWriter(pipeServer, System.Text.Encoding.Default, 999999))
                        {
                            streamWriter.Write(input1);
                            streamWriter.Dispose();
                        }
                    }
                    pipeServer = new NamedPipeServerStream("pHSnj5zbUpK4YpcnRr3y", PipeDirection.Out);
                }
            }
            else
            {
                MessageBox.Show("Not Attached!", "Error!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string args2 = "[[[" + PointerAddress + "]]]";
            string string3 = richTextBox1.Text;
            var blockComments = @"/\*(.*?)\*/";
            string3 = Regex.Replace(string3, blockComments, "");
            Random r = new Random();
            int x = r.Next(string3.Length);
            string3 = string3.Insert(x, AddyCompiler.Compile(args2));
            string3 = Wrapper.WrapEnv(string3);
            File.WriteAllText(Path.GetTempPath() + "SubZero.ROM" + Wrapper.WrapMT(), string3);
            Execute(Path.GetTempPath() + "SubZero.ROM" + Wrapper.WrapMT());
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("Fiber").Length == 0)
            {
                MessageBox.Show("Failed To Find Fiber!", "Error!");
            }
            else
            {
                if (NamedPipeExist("pHSnj5zbUpK4YpcnRr3y") == true)
                {
                    isalreadyattached1 = true;
                    button3.Text = "Already Attached!";
                    await Task.Delay(1000);
                    button3.Text = "Attach";
                }
                else
                {
                    isalreadyattached1 = false;
                    button3.Enabled = false;
                    pipeServer = new NamedPipeServerStream("pHSnj5zbUpK4YpcnRr3y", PipeDirection.Out);
                    await pipeServer.WaitForConnectionAsync();
                    button3.Enabled = false;
                    isalreadyattached1 = true;
                    timer1.Start();
                    button1.Enabled = true;
                    button3.Text = "Attached!";
                    await Task.Delay(1000);
                    button3.Text = "Attach";
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("Fiber").Length == 0)
            {
                timer1.Stop();
                isalreadyattached1 = false;
                firstexecute1 = true;
                using (pipeServer)
                {
                    pipeServer = null;
                }
                button3.Enabled = true;
                button1.Enabled = false;
            }
            else
            {
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
