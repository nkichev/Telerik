using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

static class PathStorage
{
    public static Path Load(string source)
    {
        Path loadedPath = new Path();

        loadedPath.PathList = new List<Point3D>();
        char[] splittingChars = { '[', ']', ' ', ',' };
        using (StreamReader sourceFile = new StreamReader(source))
        {
            string line = sourceFile.ReadLine();

            while (line != null)
            {
                string[] splittedString = line.Split(splittingChars, StringSplitOptions.RemoveEmptyEntries);

                int xCoord, yCoord, zCoord;

                xCoord = int.Parse(splittedString[0]);
                yCoord = int.Parse(splittedString[1]);
                zCoord = int.Parse(splittedString[2]);

                Point3D currentPoint = new Point3D(xCoord, yCoord, zCoord);

                loadedPath.PathList.Add(currentPoint);

                line = sourceFile.ReadLine();
            }
        }

        return loadedPath;
    }
    public static void Write(Path currentPath, string destinaton)
    {
        using (StreamWriter destinatonFile = new StreamWriter(destinaton))
        {
            foreach (Point3D item in currentPath.PathList)
            {
                destinatonFile.WriteLine(item.ToString());
            }
        }
    }
}