using System;
using OpenCvSharp;

namespace Project
{
    class Morphological
    {
        static void Main(string[] args)
        {
            Mat src = new Mat("img/nape.webp");
            src = src.SubMat(new Rect(0, 0, 640, 816));
            Console.WriteLine($"{src.Width} {src.Height}");
            Mat dilate = new Mat();
            Mat erode = new Mat();
            Mat dst = new Mat();

            Mat element = Cv2.GetStructuringElement(MorphShapes.Cross, new Size(5, 5));
            Cv2.Dilate(src, dilate, element, new Point(2, 2), 3);
            Cv2.Erode(src, erode, element, new Point(-1, -1), 3);

            Cv2.HConcat(new Mat[] { dilate, erode }, dst);
            Cv2.ImShow("dst", dst);
            Cv2.WaitKey(0);
            Cv2.DestroyAllWindows();
        }
    }
}