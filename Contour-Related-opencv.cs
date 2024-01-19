using System;
using OpenCvSharp;

namespace Project
{
    class Contour_Relate
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

        //         Rect boundingRect = Cv2.BoundingRect(p);
        //         RotatedRect rotatedRect = Cv2.MinAreaRect(p);
        //         RotatedRect ellipse = Cv2.FitEllipse(p);

        //         Point2f center;
        //         float radius;
        //         Cv2.MinEnclosingCircle(p, out center, out radius);

        //         Cv2.Rectangle(dst, boundingRect, Scalar.Red, 2);
        //         Cv2.Ellipse(dst, rotatedRect, Scalar.Blue, 2);
        //         Cv2.Ellipse(dst, ellipse, Scalar.Green, 2);
        //         Cv2.Circle(dst, (int)center.X, (int)center.Y, (int)radius, Scalar.Yellow, 2);

        //     }

        //     Cv2.ImShow("dst", dst);
        //     Cv2.ImShow("yellow", yellow);
        //     Cv2.WaitKey(0);
        //     Cv2.DestroyAllWindows();
        // }
    }
}