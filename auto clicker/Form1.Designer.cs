namespace auto_clicker
{
    using System.Windows.Forms;

    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            autoinput_b = new Button();
            timer1 = new Timer(components);
            key_text = new TextBox();
            label1 = new Label();
            Key_label = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            Process_list = new ListBox();
            Searchbar = new TextBox();
            Search_text = new Label();
            Selected_Process = new Label();
            Select_process = new Button();
            tabControl1 = new TabControl();
            AutoInputTab = new TabPage();
            Run_in_b_toggle = new CheckBox();
            Use_ahk = new CheckBox();
            kb_in_Normal = new CheckBox();
            Reload_processes_b = new Button();
            Start_delay_label = new Label();
            start_delay_tb = new TextBox();
            groupBox2 = new GroupBox();
            Mouse_dsc = new RichTextBox();
            get_mous_pos = new Button();
            label5 = new Label();
            coor_X_tb = new TextBox();
            coordinate_y_label = new Label();
            coor_Y_tb = new TextBox();
            RMB_check = new CheckBox();
            MMB_check = new CheckBox();
            LMB_check = new CheckBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            MacroTab = new TabPage();
            WorkInProgress = new TextBox();
            SettingTab = new TabPage();
            groupBox3 = new GroupBox();
            richTextBox1 = new RichTextBox();
            checkBox4 = new CheckBox();
            bindingSource1 = new BindingSource(components);
            tabControl1.SuspendLayout();
            AutoInputTab.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            MacroTab.SuspendLayout();
            SettingTab.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // autoinput_b
            // 
            autoinput_b.Location = new Point(8, 53);
            autoinput_b.Margin = new Padding(5);
            autoinput_b.Name = "autoinput_b";
            autoinput_b.Size = new Size(153, 46);
            autoinput_b.TabIndex = 0;
            autoinput_b.Text = "start";
            autoinput_b.UseVisualStyleBackColor = true;
            autoinput_b.Click += autoinput_b_Click;
            // 
            // key_text
            // 
            key_text.Location = new Point(15, 101);
            key_text.Name = "key_text";
            key_text.Size = new Size(376, 39);
            key_text.TabIndex = 1;
            key_text.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 14);
            label1.Name = "label1";
            label1.Size = new Size(44, 32);
            label1.TabIndex = 2;
            label1.Text = "off";
            // 
            // Key_label
            // 
            Key_label.AutoSize = true;
            Key_label.Location = new Point(15, 66);
            Key_label.Name = "Key_label";
            Key_label.Size = new Size(236, 32);
            Key_label.TabIndex = 3;
            Key_label.Text = "Key / String to press ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(8, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 140);
            label3.Name = "label3";
            label3.Size = new Size(210, 32);
            label3.TabIndex = 5;
            label3.Text = "click speed (in ms)";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(198, 57);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(153, 39);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(225, 22);
            label4.Name = "label4";
            label4.Size = new Size(97, 32);
            label4.TabIndex = 9;
            label4.Text = "Repeats";
            // 
            // Process_list
            // 
            Process_list.FormattingEnabled = true;
            Process_list.ItemHeight = 32;
            Process_list.Items.AddRange(new object[] { "hthtr (id:)", "hrhtr", "greg", "hthtrh", "jrjzrj", "hrthrth", "jrzjrtj", "jtzjtzj", "ztjrjrjzj" });
            Process_list.Location = new Point(807, 105);
            Process_list.Name = "Process_list";
            Process_list.Size = new Size(372, 164);
            Process_list.TabIndex = 10;
            // 
            // Searchbar
            // 
            Searchbar.Location = new Point(807, 60);
            Searchbar.Name = "Searchbar";
            Searchbar.Size = new Size(372, 39);
            Searchbar.TabIndex = 11;
            Searchbar.TextChanged += Search_text_TextChanged;
            // 
            // Search_text
            // 
            Search_text.AutoSize = true;
            Search_text.Location = new Point(807, 25);
            Search_text.Name = "Search_text";
            Search_text.Size = new Size(171, 32);
            Search_text.TabIndex = 12;
            Search_text.Text = "Search Process";
            // 
            // Selected_Process
            // 
            Selected_Process.AutoSize = true;
            Selected_Process.Location = new Point(1185, 105);
            Selected_Process.Name = "Selected_Process";
            Selected_Process.Size = new Size(85, 32);
            Selected_Process.TabIndex = 13;
            Selected_Process.Text = "Search";
            // 
            // Select_process
            // 
            Select_process.Location = new Point(1187, 60);
            Select_process.Margin = new Padding(5);
            Select_process.Name = "Select_process";
            Select_process.Size = new Size(101, 46);
            Select_process.TabIndex = 14;
            Select_process.Text = "Select";
            Select_process.UseVisualStyleBackColor = true;
            Select_process.Click += Select_process_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(AutoInputTab);
            tabControl1.Controls.Add(MacroTab);
            tabControl1.Controls.Add(SettingTab);
            tabControl1.Location = new Point(-9, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2012, 1018);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 15;
            // 
            // AutoInputTab
            // 
            AutoInputTab.Controls.Add(Run_in_b_toggle);
            AutoInputTab.Controls.Add(Use_ahk);
            AutoInputTab.Controls.Add(kb_in_Normal);
            AutoInputTab.Controls.Add(Reload_processes_b);
            AutoInputTab.Controls.Add(Start_delay_label);
            AutoInputTab.Controls.Add(start_delay_tb);
            AutoInputTab.Controls.Add(groupBox2);
            AutoInputTab.Controls.Add(groupBox1);
            AutoInputTab.Controls.Add(Searchbar);
            AutoInputTab.Controls.Add(label4);
            AutoInputTab.Controls.Add(Select_process);
            AutoInputTab.Controls.Add(textBox3);
            AutoInputTab.Controls.Add(Process_list);
            AutoInputTab.Controls.Add(label3);
            AutoInputTab.Controls.Add(Selected_Process);
            AutoInputTab.Controls.Add(textBox2);
            AutoInputTab.Controls.Add(Search_text);
            AutoInputTab.Controls.Add(autoinput_b);
            AutoInputTab.Controls.Add(label1);
            AutoInputTab.Location = new Point(8, 46);
            AutoInputTab.Name = "AutoInputTab";
            AutoInputTab.Padding = new Padding(3);
            AutoInputTab.Size = new Size(1996, 964);
            AutoInputTab.TabIndex = 0;
            AutoInputTab.Text = "Auto Input";
            AutoInputTab.UseVisualStyleBackColor = true;
            // 
            // Run_in_b_toggle
            // 
            Run_in_b_toggle.AutoSize = true;
            Run_in_b_toggle.BackColor = Color.Transparent;
            Run_in_b_toggle.CheckAlign = ContentAlignment.TopLeft;
            Run_in_b_toggle.Location = new Point(807, 275);
            Run_in_b_toggle.Name = "Run_in_b_toggle";
            Run_in_b_toggle.Size = new Size(249, 68);
            Run_in_b_toggle.TabIndex = 28;
            Run_in_b_toggle.Text = "Run in Background\r\n(can cause issues)\r\n";
            Run_in_b_toggle.UseVisualStyleBackColor = false;
            Run_in_b_toggle.CheckedChanged += Run_in_b_toggle_CheckedChanged;
            // 
            // Use_ahk
            // 
            Use_ahk.AutoSize = true;
            Use_ahk.BackColor = Color.Transparent;
            Use_ahk.Enabled = false;
            Use_ahk.Location = new Point(418, 335);
            Use_ahk.Name = "Use_ahk";
            Use_ahk.Size = new Size(216, 36);
            Use_ahk.TabIndex = 27;
            Use_ahk.Text = "Use Autohotkey\r\n";
            Use_ahk.UseVisualStyleBackColor = false;
            Use_ahk.CheckedChanged += Use_ahk_CheckedChanged;
            // 
            // kb_in_Normal
            // 
            kb_in_Normal.AutoSize = true;
            kb_in_Normal.BackColor = Color.Transparent;
            kb_in_Normal.CheckAlign = ContentAlignment.TopLeft;
            kb_in_Normal.Checked = true;
            kb_in_Normal.CheckState = CheckState.Checked;
            kb_in_Normal.Location = new Point(418, 247);
            kb_in_Normal.Name = "kb_in_Normal";
            kb_in_Normal.Size = new Size(360, 68);
            kb_in_Normal.TabIndex = 26;
            kb_in_Normal.Text = "Normal \r\n(doesnt work in some games)";
            kb_in_Normal.UseVisualStyleBackColor = false;
            kb_in_Normal.CheckedChanged += kb_in_Normal_CheckedChanged;
            // 
            // Reload_processes_b
            // 
            Reload_processes_b.Location = new Point(1187, 193);
            Reload_processes_b.Margin = new Padding(5);
            Reload_processes_b.Name = "Reload_processes_b";
            Reload_processes_b.Size = new Size(101, 76);
            Reload_processes_b.TabIndex = 25;
            Reload_processes_b.Text = "Reload\r\nprocesses";
            Reload_processes_b.UseVisualStyleBackColor = true;
            Reload_processes_b.Click += Reload_processes_b_Click;
            // 
            // Start_delay_label
            // 
            Start_delay_label.AutoSize = true;
            Start_delay_label.Location = new Point(375, 22);
            Start_delay_label.Name = "Start_delay_label";
            Start_delay_label.Size = new Size(295, 32);
            Start_delay_label.TabIndex = 24;
            Start_delay_label.Text = "Delay until starting (in ms)";
            // 
            // start_delay_tb
            // 
            start_delay_tb.Location = new Point(375, 57);
            start_delay_tb.Name = "start_delay_tb";
            start_delay_tb.Size = new Size(216, 39);
            start_delay_tb.TabIndex = 23;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.LightGray;
            groupBox2.Controls.Add(Mouse_dsc);
            groupBox2.Controls.Add(get_mous_pos);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(coor_X_tb);
            groupBox2.Controls.Add(coordinate_y_label);
            groupBox2.Controls.Add(coor_Y_tb);
            groupBox2.Controls.Add(RMB_check);
            groupBox2.Controls.Add(MMB_check);
            groupBox2.Controls.Add(LMB_check);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(6, 411);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(898, 219);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            // 
            // Mouse_dsc
            // 
            Mouse_dsc.BackColor = Color.LightGray;
            Mouse_dsc.BorderStyle = BorderStyle.FixedSingle;
            Mouse_dsc.Font = new Font("Segoe UI", 7.85F, FontStyle.Regular, GraphicsUnit.Point);
            Mouse_dsc.Location = new Point(670, 102);
            Mouse_dsc.Name = "Mouse_dsc";
            Mouse_dsc.ReadOnly = true;
            Mouse_dsc.ScrollBars = RichTextBoxScrollBars.None;
            Mouse_dsc.Size = new Size(198, 106);
            Mouse_dsc.TabIndex = 25;
            Mouse_dsc.Text = "Leave coordinates empty to press at mouse position";
            // 
            // get_mous_pos
            // 
            get_mous_pos.Location = new Point(412, 38);
            get_mous_pos.Name = "get_mous_pos";
            get_mous_pos.Size = new Size(252, 46);
            get_mous_pos.TabIndex = 24;
            get_mous_pos.Text = "Pick mouse coords";
            get_mous_pos.UseVisualStyleBackColor = true;
            get_mous_pos.Click += get_mous_pos_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(366, 102);
            label5.Name = "label5";
            label5.Size = new Size(42, 35);
            label5.TabIndex = 22;
            label5.Text = "X:";
            // 
            // coor_X_tb
            // 
            coor_X_tb.Location = new Point(412, 102);
            coor_X_tb.Name = "coor_X_tb";
            coor_X_tb.Size = new Size(252, 39);
            coor_X_tb.TabIndex = 23;
            // 
            // coordinate_y_label
            // 
            coordinate_y_label.AutoSize = true;
            coordinate_y_label.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            coordinate_y_label.Location = new Point(366, 147);
            coordinate_y_label.Name = "coordinate_y_label";
            coordinate_y_label.Size = new Size(40, 35);
            coordinate_y_label.TabIndex = 19;
            coordinate_y_label.Text = "Y:";
            // 
            // coor_Y_tb
            // 
            coor_Y_tb.Location = new Point(412, 147);
            coor_Y_tb.Name = "coor_Y_tb";
            coor_Y_tb.Size = new Size(252, 39);
            coor_Y_tb.TabIndex = 21;
            // 
            // RMB_check
            // 
            RMB_check.AutoSize = true;
            RMB_check.Location = new Point(15, 147);
            RMB_check.Name = "RMB_check";
            RMB_check.Size = new Size(261, 36);
            RMB_check.TabIndex = 20;
            RMB_check.Text = "Right Mouse Button";
            RMB_check.UseVisualStyleBackColor = true;
            // 
            // MMB_check
            // 
            MMB_check.AutoSize = true;
            MMB_check.Location = new Point(15, 105);
            MMB_check.Name = "MMB_check";
            MMB_check.Size = new Size(280, 36);
            MMB_check.TabIndex = 19;
            MMB_check.Text = "Middle Mouse Button";
            MMB_check.UseVisualStyleBackColor = true;
            // 
            // LMB_check
            // 
            LMB_check.AutoSize = true;
            LMB_check.Location = new Point(15, 63);
            LMB_check.Name = "LMB_check";
            LMB_check.Size = new Size(245, 36);
            LMB_check.TabIndex = 0;
            LMB_check.Text = "Left Mouse Button";
            LMB_check.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(7, 13);
            label2.Name = "label2";
            label2.Size = new Size(160, 32);
            label2.TabIndex = 18;
            label2.Text = "Mouse Inputs";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightGray;
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(Key_label);
            groupBox1.Controls.Add(key_text);
            groupBox1.Location = new Point(6, 234);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 147);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(7, 13);
            label6.Name = "label6";
            label6.Size = new Size(188, 32);
            label6.TabIndex = 18;
            label6.Text = "Keyboard Inputs";
            // 
            // MacroTab
            // 
            MacroTab.Controls.Add(WorkInProgress);
            MacroTab.Location = new Point(8, 46);
            MacroTab.Name = "MacroTab";
            MacroTab.Padding = new Padding(3);
            MacroTab.Size = new Size(1996, 964);
            MacroTab.TabIndex = 1;
            MacroTab.Text = "Macro";
            MacroTab.UseVisualStyleBackColor = true;
            // 
            // WorkInProgress
            // 
            WorkInProgress.BorderStyle = BorderStyle.None;
            WorkInProgress.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            WorkInProgress.Location = new Point(100, 57);
            WorkInProgress.Multiline = true;
            WorkInProgress.Name = "WorkInProgress";
            WorkInProgress.Size = new Size(400, 78);
            WorkInProgress.TabIndex = 0;
            WorkInProgress.Text = "Work in progress";
            // 
            // SettingTab
            // 
            SettingTab.Controls.Add(groupBox3);
            SettingTab.Location = new Point(8, 46);
            SettingTab.Name = "SettingTab";
            SettingTab.Size = new Size(1996, 964);
            SettingTab.TabIndex = 2;
            SettingTab.Text = "Settings";
            SettingTab.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.LightGray;
            groupBox3.Controls.Add(richTextBox1);
            groupBox3.Controls.Add(checkBox4);
            groupBox3.Location = new Point(23, 28);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(422, 156);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "can use ahk";
            // 
            // richTextBox1
            // 
            richTextBox1.AcceptsTab = true;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ImeMode = ImeMode.NoControl;
            richTextBox1.Location = new Point(46, 38);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(362, 106);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "is ahk (AutoHotKey) Installed\nif not, download it from\nhttps://www.autohotkey.com/\nor\nhttps://github.com/autohotkey/autohotkey\n";
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.CheckAlign = ContentAlignment.TopLeft;
            checkBox4.Location = new Point(12, 40);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(28, 27);
            checkBox4.TabIndex = 0;
            checkBox4.TextAlign = ContentAlignment.TopLeft;
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1300, 720);
            Controls.Add(tabControl1);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Auto Input";
            tabControl1.ResumeLayout(false);
            AutoInputTab.ResumeLayout(false);
            AutoInputTab.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            MacroTab.ResumeLayout(false);
            MacroTab.PerformLayout();
            SettingTab.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button autoinput_b;
        private System.Windows.Forms.Timer timer1;
        private TextBox key_text;
        private Label label1;
        private Label Key_label;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private ListBox Process_list;
        private TextBox Searchbar;
        private Label Search_text;
        private Label Selected_Process;
        private Button Select_process;
        private TabControl tabControl1;
        private TabPage AutoInputTab;
        private TabPage MacroTab;
        private Label label6;
        private GroupBox groupBox1;
        private BindingSource bindingSource1;

        void transparent_Label(Label sender)
        {
            
            sender.BackColor = sender.Controls.Owner.Parent.BackColor;
        }
        void transparent_richtxtb(RichTextBox sender)
        {
            sender.BackColor = sender.Controls.Owner.Parent.BackColor;
        }
        private GroupBox groupBox2;
        private Label label2;
        private CheckBox RMB_check;
        private CheckBox MMB_check;
        private CheckBox LMB_check;
        private Label Start_delay_label;
        private TextBox start_delay_tb;
        private Button Reload_processes_b;
        private Label coordinate_y_label;
        private TextBox coor_Y_tb;
        private Label label5;
        private TextBox coor_X_tb;
        private Button get_mous_pos;
        private CheckBox checkBox5;
        private CheckBox kb_in_Normal;
        private CheckBox Use_ahk;
        private TabPage SettingTab;
        private TextBox WorkInProgress;
        private CheckBox checkBox4;
        private RichTextBox richTextBox1;
        private GroupBox groupBox3;
        private RichTextBox Mouse_dsc;
        private CheckBox Run_in_b_toggle;
    }
}