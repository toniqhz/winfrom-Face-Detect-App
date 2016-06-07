using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.Cuda;
using FaceDetection;

namespace winform_faceDetection
{
    public partial class Form1 : Form
    {
        private Capture capture = null;        //takes images from camera as image frames
        private bool captureInProgress; // checks if capture is executing

        void Form1_Load(object sender, System.EventArgs e)
        {
        // Do whatever
        }
        public Form1()
        {
            InitializeComponent();  
            CvInvoke.UseOpenCL = false;
            try
            {
                //Create a capture using the default camera
                capture = new Capture();

                //The event to be called when an image is grabbed
                capture.ImageGrabbed += RecordFrame;
                //The event to be called when an image is grabbed:chụp
            }
            catch (NullReferenceException excpt)
            {
                MessageBox.Show(excpt.Message);
            }
        }


        private void RecordFrame(object sender, EventArgs arg)
        {
            Mat frame = new Mat();
            capture.Retrieve(frame, 0);

            //Đưa ảnh ra imageBox
            imgCam.Image = frame;


        }
        private void ReleaseData()
        {
            if (capture != null)
                capture.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (capture != null) capture.FlipVertical = !capture.FlipVertical;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (capture != null) capture.FlipHorizontal = !capture.FlipHorizontal;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            
            if (capture != null)
            {
                if (captureInProgress)
                {  //stop the capture
                    lblFileName.Text = "Recording from camera ..";
                    btnStart.Text = "Start Capture";
                    capture.Pause();
                }
                else
                {
                    //start the capture
                    lblFileName.Text = "Take a selfie or upload your image";
                    btnStart.Text = "Stop";
                    capture.Start();
                }

                captureInProgress = !captureInProgress;
            }
        }

        private Mat detectFace(Mat inputFrame)
        {
            Mat image = inputFrame; //Read the files as an 8-bit Bgr image  
            long detectionTime;
            List<Rectangle> faces = new List<Rectangle>();
            List<Rectangle> eyes = new List<Rectangle>();

            //The cuda cascade classifier doesn't seem to be able to load "haarcascade_frontalface_default.xml" file in this release
            //disabling CUDA module for now

            bool tryUseCuda = false;
            bool tryUseOpenCL = true;


            DetectFace.Detect(
              image, "haarcascade_frontalface_default.xml", "haarcascade_eye.xml",
              faces, eyes,
              tryUseCuda,
              tryUseOpenCL,
              out detectionTime);


            foreach (Rectangle face in faces)
            {
                CvInvoke.Rectangle(image, face, new Bgr(Color.Purple).MCvScalar, 3);
                Bitmap c = inputFrame.Bitmap;
                Bitmap bmp = new Bitmap(face.Size.Width, face.Size.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawImage(c, 0, 0, face, GraphicsUnit.Pixel);


            }


            foreach (Rectangle eye in eyes)
                CvInvoke.Rectangle(image, eye, new Bgr(Color.Green).MCvScalar, 2);
            return inputFrame;
        }
        private void btnTakePic_Click(object sender, EventArgs e)
        {
            Mat mat = new Mat();
            capture.Retrieve(mat, 0);
            //Image<Bgr, Byte> frame = mat.ToImage<Bgr, Byte>();

            imgOut.Image = detectFace(mat);
            
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFd = new OpenFileDialog();
            openFd.Filter = "Images only. |*.jpg; *.jpeg;";
            DialogResult dr = openFd.ShowDialog();
            //Mat imgUpload = Image.FromFile(openFd.FileName);
            lblFileName.Text = openFd.FileName;
            Mat imgUpload = CvInvoke.Imread(openFd.FileName, Emgu.CV.CvEnum.LoadImageType.AnyColor);
            imgOut.Image = detectFace(imgUpload);
        }


    }
}
