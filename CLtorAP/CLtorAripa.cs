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

        //3D


    }

}
