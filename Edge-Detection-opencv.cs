using System;
using OpenCvSharp;

namespace Project
{
    class Edge_Detect
    {
        // static void Main(string[] args)
        // {

        //     Mat src = new Mat("img/goyun.jpg");
        //     Mat blur = new Mat();

        //     Mat sobel = new Mat();
        //     Mat scharr = new Mat();
        //     Mat laplacian = new Mat();
        //     Mat canny = new Mat();

        //     Cv2.GaussianBlur(src, blur, new Size(3, 3), 1, 0, BorderTypes.Default);

        //     Cv2.Sobel(blur, sobel, MatType.CV_32F, 1, 0, ksize: 3, scale: 1, delta: 0, BorderTypes.Default);
        //     sobel.ConvertTo(sobel, MatType.CV_8UC1);

        //     Cv2.Scharr(blur, scharr, MatType.CV_32F, 1, 0, scale: 1, delta: 0, BorderTypes.Default);
        //     scharr.ConvertTo(scharr, MatType.CV_8UC1);

        //     Cv2.Laplacian(blur, laplacian, MatType.CV_32F, ksize: 3, scale: 1, delta: 0, BorderTypes.Default);
        //     laplacian.ConvertTo(laplacian, MatType.CV_8UC1);

        //     Cv2.Canny(blur, canny, 100, 200, 3, true);

        //     Cv2.ImShow("sobel", sobel);
        //     Cv2.ImShow("scharr", scharr);
        //     Cv2.ImShow("laplacian", laplacian);
        //     Cv2.ImShow("canny", canny);
        //     Cv2.WaitKey(0);
        //     Cv2.DestroyAllWindows();
        // }
    }
}