namespace CohesionAndCoupling
{
    using System;

    public class ParallelepipedUtils
    {
        public static double CalcVolume(double width, double height, double depth)
        {
            double volume = width * height * depth;
            return volume;
        }
        public static double CalcDiagonalXYZ(double width, double height, double depth)
        {
            double distance = CalcDistanceUtils.CalcDistance3D(0, 0, 0, width, height, depth);
            return distance;
        }
        public static double CalcDiagonalXY(double width, double height)
        {
            double distance = CalcDistanceUtils.CalcDistance2D(0, 0, width, height);
            return distance;
        }
        public static double CalcDiagonalXZ(double width, double depth)
        {
            double distance = CalcDistanceUtils.CalcDistance2D(0, 0, width, depth);
            return distance;
        }
        public static double CalcDiagonalYZ(double height, double depth)
        {
            double distance = CalcDistanceUtils.CalcDistance2D(0, 0, height, depth);
            return distance;
        }
    }
}
