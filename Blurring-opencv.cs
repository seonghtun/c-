using System;
using OpenCvSharp;

namespace Project
{
    class Blur
    {
        // static void Main(string[] args)
        // {
        //     Mat src = new Mat("img/sejeong.jpg");
        //     Mat blur = new Mat();
        //     Mat box_filter = new Mat();
        //     Mat median_blur = new Mat();
        //     Mat gaussian_blur = new Mat();
        //     Mat bilateral_filter = new Mat();

        //     Cv2.Blur(src, blur, new Size(9, 9), new Point(-1, -1), BorderTypes.Default);
        //     Cv2.BoxFilter(src, box_filter, MatType.CV_8UC3, new Size(9, 9), new Point(-1, -1), true, BorderTypes.Default);
        //     Cv2.MedianBlur(src, median_blur, 9);
        //     Cv2.GaussianBlur(src, gaussian_blur, new Size(9, 9), 1, 1, BorderTypes.Default);
        //     Cv2.BilateralFilter(src, bilateral_filter, 9, 3, 3, BorderTypes.Default);

        //     Cv2.ImShow("blur", blur);
        //     Cv2.ImShow("box_filter", box_filter);
        //     Cv2.ImShow("median_blur", median_blur);
        //     Cv2.ImShow("gaussian_blur", gaussian_blur);
        //     Cv2.ImShow("bilateral_filter", bilateral_filter);

        //     Cv2.WaitKey(0);
        //     Cv2.DestroyAllWindows();
        // }
    }
}