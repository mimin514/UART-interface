using System;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using ZedGraph;

namespace UART2
{
    public partial class Form2 : Form
    {
        private GraphPane myzpane;
        private LineItem pitchCurve;
        private LineItem rollCurve;
        private PointPairList pitchPoints;
        private PointPairList rollPoints;
        private int timeCounter = 0;
        private SerialPort serialPort;
        private const int dataWindowSize = 10; // Size of the moving average window
        private double[] pitchWindow = new double[dataWindowSize];
        private double[] rollWindow = new double[dataWindowSize];
        private int windowIndex = 0;
        public Form2(SerialPort serialPort)
        {
            InitializeComponent();
            this.serialPort = serialPort;

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            myzpane = zedGraphControl1.GraphPane;
            myzpane.Title.Text = "Pitch and Roll";
            myzpane.XAxis.Title.Text = "Time";
            myzpane.YAxis.Title.Text = "Degrees";

            pitchPoints = new PointPairList();
            rollPoints = new PointPairList();

            pitchCurve = myzpane.AddCurve("Pitch", pitchPoints, Color.Blue, SymbolType.None);
            rollCurve = myzpane.AddCurve("Roll", rollPoints, Color.Red, SymbolType.None);

            myzpane.XAxis.Type = AxisType.Linear;
            myzpane.YAxis.Type = AxisType.Linear;

            myzpane.YAxis.Scale.Min = -90;
            myzpane.YAxis.Scale.Max = 90;
            myzpane.XAxis.Scale.Min = 0;
            myzpane.XAxis.Scale.Max = 20;
            myzpane.YAxis.Scale.MinorStep = 1;
            myzpane.YAxis.Scale.MajorStep = 10;
            myzpane.XAxis.Scale.MinorStep = 1;
            myzpane.XAxis.Scale.MajorStep = 10;

            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();

            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
            }
            else
            {
                MessageBox.Show("Serial port is not open or not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            timer1.Start();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Ensure the serial port is open before trying to read from it
            if (serialPort.IsOpen)
            {
                try
                {
                    SerialPort sp = (SerialPort)sender;
                    string data = sp.ReadLine();

                    // Process received data assuming the format is "Pitch: 18.14 Roll: -34.19"
                    string[] parts = data.Split(new[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);

                    if (parts.Length >= 4 && parts[0] == "Pitch" && parts[2] == "Roll")
                    {
                        double pitch, roll;

                        // Try parsing the pitch and roll values
                        if (double.TryParse(parts[1], out pitch) && double.TryParse(parts[3], out roll))
                        {
                            // Apply moving average filter
                            pitchWindow[windowIndex] = pitch;
                            rollWindow[windowIndex] = roll;
                            windowIndex = (windowIndex + 1) % dataWindowSize;

                            double filteredPitch = MovingAverage(pitchWindow);
                            double filteredRoll = MovingAverage(rollWindow);

                            // Update the graph on the UI thread
                            if (this.InvokeRequired)
                            {
                                if (this.IsHandleCreated && !this.IsDisposed)
                                {
                                    this.Invoke(new Action(() => UpdateGraph(filteredPitch, filteredRoll)));
                                }
                            }
                            else
                            {
                                UpdateGraph(filteredPitch, filteredRoll);
                            }
                        }
                        else
                        {
                            // Handle conversion errors
                            MessageBox.Show("Received data format is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (IOException ex)
                {
                    // Handle IO exception that occurs if the port is closed during a read
                    MessageBox.Show("Error reading from serial port: " + ex.Message, "I/O Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // Calculate the moving average of the data
        private double MovingAverage(double[] dataWindow)
        {
            double sum = 0;
            foreach (double value in dataWindow)
            {
                sum += value;
            }
            return sum / dataWindowSize;
        }

        public void UpdateGraph(double pitch, double roll)
        {
            // Thêm dữ liệu vào biểu đồ
            pitchPoints.Add(timeCounter, pitch);
            rollPoints.Add(timeCounter, roll);

            timeCounter++;

            // Thiết lập phạm vi trục X để tạo hiệu ứng cuộn
            double xMin = timeCounter > 10 ? timeCounter - 10 : 0;
            double xMax = timeCounter;

            myzpane.XAxis.Scale.Min = xMin;
            myzpane.XAxis.Scale.Max = xMax;

            // Cập nhật hiển thị biểu đồ
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Placeholder for timer logic, if needed
            zedGraphControl1.Invalidate();
        }
    }
}
