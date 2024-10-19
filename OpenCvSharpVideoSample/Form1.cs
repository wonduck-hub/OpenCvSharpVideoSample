using OpenCvSharp;
using OpenCvSharp.Extensions;
using System.Threading;
using System.Windows.Forms;

namespace OpenCvSharpVideoSample
{
    public partial class Form1 : Form
    {
        VideoCapture capture;
        Mat captureMat;
        bool isCameraRunning = false;

        Thread cameraThread;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadVideoButton_Click(object sender, EventArgs e)
        {
            if (isCameraRunning)
            {
                capture.Release();
                isCameraRunning = false;
            }
            else
            {
                capture = new VideoCapture(0);
                capture.Open(0);
                isCameraRunning = true;
                cameraThread = new Thread(new ThreadStart(CaptureCamera));
                cameraThread.Start();
            }

        }

        private void CaptureCamera()
        {
            Mat frame = new Mat();

            while (isCameraRunning)
            {
                frame = new Mat(100, 100, MatType.CV_8UC1);
                capture.Read(frame);
                if (!frame.Empty())
                {
                    videoPictureBox.Invoke(new Action(() =>
                    {
                        videoPictureBox.Image = BitmapConverter.ToBitmap(frame);
                    }));
                }
            }
        }
    }
}
