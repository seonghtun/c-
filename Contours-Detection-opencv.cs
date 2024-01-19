using System;
using OpenCvSharp;

namespace Project
{
    class Contour_Dectect
    {
        // static void Main(string[] args)
        // {
        //     Mat src = new Mat("img/yellow.png");
        //     Mat yellow = new Mat();
        //     Mat dst = src.Clone();

        //     Point[][] contours;
        //     HierarchyIndex[] hierarchy;

        //     Cv2.InRange(src, new Scalar(0, 127, 127), new Scalar(100, 255, 255), yellow);
        //     Cv2.FindContours(yellow, out contours, out hierarchy, RetrievalModes.Tree, ContourApproximationModes.ApproxTC89KCOS);

        //     List<Point[]> new_conturs = new List<Point[]>();
        //     foreach (Point[] p in contours)
        //     {
        //         double length = Cv2.ArcLength(p, true);
        //         if (length > 100)
        //         {
        //             new_conturs.Add(p);
        //         }
        //     }

        //     Cv2.DrawContours(dst, new_conturs, -1, new Scalar(255, 0, 0), 2, LineTypes.AntiAlias, null, 1);
        //     Cv2.ImShow("dst", dst);
        //     Cv2.WaitKey(0);
        //     Cv2.DestroyAllWindows();
        // }
    }
}