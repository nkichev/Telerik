using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public struct Point3D
{
    //Fields
    public int XCoord { get; set; }
    public int YCoord { get; set; }
    public int ZCoord { get; set; }

    private static readonly Point3D center = new Point3D(0, 0, 0);

    //Properties
    public static Point3D Center
    {
        get { return center; } 
    }

    //Constructors
    public Point3D(int xCoord, int yCoord, int zCoord)
        : this()
    {
        this.XCoord = xCoord;
        this.YCoord = yCoord;
        this.ZCoord = zCoord;
    }

    //Methods
    public override string ToString()
    {
        return String.Format("[{0}, {1}, {2}]", XCoord, YCoord, ZCoord); 
    }
}

