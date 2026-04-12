using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Net.Mime.MediaTypeNames;


namespace auto_clicker
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("USER32.DLL")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("User32")]
        private static extern int ShowWindow(IntPtr hwnd, int nCmdShow);

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern short VkKeyScan(char ch);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void keybd_event(uint bVk, uint bScan, uint dwFlags, uint dwExtraInfo);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);


        /*[DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("USER32.DLL")]
        public static extern void keybd_event(byte bVk,byte bScan,DoWorkEventHandler dwFlags,ULONG_PTR dwExtraInfo);*/

        public bool autoclicker_on = false;
        string key;
        int press_speed;

        CancellationTokenSource cts = new();

        int max_repeats;
        int delay = 1000;
        //Process Selected_process;
        Process[] Running_processes;
        string Settings_file;
        List<int> Process_list_index = new List<int>();

        IntPtr Selected_window_IntPtr;
        Process Selected_window_Process;

        Form test = new Form();
        TextBox display_m_pos = new TextBox();

        public Form1()
        {
            test.BackColor = Color.MediumAquamarine;
            test.TransparencyKey = Color.MediumAquamarine;
            test.WindowState = FormWindowState.Maximized;
            test.FormBorderStyle = FormBorderStyle.None;

            display_m_pos.Text = "AAAAAAAAAAAAAAAAAAAAAAAAA";
            display_m_pos.Parent = test;
            display_m_pos.ReadOnly = true;
            display_m_pos.HideSelection = true;
            display_m_pos.BorderStyle = BorderStyle.None;

            test.Controls.Add(display_m_pos);
            test.MouseMove += new MouseEventHandler(track_mouse);
            test.MouseDown += new MouseEventHandler(track_mouse);

            InitializeComponent();

            load_processes();
            check_files();
        }
        private void check_files()
        {
            string get_process_file = Process.GetCurrentProcess().MainModule.FileName;
            string process_folder = get_process_file.Remove(get_process_file.Length - 16);
            if (!Directory.Exists(process_folder + "Macros (ahk)"))
            {
                Directory.CreateDirectory(process_folder + "Macros (ahk)");
            }
            if (!File.Exists(process_folder + "Settings.txt"))
            {
                File.CreateText(process_folder + "Settings.txt").Close();
            }
            Settings_file = process_folder + "Settings.txt";
            do { Thread.Sleep(10); } while (!File.Exists(process_folder + "Settings.txt"));
            if (File.ReadAllBytes(Settings_file).Length == 0)
            {
                File.WriteAllText(process_folder + "Settings.txt", "can_use_ahk:false");
            }
            Debug.WriteLine(process_folder);
        }

        private void load_processes()
        {
            ///gets all running processes and adds it to a list
            Running_processes = Process.GetProcesses();
            Process_list.Items.Clear();
            for (int i = 0; i < Running_processes.Length; i++)
            {
                Process_list.Items.Add(Running_processes[i].ProcessName);
            }
        }

        void autoinput_keybind(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("TEst");
        }


        private void autoinput_b_Click(object sender, EventArgs e)
        {
            /// toggles the autoclicker button on and off
            //if() return;
            if (autoclicker_on == true)
            {
                Debug.WriteLine("Turn FUCKING OFF");
                Debug.WriteLine(cts.Token.IsCancellationRequested + "TOken :)");

                autoclicker_on = false;
                label1.Text = "OFF";
                // myThread.Interrupt();

                cts.Cancel();
                Debug.WriteLine(cts.Token.IsCancellationRequested + "Token... again");
            }
            else
            {
                autoclicker_on = true;
                label1.Text = "ON";

                cts = new();
                //if (cts.Token.IsCancellationRequested) { }

                //autoInput_thread = new Thread(Autoclicker_func);
                Debug.WriteLine("Turned FUCKOING ON");
                Debug.WriteLine(cts.Token.IsCancellationRequested);

                //autoInput_task = new Task(Autoclicker_func,cts.Token);
                //do { Thread.Sleep(10); } while (autoInput_task.IsCompleted);
                //autoInput_task.Start();
                //autoInput_task.GetAwaiter().OnCompleted(() => { if (!cts.Token.IsCancellationRequested) { autoinput_b_Click(this, null); }; });

                Task.Factory.StartNew(Autoclicker_func, cts.Token).GetAwaiter().OnCompleted(() => { if (!cts.Token.IsCancellationRequested) { autoinput_b_Click(this, null); } });

                //Task.Factory.StartNew(() => Autoclicker_func());
                // myThread.Start();
                // myThread.Join();
            }

        }

        /// Updates the String of keys to send
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                key = key_text.Text;
            }
        }

        ///  Updates how long it should wait until it sends the string again
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != null)
            {
                int.TryParse(textBox2.Text, out press_speed);
                if (press_speed <= 0)
                { press_speed = 1000; }
            }
            else
            { press_speed = 1000; }
        }

        /// Sends the key input
        public void Autoclicker_func()
        {
            if (Run_in_b_toggle.Checked)
            { ShowWindow(Selected_window_IntPtr, 0); }

            int.TryParse(start_delay_tb.Text, out int temp);
            Thread.Sleep(temp);
            cts.Token.ThrowIfCancellationRequested();

            IntPtr return_to_process = new();

            bool gave_coor = new bool();
            int X = 0;
            int Y = 0;
            if (coor_X_tb.Text.Length > 0 | coor_Y_tb.Text.Length > 0)
            {
                ///reads pos text and turns it to int
                int.TryParse(coor_X_tb.Text, out X);
                int.TryParse(coor_Y_tb.Text, out Y);
                X = 65535 / Screen.PrimaryScreen.Bounds.Width * X;
                Y = 65535 / Screen.PrimaryScreen.Bounds.Height * Y;
                gave_coor = true;
            }
            int repeats = 0;
            while (autoclicker_on == true & repeats < max_repeats/*& e.KeyCode != Keys.F6*/)
            {
                if (autoclicker_on == true)
                {
                    if (Run_in_b_toggle.Checked)
                    { return_to_process = Process.GetCurrentProcess().Handle; SetForegroundWindow(Selected_window_IntPtr); }
                    //return_window = GetForegroundWindow();
                    //Debug.WriteLine(GetForegroundWindow());

                    //PostMessage(Selected_window_Process.MainWindowHandle, 0x0100, 0x41, 0);

                    //keybd_event(0x41, 0, 0x0100, 0);

                    //Debug.Write(Selected_window_Process.MainWindowHandle);

                    //InSim.Keyboard.KeyPress(VirtualKeyCode.VK_A);
                    //char[] temp_char = key.ToCharArray();
                    //VirtualKeyCode_test = temp_char[0].;

                    //InputSim.Keyboard.KeyDown(VirtualKeyCode.VK_A).Sleep(10);
                    //InputSim.Keyboard.KeyUp(VirtualKeyCode.VK_A);


                    if (kb_in_Normal.Checked)
                    { SendKeys.SendWait(key); }

                    if (gave_coor == true)
                    {
                        mouse_event(0x0001 | 0x8000, X, Y, 0, 0);
                        Debug.WriteLine("X:" + X + "| Y:" + Y);
                    }

                    ///presses Left mouse button
                    if (LMB_check.Checked)
                    { mouse_event(0x0002, 0, 0, 0, 0); mouse_event(0x0004, 0, 0, 0, 0); }
                    ///presses Middle mouse button
                    if (MMB_check.Checked)
                    { mouse_event(0x0020, 0, 0, 0, 0); mouse_event(0x0040, 0, 0, 0, 0); }
                    ///presses Right mouse button
                    if (RMB_check.Checked)
                    { mouse_event(0x0008, 0, 0, 0, 0); mouse_event(0x0010, 0, 0, 0, 0); }

                    Thread.Sleep(1);
                    SetForegroundWindow(return_to_process);
                    Thread.Sleep(press_speed);
                    SetForegroundWindow(return_to_process);
                    repeats++;
                }
            }
            if (Run_in_b_toggle.Checked)
            { ShowWindow(Selected_window_IntPtr, 1); }
        }

        /// updates how many times the string should be send
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != null)
            {
                int.TryParse(textBox3.Text, out max_repeats);
                if (max_repeats <= 0)
                { max_repeats = 1; }
            }
            else
            { max_repeats = 1; }
        }

        /// search function for finding a process
        private void Search_text_TextChanged(object sender, EventArgs e)
        {
            if (Searchbar.Text != null)
            {
                //Closest_Process.Text = Process_list.Items[Process_list.FindString(Searchbar.Text)].ToString();
                Process_list.Items.Clear();
                Process_list_index.Clear();
                for (int i = 0; i < Running_processes.Length; i++)//Process.GetProcesses().Length; i++)
                {
                    //Debug.Print(Running_processes[i].ProcessName.Contains(Searchbar.Text).ToString());
                    if (Running_processes[i].ProcessName.Contains(Searchbar.Text))
                    {
                        //    Debug.Print(Process_list.Items[i+1].ToString());
                        Process_list_index.Add(i);
                        Process_list.Items.Add(Running_processes[i].ProcessName);
                    }
                }
                //Debug.Print(Process_list.Items[Process_list.FindString(Searchbar.Text)].ToString());
                //Closest_Process.Text = "test";
                //Debug.WriteLine("Test");
            }
        }

        private void Select_process_Click(object sender, EventArgs e)
        {
            //Selected_Process.Text = Process_list.SelectedItem.ToString();
            if (Process_list_index.Count > 0)
            {
                Debug.Print(Running_processes[Process_list_index[Process_list.SelectedIndex]].MainWindowHandle.ToString());
                Selected_Process.Text = Process_list.Text;
                Selected_window_IntPtr = Running_processes[Process_list_index[Process_list.SelectedIndex]].MainWindowHandle;
                Selected_window_Process = Running_processes[Process_list_index[Process_list.SelectedIndex]];
            }
            else
            {
                Debug.Print(Running_processes[Process_list.SelectedIndex].MainWindowHandle.ToString());
                Selected_Process.Text = Process_list.Text;
                Selected_window_IntPtr = Running_processes[Process_list.SelectedIndex].MainWindowHandle;
                Selected_window_Process = Running_processes[Process_list.SelectedIndex];
            }
        }

        private void Reload_processes_b_Click(object sender, EventArgs e)
        {
            load_processes();
        }

        private void Use_ahk_CheckedChanged(object sender, EventArgs e)
        {
            if (Use_ahk.Checked)
            {
                kb_in_Normal.Checked = false;
                if (File.ReadLines(Settings_file).ToList()[0].Remove(0, 12) == "false")
                {
                    DialogResult Answere =
                    MessageBox.Show(
                    owner: this,
                    text: "Do you have Autohotkey Installed?\r\nif not install it from here\r\n" + "https://www.autohotkey.com/" + "\r\nor\r\n" + "https://github.com/autohotkey/autohotkey" + "\r\nhelp takes you to the download page",
                    caption: "check",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1,
                    0,
                    "https://www.autohotkey.com/"
                    );
                    if (Answere == DialogResult.Yes)
                    {
                        string settings = File.ReadAllText(Settings_file);
                        File.WriteAllText(Settings_file, "can_use_ahk:true" + settings.Remove(0, 17));
                    }
                    if (Answere == DialogResult.No)
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = "https://www.autohotkey.com/",
                            UseShellExecute = true
                        });
                        Use_ahk.Checked = false;
                    }
                    if (Answere == DialogResult.Cancel)
                    { Use_ahk.Checked = false; }
                }
            }
        }

        private void kb_in_Normal_CheckedChanged(object sender, EventArgs e)
        {
            if (kb_in_Normal.Checked)
            { Use_ahk.Checked = false; }
        }

        private void get_mous_pos_Click(object sender, EventArgs e)
        {
            test.ShowDialog();
        }
        void track_mouse(object sender, MouseEventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            //do { display_m_pos.Location = new Point(Cursor.Position.X, Cursor.Position.Y); } while (/*e.KeyChar != (char)Keys.B*/true);
            display_m_pos.Location = new Point(x + 10, y + 10);
            display_m_pos.Text = "X:" + x + "| Y:" + y;
            if (e.Button == MouseButtons.Left)
            {
                coor_X_tb.Text = x.ToString();
                coor_Y_tb.Text = y.ToString();
                test.Hide();
            }
        }

        private void Run_in_b_toggle_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}