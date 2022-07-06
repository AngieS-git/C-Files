//by  mary angelline samson

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassSample
{
  public class Vertex3d
  {
    //fields
    private double _x;
    private double _y;
    private double _z;
    //properties
    public double X
    {
      get {return _x;}
      set {_x = value;}
    }
    public double Y
    {
      get {return _y;}
      set {_y = value;}
    }
    public double Z
    {
      get {return _z;}
      set {_z = value;}
    }
    //method
    public void SetToOrigin()
    {
      X = Y = Z = 0.0;
    }
  }
}
