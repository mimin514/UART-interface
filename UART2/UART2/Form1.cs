using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO.Ports;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace UART2
{
    public partial class Form1 : Form
    {
        private volatile bool _continue; // Biến để kiểm soát việc chạy luồng
        private string buffer = "";      // Chuỗi buffer để lưu dữ liệu tạm thời

        public Form1()
        {
            InitializeComponent();
            serialPort1 = new SerialPort();
            this.StartPosition = FormStartPosition.Manual;
            int yPosition = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Location = new Point(0, yPosition);
            int maxWidth = 0;
            using (Graphics g = listBox1.CreateGraphics())
            {
                foreach (var item in listBox1.Items)
                {
                    int itemWidth = (int)g.MeasureString(item.ToString(), listBox1.Font).Width;
                    if (itemWidth > maxWidth)
                    {
                        maxWidth = itemWidth;
                    }
                }
            }
            listBox1.HorizontalExtent = maxWidth; // Đảm bảo chiều dài không bị xuống dòng
            this.Paint += new PaintEventHandler(Form1_Paint);

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Tạo LinearGradientBrush để vẽ gradient
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle,
                Color.LightBlue,   // Màu bắt đầu
                Color.DarkSlateBlue,  // Màu kết thúc
                65f);                 // Góc của gradient (độ nghiêng)

            // Vẽ nền gradient lên toàn bộ form
            g.FillRectangle(linearGradientBrush, this.ClientRectangle);
            gBoxChooseSerialPort.BackColor = Color.Transparent;
            gBoxCtrlSerialPort.BackColor = Color.Transparent;
            gBoxReceiver.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;

        }
        string[] baud = { "1200", "2400", "4800", "9600", "14400", "19200", "38400", "56000", "57600", "115200" };
        string[] databit = { "5", "6", "7", "8" };

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] portname = SerialPort.GetPortNames();
            cBoxPortName.Items.AddRange(portname);
            cBoxBaudRate.Items.AddRange(baud);
            cBoxDataBit.Items.AddRange(databit);
            cBoxParity.Items.AddRange(Enum.GetNames(typeof(Parity)));

            cBoxPortName.SelectedItem = "COM4";
            cBoxBaudRate.SelectedItem = "9600";
            cBoxDataBit.SelectedItem = "8";
            cBoxParity.SelectedItem = "None";
            cBoxStopBit.SelectedItem = "One";

            txtKi.Text = "0.1";  
            txtKp.Text = "0.5";  
            txtKd.Text = "0.01";

            txtKi2.Text = "99";
            txtKp2.Text = "99";
            txtKd2.Text = "99";
        }

        private Form2 form2;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxPortName.Text;
                serialPort1.BaudRate = int.Parse(cBoxBaudRate.Text);
                serialPort1.DataBits = int.Parse(cBoxDataBit.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxParity.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxStopBit.Text, true);
                serialPort1.Open();

                _continue = true;
                serialPort1.DataReceived += serialPort1_DataReceived;  // Đăng ký sự kiện DataReceived

                string ki = txtKi.Text;
                string kp = txtKp.Text;
                string kd = txtKd.Text;

                string message = $"KP={kp},KI={ki},KD={kd}";
                serialPort1.Write(message);
                listBox1.Items.Add("Sent: " + message);

                progressBar1.Value = 100;
                btnConnect.Enabled = false;
                btnDisCon.Enabled = true;

                form2 = new Form2(serialPort1);
                form2.StartPosition = FormStartPosition.Manual;
                form2.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                form2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    // Đọc dữ liệu từ cổng serial
                    string data = serialPort1.ReadExisting();

                    // Thêm dữ liệu mới vào buffer
                    buffer += data;

                    // Kiểm tra nếu dữ liệu nhận được chứa ký tự kết thúc (ví dụ: '\n')
                    while (buffer.Contains("\n"))
                    {
                        // Tách phần thông điệp hoàn chỉnh (từ đầu buffer đến '\n')
                        int index = buffer.IndexOf("\n");
                        string message = buffer.Substring(0, index);

                        // Cắt bỏ phần đã xử lý khỏi buffer
                        buffer = buffer.Substring(index + 1);

                        // Loại bỏ ký tự rác (nếu cần)
                        message = message.Replace("\r", "").Replace("\n", "");

                        // Cập nhật giao diện người dùng
                        if (listBox1.InvokeRequired)
                        {
                            listBox1.Invoke(new MethodInvoker(delegate
                            {
                                listBox1.Items.Add(message);
                                listBox1.TopIndex = listBox1.Items.Count - 1; // Cuộn xuống dòng cuối
                            }));
                        }
                        else
                        {
                            listBox1.Items.Add( message);
                            listBox1.TopIndex = listBox1.Items.Count - 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading from serial port: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDisCon_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    _continue = false; // Dừng đọc dữ liệu
                    serialPort1.DataReceived -= serialPort1_DataReceived; // Hủy đăng ký sự kiện
                    serialPort1.Close();

                    if (form2 != null && !form2.IsDisposed)
                    {
                        form2.Close();
                        form2 = null;
                    }

                    listBox1.Items.Add("Disconnected");
                    progressBar1.Value = 0;
                    btnDisCon.Enabled = false;
                    btnConnect.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Serial port is already closed.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while disconnecting: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                _continue = false;
                serialPort1.DataReceived -= serialPort1_DataReceived;
                serialPort1.Close();
            }
            base.OnFormClosing(e);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string ki = txtKi.Text;
                string kp = txtKp.Text;
                string kd = txtKd.Text;

                string message = $"KP={kp},KI={ki},KD={kd}";
                serialPort1.Write(message);

                listBox1.Items.Add("Sent: " + message);
            }
            else
            {
                MessageBox.Show("Serial port is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClearGet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }



        private void btnSend2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                string ki = txtKi2.Text;
                string kp = txtKp2.Text;
                string kd = txtKd2.Text;

                string message = $"KP={kp},KI={ki},KD={kd}";
                serialPort1.Write(message);

                listBox1.Items.Add("Sent: " + message);
            }
            else
            {
                MessageBox.Show("Serial port is not open.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to reset the application?", "Reset", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                // Reset lại các thiết lập của form, hoặc khởi động lại ứng dụng
                Application.Restart();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to exit?", "Exit Application", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit(); // Thoát khỏi ứng dụng nếu người dùng nhấn "Yes"
            }
        }
    }
}
