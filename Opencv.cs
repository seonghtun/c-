using OpenCvSharp;

namespace tutorial
{
    class Program
    {

        static void Main(string[] args)
        {
            // Mat src = new Mat();
            // Mat src1 = new Mat(new Size(640, 480), MatType.CV_8UC3);
            // Mat src2 = new Mat(480, 640, MatType.CV_8UC3);

            // 내장 웹캠 비디오 촬영
            // VideoCapture video = new VideoCapture(0);
            // Mat frame = new Mat();

            // while (Cv2.WaitKey(33) != 'q')
            // {
            //     video.Read(frame);
            //     Console.WriteLine(frame);
            //     Cv2.ImShow("frame", frame);
            // }

            // frame.Dispose();
            // video.Release();
            // Cv2.DestroyAllWindows();

            // 사진 출력
            // Mat image = Cv2.ImRead("./img/증명사진.png", ImreadModes.Grayscale);
            // Cv2.ImShow("image", image);
            // Cv2.WaitKey(0);
            // Cv2.DestroyAllWindows();

            var video = new VideoCapture(".\videos\newjeans.mp4");
            var frame = new Mat();
            Console.WriteLine("before while", video, frame);
            while (video.PosFrames != video.FrameCount)
            {
                video.Read(frame);
                Cv2.ImShow("frame", frame);
                Cv2.WaitKey(33);
            }

            frame.Dispose();
            video.Release();
            Cv2.DestroyAllWindows();
        }
    }
}