using System;
using OpenCvSharp;

namespace Project
{
    class Contour_Relate2
    {
        // static void Main(string[] args)
        // {
        //     Mat src = new Mat("img/bird.jpg");
        //     Mat yellow = new Mat();
        //     Mat dst = src.Clone();

        //     Point[][] contours;
        //     HierarchyIndex[] hierarchy;

        //     Cv2.InRange(src, new Scalar(0, 127, 127), new Scalar(100, 255, 255), yellow);
        //     Cv2.FindContours(yellow, out contours, out hierarchy, RetrievalModes.Tree, ContourApproximationModes.ApproxTC89KCOS);

        //     foreach (Point[] p in contours)
        //     {

        //         double length = Cv2.ArcLength(p, true);
        //         double area = Cv2.ContourArea(p, true);

        //         if (length < 100 && area < 1000 && p.Length < 5) continue;

        //         bool convex = Cv2.IsContourConvex(p);
        //         Point[] hull = Cv2.ConvexHull(p, true);
        //         Moments moments = Cv2.Moments(p, false);

        //         Cv2.DrawContours(dst, new Point[][] { hull }, -1, Scalar.White, 1);
        //         Cv2.Circle(dst, (int)(moments.M10 / moments.M00), (int)(moments.M01 / moments.M00), 5, Scalar.Black, -1);
        //     }

        //     Cv2.ImShow("dst", dst);
        //     Cv2.WaitKey(0);
        //     Cv2.DestroyAllWindows();
        // }
    }
}