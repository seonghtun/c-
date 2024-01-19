using System;
using OpenCvSharp;

namespace Project
{
    class Affine
    {
        // static void Main(string[] args)
        // {
        //     Mat src = new Mat("img/sejeong.jpg");
        //     Mat dst = new Mat();

        //     List<Point2f> src_pts = new List<Point2f>()
        //     {
        //         new Point2f(0.0f, 0.0f),
        //         new Point2f(0.0f, src.Height),
        //         new Point2f(src.Width, src.Height),
        //     };

        //     List<Point2f> dst_pts = new List<Point2f> {
        //         new Point2f(50.0f,100.0f),
        //         new Point2f(300.0f, src.Height),
        //         new Point2f(src.Width - 50.0f, src.Height - 100.0f)
        //     };

        //     Mat matrix = Cv2.GetAffineTransform(src_pts, dst_pts);
        //     Cv2.WarpAffine(src, dst, matrix, new Size(src.Width, src.Height));

        //     Cv2.ImShow("dst", dst);
        //     Cv2.WaitKey(0);
        //     Cv2.DestroyAllWindows();
        // }
    }
}