using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Point3DClass
{

    static void Main(string[] args)
    {
        Point3D myPoint = new Point3D(4, 2, 1);

        Console.WriteLine(myPoint.ToString());

        Console.WriteLine(Point3D.Center.ToString());

        Console.WriteLine("The distance is: {0}", Distance.Calculate(myPoint, Point3D.Center));
        Path myPath = new Path();

        myPath.PathList = new List<Point3D>();

        myPath.PathList.Add(myPoint);
        myPath.PathList.Add(Point3D.Center);

        Console.WriteLine("The Path Points after adding:");
        foreach (Point3D item in myPath.PathList)
        {
            Console.WriteLine(item.ToString());
        }

        myPath.PathList.Remove(Point3D.Center);
        Console.WriteLine("The Path Points after removing the center:");
        foreach (Point3D item in myPath.PathList)
        {
            Console.WriteLine(item.ToString());
        }

        Path loadedPath = PathStorage.Load("../../loadingpoints.txt");

        PathStorage.Write(loadedPath, "../../savedpoints.txt");
    }
}
