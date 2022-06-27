using System;

namespace week6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {new Circle(2),new rectangle(34,0.94), new Triangle(14,12), new Triangle(5,6.987), new Circle(3.9)}; 
            double[] areas = new double[shapes.Length];
            for(int i= 0; i <shapes.Length;i++){
                areas[i] = shapes[i].CalculateSurace();
            }
            Console.WriteLine(areas[0]);  }
    }

    abstract class Shape{
    public double height;
    
    public double width;

    public abstract double CalculateSurace();
}

class Triangle:Shape{

    public Triangle(double height, double width ){
     this.height = height;
     this.width = width;
    }
    public override double CalculateSurace(){
        double area = height * width/2;
        return area;
    }
}

class rectangle:Shape{

    public rectangle(double height, double width ){
     this.height = height;
     this.width = width;
    }
    public override double CalculateSurace(){
        double area = height * width;
        return area;
    }
}

class Circle:Shape{
    double pi; 
    public Circle(double radius){
    pi = 3.14159;
    height=radius;
    width=radius;
    }
    public override double CalculateSurace(){
        double area = pi * height * width;
        return area;
    }
}
}

