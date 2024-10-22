using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLtorAP
{
    //Aripa Studio
    //Aripa pars Studio 
    //Cs lang
    //I've also developed a similar library for the D language. For more information, follow us on Telegram and GitHub.
    //Name for Cs : CLtorCsAP 
    //name for D : CLtorDAP
    //V:1.0.0
    //22/10/2024

    public class CLtorAripa
    {
        //2D

        //rectangle مستطیل 
        // Area مساحت:
        public double areaOFrectangle(double length , double width)
        {
            return length * width;
        }
        //Perimeter محیط : 
        public double perimeterOFrectangle(double length , double width)
        {
            double perimeter = 2 * (length + width);
            return perimeter;
        }



        //Square مربع 
        // Area مساحت:
        public double areaOFsquare(double Side)
        {
            return Side * Side;
        }
        //محیط:
        public double perimeterOFsquare(double Side)
        {
            return Side * 4;
        }


        //Triangle
        //Area  مساحت  :
        public double areaOFtriangle(double Base , double Height)
        {
            double area2 = Base * Height;
            double area = area2 / 2;
            return area;
        }
        //Perimeter محیط:
        public double perimeterOFTriangle(double Side1 , double Side2 , double Side3)
        {
            return Side1 + Side2 + Side3;
        }


        //Rhombus
        // Area مساحت :
        public double areaOFRhombus(double Diagonal1 , double Diagonal2)
        {

            return (Diagonal1 * Diagonal2) / 2;
        }

        //Perimeter محیط:
        public double perimeterOFRhombus(double Side)
        {
            return 4 * Side;
        }



        //Parallelogram 
        //Area مساحت  :
        public double areaOFParallelogram(double Base , double Height)
        {
            return Base * Height;
        }

        //Perimeter محیط :
        public double perimeterOFParallelogram(double Length , double Width)
        {
            return 2 * (Width + Length) * 2;
        }

        //Circle
        //Area مساحت:
        public double areaOFcircle(double radius1 )
        {
            return 3.14 * radius1 * radius1;
        }
        // Perimeter محیط : 
        public double perimeterOFcircle(double diameter)
        {
            return 3.14 * diameter;
        }





        //                        //                    3D               //             //

        //Cube مکعب

        //volume حجم 
        public double volumeOFcube(double Side1 )
        {
            return Side1 * Side1 * Side1;
        }
        //Area مساحت
        public double areaOFcube(double Side)
        {
            return (Side * Side) * 6;
        }

        //Rectangular Prism مکعب مستطیل 
        // volume حجم :
        public double volumeOFRectangularPrism(double length, double width, double height)
        {
            return length * width * height;
        }

        //area مساحت : 
        public double areaOFrectangularprism(double length, double width, double height)
        {
            double frontAndBackArea = 2 * length * width;
            double topAndBottomArea = 2 * length * height;
            double leftAndRightArea = 2 * width * height;
            return frontAndBackArea + topAndBottomArea + leftAndRightArea;
        }


        //Cylinder استوانه
        public double areaOfCylinder(double radius, double height)
        {
          
            double lateralSurfaceArea = 2 * pi * radius * height;
            double baseArea = pi * radius * radius;
            return lateralSurfaceArea + 2 * baseArea;
        }

        public double volumeOfCylinder(double radius, double height)
        {
           
            return pi * radius * radius * height;
        }


        //Cone مخروط
        public double areaOfCone(double radius, double slantHeight)
        {
            
            double lateralSurfaceArea = pi * radius * slantHeight;
         
            double baseArea = pi * Pow(radius, 2);
          
            return lateralSurfaceArea + baseArea;
        }

        public double volumeOfCone(double radius, double height)
        {
         
            return (1.0 / 3.0) * pi * Pow(radius, 2) * height;
        }



        //Sphere کره
        public double pi = 3.14;
        //area مساحت:
        public double areaOFsphere(double radius)
        {
            double surfaceArea = 4 * pi * radius * radius;
            return surfaceArea;
        }
        //volume حجم :
        public double volumeOFSphere(double radius)
        {
            double volume = (4.0 / 3.0) * pi * radius * radius * radius;
            return volume;
        }








        //Pow
        public static double Pow(double baseNumber, double exponent)
        {
            double result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }
            return result;
        }

    }

}
