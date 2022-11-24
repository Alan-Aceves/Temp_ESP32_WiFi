namespace ConsoleApplication2udp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_message = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_dataSaved = new System.Windows.Forms.RichTextBox();
            this.checkBox_record = new System.Windows.Forms.CheckBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBoxDataReceived = new System.Windows.Forms.RichTextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMyIP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_message
            // 
            this.textBox_message.Location = new System.Drawing.Point(112, 94);
            this.textBox_message.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_message.Multiline = true;
            this.textBox_message.Name = "textBox_message";
            this.textBox_message.Size = new System.Drawing.Size(496, 42);
            this.textBox_message.TabIndex = 0;
            // 
            // button_send
            // 
            this.button_send.ForeColor = System.Drawing.Color.Black;
            this.button_send.Location = new System.Drawing.Point(112, 155);
            this.button_send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(109, 25);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "Send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(7, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mesage";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "IP Destination";
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(112, 23);
            this.textBox_ip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(157, 22);
            this.textBox_ip.TabIndex = 6;
            this.textBox_ip.Text = "192.168.0.177";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(112, 59);
            this.textBox_port.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(157, 22);
            this.textBox_port.TabIndex = 8;
            this.textBox_port.Text = "8080";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(7, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port";
            // 
            // richTextBox_dataSaved
            // 
            this.richTextBox_dataSaved.Location = new System.Drawing.Point(109, 23);
            this.richTextBox_dataSaved.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox_dataSaved.Name = "richTextBox_dataSaved";
            this.richTextBox_dataSaved.Size = new System.Drawing.Size(869, 381);
            this.richTextBox_dataSaved.TabIndex = 10;
            this.richTextBox_dataSaved.Text = "";
            // 
            // checkBox_record
            // 
            this.checkBox_record.AutoSize = true;
            this.checkBox_record.ForeColor = System.Drawing.Color.Lime;
            this.checkBox_record.Location = new System.Drawing.Point(8, 36);
            this.checkBox_record.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_record.Name = "checkBox_record";
            this.checkBox_record.Size = new System.Drawing.Size(74, 20);
            this.checkBox_record.TabIndex = 20;
            this.checkBox_record.Text = "Record";
            this.checkBox_record.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.ForeColor = System.Drawing.Color.Black;
            this.button_clear.Location = new System.Drawing.Point(8, 64);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(81, 28);
            this.button_clear.TabIndex = 21;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(109, 23);
            this.textBoxSender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.ReadOnly = true;
            this.textBoxSender.Size = new System.Drawing.Size(157, 22);
            this.textBoxSender.TabIndex = 23;
            this.textBoxSender.Text = "192.168.0.177";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(8, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "IP ESP32";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_port);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_ip);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_send);
            this.groupBox1.Controls.Add(this.textBox_message);
            this.groupBox1.ForeColor = System.Drawing.Color.Lime;
            this.groupBox1.Location = new System.Drawing.Point(11, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(876, 198);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send Message";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBoxDataReceived);
            this.groupBox2.Controls.Add(this.buttonRefresh);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxMyIP);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxSender);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.Color.Lime;
            this.groupBox2.Location = new System.Drawing.Point(13, 220);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(997, 154);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Received Message";
            // 
            // richTextBoxDataReceived
            // 
            this.richTextBoxDataReceived.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.richTextBoxDataReceived.ForeColor = System.Drawing.Color.Lime;
            this.richTextBoxDataReceived.Location = new System.Drawing.Point(109, 68);
            this.richTextBoxDataReceived.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBoxDataReceived.MaxLength = 2;
            this.richTextBoxDataReceived.Name = "richTextBoxDataReceived";
            this.richTextBoxDataReceived.ReadOnly = true;
            this.richTextBoxDataReceived.Size = new System.Drawing.Size(869, 72);
            this.richTextBoxDataReceived.TabIndex = 22;
            this.richTextBoxDataReceived.Text = "";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.ForeColor = System.Drawing.Color.Black;
            this.buttonRefresh.Location = new System.Drawing.Point(781, 21);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(31, 27);
            this.buttonRefresh.TabIndex = 28;
            this.buttonRefresh.Text = "R";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(421, 26);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "IP myPC\r\n";
            // 
            // textBoxMyIP
            // 
            this.textBoxMyIP.Location = new System.Drawing.Point(483, 23);
            this.textBoxMyIP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMyIP.Name = "textBoxMyIP";
            this.textBoxMyIP.ReadOnly = true;
            this.textBoxMyIP.Size = new System.Drawing.Size(289, 22);
            this.textBoxMyIP.TabIndex = 24;
            this.textBoxMyIP.Text = "192.168.0.177";
            this.textBoxMyIP.Click += new System.EventHandler(this.textBoxMyIP_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mesage";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_clear);
            this.groupBox3.Controls.Add(this.checkBox_record);
            this.groupBox3.Controls.Add(this.richTextBox_dataSaved);
            this.groupBox3.ForeColor = System.Drawing.Color.Lime;
            this.groupBox3.Location = new System.Drawing.Point(13, 382);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(997, 412);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Record Message";
            // 
            // buttonStart
            // 
            this.buttonStart.ForeColor = System.Drawing.Color.Black;
            this.buttonStart.Location = new System.Drawing.Point(895, 15);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(115, 27);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Start UDP";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1025, 809);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "v22.08.09 - UDP Server Terminal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_message;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_dataSaved;
        private System.Windows.Forms.CheckBox checkBox_record;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBoxSender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMyIP;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.RichTextBox richTextBoxDataReceived;
    }
}

