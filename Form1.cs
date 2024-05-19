using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using Newtonsoft.Json.Linq;

namespace Csharp_Tibia_Bot
{
    public partial class Form1 : Form
    {
        private Thread workerThread;
        private bool running;
        private JObject config;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string json = File.ReadAllText("config.json");
            config = JObject.Parse(json);
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {

        }

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr hObject);

        private void init_bot()
        {
            string processName = "client";
            IntPtr address_mana = (IntPtr)0x0B63FEF0;
            IntPtr address_hp = (IntPtr)0x0B63F9D0;

            int input_hp = 5807;
            int input_mana = 1875;

            Process process = Process.GetProcessesByName(processName)[0];
            IntPtr processHandle = OpenProcess(0x0400 | 0x0010, false, process.Id);

            if (processHandle == IntPtr.Zero)
            {
                MessageBox.Show("Erro ao abrir o processo.");
                return;
            }

            byte[] buffer = new byte[4];

            while (running)
            {
                Invoke(new Action(() =>
                {
                    //HP
                    ReadProcessMemory(processHandle, address_hp, buffer, buffer.Length, out int bytesReadHp);
                    int hp = BitConverter.ToInt32(buffer, 0);
                    progressBar_hp.Value = (hp * 100) / input_hp;
                    label_current_hp.Text = $"{hp}/{input_hp}";

                    //Mana
                    ReadProcessMemory(processHandle, address_mana, buffer, buffer.Length, out int bytesReadMana);
                    int mana = BitConverter.ToInt32(buffer, 0);
                    progressBar_mana.Value = (mana * 100) / input_mana;
                    label_current_mana.Text = $"{mana}/{input_mana}";

                    foreach (JObject trigger in config["triggers"])
                    {
                        if (trigger["type"].ToString() == "hp")
                        {
                            int limit = trigger["limit"].ToObject<int>();
                            limit = input_hp * limit / 100;
                            if (hp < limit)
                            {
                                SendKeys.Send(trigger["hotkey"].ToString());
                            }
                        }
                        else if (trigger["type"].ToString() == "mana")
                        {
                            int limit = trigger["limit"].ToObject<int>();
                            limit = input_mana * limit / 100;
                            if (mana < limit)
                            {
                                SendKeys.Send(trigger["hotkey"].ToString());
                            }
                        }
                    }

                }));

                Thread.Sleep(100);
            }

            CloseHandle(processHandle);

        }

        private void checkBox_ativarPotions_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ativarPotions.Checked)
            {
                if (workerThread == null || !workerThread.IsAlive)
                {
                    running = true;
                    workerThread = new Thread(new ThreadStart(init_bot));
                    workerThread.Start();
                }
            }
            else
            {
                running = false;
                if (workerThread != null && workerThread.IsAlive)
                {
                    workerThread.Join(); 
                }
            }
        }


    }
}