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
        IntPtr processHandle;
        private int address_mana;
        private int address_hp;

        [DllImport("kernel32.dll")]
        public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

        [DllImport("kernel32.dll")]
        public static extern bool CloseHandle(IntPtr hObject);

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            string json = File.ReadAllText("config.json");
            config = JObject.Parse(json);
            Process process = Process.GetProcessesByName("client")[0];
            processHandle = OpenProcess(0x0400 | 0x0010, false, process.Id);

            if (processHandle == IntPtr.Zero)
            {
                MessageBox.Show("Erro ao abrir o processo. Abra o client.");
                return;
            }
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            CloseHandle(processHandle);
        }

        private int readAddress(int addr)
        {
            IntPtr address = (IntPtr)addr;
            byte[] buffer = new byte[4];
            ReadProcessMemory(processHandle, address, buffer, buffer.Length, out int bytesReadHp);
            return BitConverter.ToInt32(buffer, 0);
        }

        private int findManaAddress(int input_mana)
        {
            int startAddr = 0x0A000000;
            int endAddr = 0x0FFFFFFF;

            for (int addr = startAddr; addr < endAddr; addr++)
            {
                if ((readAddress(addr) == input_mana) && (readAddress(addr + 8) == input_mana))
                {
                    return addr;
                };
            }

            return 0;
        }

        private void init_bot()
        {
            int input_hp = 245;
            int input_mana = 450;

            if (address_mana == 0)
            {
                address_mana = findManaAddress(input_mana);
                address_hp = findManaAddress(input_hp);

                if (address_mana == 0 || address_hp == 0)
                {
                    MessageBox.Show("Endereço não encontrado.");
                    return;
                }
            }

            while (running)
            {
                Invoke(new Action(() =>
                {
                    //HP
                    int hp = readAddress(address_hp);
                    progressBar_hp.Value = (hp * 100) / input_hp;
                    label_current_hp.Text = $"{hp}/{input_hp}";

                    //Mana
                    int mana = readAddress(address_mana);
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
                                //SendKeys.Send(trigger["hotkey"].ToString());
                            }
                        }
                        else if (trigger["type"].ToString() == "mana")
                        {
                            int limit = trigger["limit"].ToObject<int>();
                            limit = input_mana * limit / 100;
                            if (mana < limit)
                            {
                                //SendKeys.Send(trigger["hotkey"].ToString());
                            }
                        }
                    }

                }));

                Thread.Sleep(100);
            }

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
                progressBar_hp.Value = 0;
                progressBar_mana.Value = 0;
                label_current_hp.Text = "-";
                label_current_mana.Text = "-";
                if (workerThread != null && workerThread.IsAlive)
                {
                    workerThread.Join();
                }
            }
        }


    }
}