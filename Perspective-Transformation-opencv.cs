using System;
using OpenCvSharp;

namespace Project
{
    class Perspective_Transformation
    {
        // static void Main(string[] args)
        // {
        //     Mat src = new Mat("img/증명사진.png");
        //     Mat dst = new Mat();

        //     List<Point2f> src_pts = new List<Point2f>(){
        //         new Point2f(0.0f, 0.0f),
        //         new Point2f(0.0f, src.Height),
        //         new Point2f(src.Width, src. Height),
        //         new Point2f(src.Width, 0.0f)
        //     };

        //     List<Point2f> dst_pts = new List<Point2f>() {
        //         new Point2f(100.0f, 0.0f),
        //         new Point2f(0.0f, src.Height - 100.0f),
        //         new Point2f(src.Width - 100.0f , src.Height),
        //         new Point2f(src.Width , 100.0f)
        //     };

        //     Mat matrix = Cv2.GetPerspectiveTransform(src_pts, dst_pts);
        //     Cv2.WarpPerspective(src, dst, matrix, new Size(src.Width, src.Height));

        //     Cv2.ImShow("dst", dst);
        //     Cv2.WaitKey(0);
        //     Cv2.DestroyAllWindows();
        // }
    }
}