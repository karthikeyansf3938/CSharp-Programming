using System;
namespace OperatorOverloading;
class Box
{
    private double length; //Length of a box
    private double breadth; //Breadth of a box

    private double height; //Height of a box

    public Box(double length1,double breadth1,double height1)
    {
        length=length1;
        breadth=breadth1;
        height=height1;
    }
    public Box()
    {

    }
    public double volume()
    {
       return length*breadth*height;
    }
    public static Box operator + (Box box1, Box box2)
    {
        Box box=new Box();
        box.length=box1.length+box2.length;
        box.breadth=box1.breadth+box2.breadth;
        box.height=box1.height+box2.height;
        return box;
    }
}
