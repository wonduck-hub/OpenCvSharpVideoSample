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
                isCameraRunning = false;
                loadVideoButton.Text = "start";
            }
            else
            {
                capture = new VideoCapture();
                capture.Open(1);
                isCameraRunning = true;
                cameraThread = new Thread(new ThreadStart(CaptureCamera));
                cameraThread.Start();
                loadVideoButton.Text = "stop";
            }

        }

        private void CaptureCamera()
        {
            Mat frame = new Mat();

            while (isCameraRunning)
            {
                capture.Read(frame);

                Cv2.CvtColor(frame, frame, ColorConversionCodes.BGR2GRAY);

                Cv2.Laplacian(frame, frame, MatType.CV_8UC1);

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
