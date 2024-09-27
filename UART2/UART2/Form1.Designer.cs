
namespace UART2
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
            this.components = new System.ComponentModel.Container();
            this.gBoxChooseSerialPort = new System.Windows.Forms.GroupBox();
            this.cBoxStopBit = new System.Windows.Forms.ComboBox();
            this.cBoxParity = new System.Windows.Forms.ComboBox();
            this.cBoxDataBit = new System.Windows.Forms.ComboBox();
            this.cBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.lbStopBit = new System.Windows.Forms.Label();
            this.lbDataBit = new System.Windows.Forms.Label();
            this.lbParity = new System.Windows.Forms.Label();
            this.lbBaudRate = new System.Windows.Forms.Label();
            this.lbPortName = new System.Windows.Forms.Label();
            this.cBoxPortName = new System.Windows.Forms.ComboBox();
            this.gBoxCtrlSerialPort = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnDisCon = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gBoxReceiver = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnClearGet = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtKi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.labelValuePID2 = new System.Windows.Forms.Label();
            this.labelValuePID1 = new System.Windows.Forms.Label();
            this.txtKd2 = new System.Windows.Forms.TextBox();
            this.txtKp2 = new System.Windows.Forms.TextBox();
            this.txtKi2 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKd = new System.Windows.Forms.TextBox();
            this.txtKp = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gBoxChooseSerialPort.SuspendLayout();
            this.gBoxCtrlSerialPort.SuspendLayout();
            this.gBoxReceiver.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxChooseSerialPort
            // 
            this.gBoxChooseSerialPort.Controls.Add(this.cBoxStopBit);
            this.gBoxChooseSerialPort.Controls.Add(this.cBoxParity);
            this.gBoxChooseSerialPort.Controls.Add(this.cBoxDataBit);
            this.gBoxChooseSerialPort.Controls.Add(this.cBoxBaudRate);
            this.gBoxChooseSerialPort.Controls.Add(this.lbStopBit);
            this.gBoxChooseSerialPort.Controls.Add(this.lbDataBit);
            this.gBoxChooseSerialPort.Controls.Add(this.lbParity);
            this.gBoxChooseSerialPort.Controls.Add(this.lbBaudRate);
            this.gBoxChooseSerialPort.Controls.Add(this.lbPortName);
            this.gBoxChooseSerialPort.Controls.Add(this.cBoxPortName);
            this.gBoxChooseSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxChooseSerialPort.Location = new System.Drawing.Point(16, 15);
            this.gBoxChooseSerialPort.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxChooseSerialPort.Name = "gBoxChooseSerialPort";
            this.gBoxChooseSerialPort.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxChooseSerialPort.Size = new System.Drawing.Size(303, 253);
            this.gBoxChooseSerialPort.TabIndex = 1;
            this.gBoxChooseSerialPort.TabStop = false;
            this.gBoxChooseSerialPort.Text = "Choose Serial Port";
            // 
            // cBoxStopBit
            // 
            this.cBoxStopBit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxStopBit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxStopBit.FormattingEnabled = true;
            this.cBoxStopBit.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.cBoxStopBit.Location = new System.Drawing.Point(116, 204);
            this.cBoxStopBit.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxStopBit.Name = "cBoxStopBit";
            this.cBoxStopBit.Size = new System.Drawing.Size(158, 30);
            this.cBoxStopBit.Sorted = true;
            this.cBoxStopBit.TabIndex = 9;
            // 
            // cBoxParity
            // 
            this.cBoxParity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxParity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxParity.FormattingEnabled = true;
            this.cBoxParity.Location = new System.Drawing.Point(116, 164);
            this.cBoxParity.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxParity.Name = "cBoxParity";
            this.cBoxParity.Size = new System.Drawing.Size(158, 30);
            this.cBoxParity.TabIndex = 8;
            // 
            // cBoxDataBit
            // 
            this.cBoxDataBit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxDataBit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxDataBit.FormattingEnabled = true;
            this.cBoxDataBit.Location = new System.Drawing.Point(116, 123);
            this.cBoxDataBit.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxDataBit.Name = "cBoxDataBit";
            this.cBoxDataBit.Size = new System.Drawing.Size(158, 30);
            this.cBoxDataBit.TabIndex = 7;
            // 
            // cBoxBaudRate
            // 
            this.cBoxBaudRate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxBaudRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxBaudRate.FormattingEnabled = true;
            this.cBoxBaudRate.Location = new System.Drawing.Point(116, 82);
            this.cBoxBaudRate.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxBaudRate.Name = "cBoxBaudRate";
            this.cBoxBaudRate.Size = new System.Drawing.Size(158, 30);
            this.cBoxBaudRate.TabIndex = 6;
            // 
            // lbStopBit
            // 
            this.lbStopBit.AutoSize = true;
            this.lbStopBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStopBit.Location = new System.Drawing.Point(8, 206);
            this.lbStopBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStopBit.Name = "lbStopBit";
            this.lbStopBit.Size = new System.Drawing.Size(73, 22);
            this.lbStopBit.TabIndex = 5;
            this.lbStopBit.Text = "Stop Bit";
            // 
            // lbDataBit
            // 
            this.lbDataBit.AutoSize = true;
            this.lbDataBit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataBit.Location = new System.Drawing.Point(7, 125);
            this.lbDataBit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDataBit.Name = "lbDataBit";
            this.lbDataBit.Size = new System.Drawing.Size(74, 22);
            this.lbDataBit.TabIndex = 5;
            this.lbDataBit.Text = "Data Bit";
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParity.Location = new System.Drawing.Point(8, 166);
            this.lbParity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(56, 22);
            this.lbParity.TabIndex = 5;
            this.lbParity.Text = "Parity";
            // 
            // lbBaudRate
            // 
            this.lbBaudRate.AutoSize = true;
            this.lbBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaudRate.Location = new System.Drawing.Point(7, 84);
            this.lbBaudRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBaudRate.Name = "lbBaudRate";
            this.lbBaudRate.Size = new System.Drawing.Size(95, 22);
            this.lbBaudRate.TabIndex = 5;
            this.lbBaudRate.Text = "Baud Rate";
            // 
            // lbPortName
            // 
            this.lbPortName.AutoSize = true;
            this.lbPortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPortName.Location = new System.Drawing.Point(7, 42);
            this.lbPortName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPortName.Name = "lbPortName";
            this.lbPortName.Size = new System.Drawing.Size(95, 22);
            this.lbPortName.TabIndex = 5;
            this.lbPortName.Text = "Port Name";
            // 
            // cBoxPortName
            // 
            this.cBoxPortName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cBoxPortName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cBoxPortName.FormattingEnabled = true;
            this.cBoxPortName.Location = new System.Drawing.Point(116, 40);
            this.cBoxPortName.Margin = new System.Windows.Forms.Padding(4);
            this.cBoxPortName.Name = "cBoxPortName";
            this.cBoxPortName.Size = new System.Drawing.Size(158, 30);
            this.cBoxPortName.TabIndex = 0;
            // 
            // gBoxCtrlSerialPort
            // 
            this.gBoxCtrlSerialPort.Controls.Add(this.progressBar1);
            this.gBoxCtrlSerialPort.Controls.Add(this.btnDisCon);
            this.gBoxCtrlSerialPort.Controls.Add(this.btnConnect);
            this.gBoxCtrlSerialPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxCtrlSerialPort.Location = new System.Drawing.Point(16, 276);
            this.gBoxCtrlSerialPort.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxCtrlSerialPort.Name = "gBoxCtrlSerialPort";
            this.gBoxCtrlSerialPort.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxCtrlSerialPort.Size = new System.Drawing.Size(306, 117);
            this.gBoxCtrlSerialPort.TabIndex = 2;
            this.gBoxCtrlSerialPort.TabStop = false;
            this.gBoxCtrlSerialPort.Text = "Serial Port Control";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(15, 35);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(263, 12);
            this.progressBar1.TabIndex = 7;
            // 
            // btnDisCon
            // 
            this.btnDisCon.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDisCon.Enabled = false;
            this.btnDisCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisCon.Location = new System.Drawing.Point(157, 55);
            this.btnDisCon.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisCon.Name = "btnDisCon";
            this.btnDisCon.Size = new System.Drawing.Size(136, 49);
            this.btnDisCon.TabIndex = 0;
            this.btnDisCon.Text = "Disconnect";
            this.btnDisCon.UseVisualStyleBackColor = false;
            this.btnDisCon.Click += new System.EventHandler(this.btnDisCon_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Lime;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(8, 55);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(141, 49);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gBoxReceiver
            // 
            this.gBoxReceiver.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gBoxReceiver.Controls.Add(this.btnExit);
            this.gBoxReceiver.Controls.Add(this.listBox1);
            this.gBoxReceiver.Controls.Add(this.btnReset);
            this.gBoxReceiver.Controls.Add(this.btnClearGet);
            this.gBoxReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxReceiver.Location = new System.Drawing.Point(340, 134);
            this.gBoxReceiver.Margin = new System.Windows.Forms.Padding(4);
            this.gBoxReceiver.Name = "gBoxReceiver";
            this.gBoxReceiver.Padding = new System.Windows.Forms.Padding(4);
            this.gBoxReceiver.Size = new System.Drawing.Size(501, 321);
            this.gBoxReceiver.TabIndex = 5;
            this.gBoxReceiver.TabStop = false;
            this.gBoxReceiver.Text = "Receiver";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(7, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(379, 268);
            this.listBox1.TabIndex = 9;
            // 
            // btnClearGet
            // 
            this.btnClearGet.BackColor = System.Drawing.Color.DeepPink;
            this.btnClearGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearGet.Location = new System.Drawing.Point(396, 31);
            this.btnClearGet.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearGet.Name = "btnClearGet";
            this.btnClearGet.Size = new System.Drawing.Size(96, 56);
            this.btnClearGet.TabIndex = 0;
            this.btnClearGet.Text = "Clear";
            this.btnClearGet.UseVisualStyleBackColor = false;
            this.btnClearGet.Click += new System.EventHandler(this.btnClearGet_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // txtKi
            // 
            this.txtKi.Location = new System.Drawing.Point(193, 40);
            this.txtKi.Name = "txtKi";
            this.txtKi.Size = new System.Drawing.Size(82, 27);
            this.txtKi.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSend2);
            this.groupBox1.Controls.Add(this.labelValuePID2);
            this.groupBox1.Controls.Add(this.labelValuePID1);
            this.groupBox1.Controls.Add(this.txtKd2);
            this.groupBox1.Controls.Add(this.txtKp2);
            this.groupBox1.Controls.Add(this.txtKi2);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtKd);
            this.groupBox1.Controls.Add(this.txtKp);
            this.groupBox1.Controls.Add(this.txtKi);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(340, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 115);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Value PID";
            // 
            // btnSend2
            // 
            this.btnSend2.BackColor = System.Drawing.Color.Navy;
            this.btnSend2.ForeColor = System.Drawing.Color.Azure;
            this.btnSend2.Location = new System.Drawing.Point(396, 73);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(90, 36);
            this.btnSend2.TabIndex = 18;
            this.btnSend2.Text = "Send";
            this.btnSend2.UseVisualStyleBackColor = false;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            // 
            // labelValuePID2
            // 
            this.labelValuePID2.AutoSize = true;
            this.labelValuePID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValuePID2.Location = new System.Drawing.Point(30, 73);
            this.labelValuePID2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValuePID2.Name = "labelValuePID2";
            this.labelValuePID2.Size = new System.Drawing.Size(71, 22);
            this.labelValuePID2.TabIndex = 17;
            this.labelValuePID2.Text = "Value 2";
            // 
            // labelValuePID1
            // 
            this.labelValuePID1.AutoSize = true;
            this.labelValuePID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValuePID1.Location = new System.Drawing.Point(30, 41);
            this.labelValuePID1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValuePID1.Name = "labelValuePID1";
            this.labelValuePID1.Size = new System.Drawing.Size(71, 22);
            this.labelValuePID1.TabIndex = 10;
            this.labelValuePID1.Text = "Value 1";
            // 
            // txtKd2
            // 
            this.txtKd2.Location = new System.Drawing.Point(281, 73);
            this.txtKd2.Name = "txtKd2";
            this.txtKd2.Size = new System.Drawing.Size(82, 27);
            this.txtKd2.TabIndex = 16;
            // 
            // txtKp2
            // 
            this.txtKp2.Location = new System.Drawing.Point(105, 73);
            this.txtKp2.Name = "txtKp2";
            this.txtKp2.Size = new System.Drawing.Size(82, 27);
            this.txtKp2.TabIndex = 15;
            // 
            // txtKi2
            // 
            this.txtKi2.Location = new System.Drawing.Point(193, 73);
            this.txtKi2.Name = "txtKi2";
            this.txtKi2.Size = new System.Drawing.Size(82, 27);
            this.txtKi2.TabIndex = 14;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Navy;
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSend.Location = new System.Drawing.Point(396, 27);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(90, 36);
            this.btnSend.TabIndex = 13;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(307, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Kd";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ki";
            // 
            // txtKd
            // 
            this.txtKd.Location = new System.Drawing.Point(281, 40);
            this.txtKd.Name = "txtKd";
            this.txtKd.Size = new System.Drawing.Size(82, 27);
            this.txtKd.TabIndex = 9;
            // 
            // txtKp
            // 
            this.txtKp.Location = new System.Drawing.Point(105, 40);
            this.txtKp.Name = "txtKp";
            this.txtKp.Size = new System.Drawing.Size(82, 27);
            this.txtKp.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gold;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(396, 176);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 56);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(396, 240);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 56);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(880, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gBoxReceiver);
            this.Controls.Add(this.gBoxCtrlSerialPort);
            this.Controls.Add(this.gBoxChooseSerialPort);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Giao diện gì đó";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxChooseSerialPort.ResumeLayout(false);
            this.gBoxChooseSerialPort.PerformLayout();
            this.gBoxCtrlSerialPort.ResumeLayout(false);
            this.gBoxReceiver.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxChooseSerialPort;
        private System.Windows.Forms.ComboBox cBoxStopBit;
        private System.Windows.Forms.ComboBox cBoxParity;
        private System.Windows.Forms.ComboBox cBoxDataBit;
        private System.Windows.Forms.ComboBox cBoxBaudRate;
        private System.Windows.Forms.Label lbStopBit;
        private System.Windows.Forms.Label lbDataBit;
        private System.Windows.Forms.Label lbParity;
        private System.Windows.Forms.Label lbBaudRate;
        private System.Windows.Forms.Label lbPortName;
        private System.Windows.Forms.ComboBox cBoxPortName;
        private System.Windows.Forms.GroupBox gBoxCtrlSerialPort;
        private System.Windows.Forms.Button btnDisCon;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gBoxReceiver;
        private System.Windows.Forms.Button btnClearGet;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtKi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKd;
        private System.Windows.Forms.TextBox txtKp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelValuePID1;
        private System.Windows.Forms.TextBox txtKd2;
        private System.Windows.Forms.TextBox txtKp2;
        private System.Windows.Forms.TextBox txtKi2;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Label labelValuePID2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
    }
}

