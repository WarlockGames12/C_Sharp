using System;
using System.Collections.Generic;


namespace EXE
{

    class Program
    {

        


        static void Main(string[] args)
        {
            Console.WriteLine("Opdracht 1: ");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Enemy Monster = new Enemy();
            Monster.Attack(70);
            Snake Enemy = new Snake();
            Enemy.Attack(10000);
            Snake Slithering = new Snake();
            Slithering.Slithering("Slithers");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Opdracht 2: ");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            //1st rectangle
            Rectangle angle = new Rectangle(45.0f,50.0f);
            float angles = angle.GetRectangle();
            Console.WriteLine("The height of the rectangle is " + angles);
            float widthAngle = angle.GetWidth();
            Console.WriteLine("The width of the rectangle is " + widthAngle);
            Console.WriteLine("-----------------------------------------------------------------------------------");
            //2nd rectangle
            float xAngle = angle.getX();
            Console.WriteLine("The x is " + xAngle);
            float yAngle = angle.getY();
            Console.WriteLine("The y is " + yAngle);
            float LengthAngle = angle.GetWidth();
            Console.WriteLine("The width of another rectangle is " + LengthAngle);
            float UpperAngle = angle.GetRectangle();
            Console.WriteLine("The height of another rectangle is " + UpperAngle);
            Console.WriteLine("-----------------------------------------------------------------------------------");
            //3rd rectangle
            float Anglex = angle.getX();
            Console.WriteLine("The x is " + Anglex);
            float Angley = angle.getY();
            Console.WriteLine("The y is " + Angley);
            float Sizinge = angle.GetRectangle();
            float Sizinge1 = angle.GetWidth();
            Console.WriteLine("The Size is " + Sizinge + " as height & " + Sizinge1 + " as width ");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            // 4th rectangle
            float GreatSize = angle.GetRectangle();
            float GreatSize1 = angle.GetWidth();
            Console.WriteLine("The Size is " + GreatSize + " as height & " + GreatSize1 + " as width ");
            Console.WriteLine("-----------------------------------------------------------------------------------");
            Console.WriteLine("Opdracht 3: ");
            Console.WriteLine("-----------------------------------------------------------------------------------");
        }
    }

    class Enemy
    {
        private int Damage;  
        public void Attack(int damage1)
        {
            Damage = damage1;
            Console.WriteLine("Enemy Deals damage " + Damage);
            
        }
        
    }

    class Snake : Enemy
    {
        private string Slither;

        public void Slithering(string Slitherr)
        {
            Slither = Slitherr;
            Console.WriteLine("The Snake " + Slitherr);
        }
    }

    class Rectangle
    {
        private float x = 40.0f;
        private float y = 50.0f;
        private float width = 50.0f;
        private float height = 45.0f;
        

        public Rectangle(float height, float width)
        {

            this.height = height;
            this.width = width;
            
        }

        public Rectangle(float xs, float ys, float width, float height)
        {
            this.x = xs;
            this.y = ys;
            this.width = width;
            this.height = height;
        }

        public Rectangle(float Getx, float Gety, float Getsize)
        {
            this.x = Getx;
            this.y = Gety;
            this.width = Getsize;
            this.height = Getsize;
        }

        public Rectangle(float Size)
        {
            this.width = Size;
            this.height = Size;

        }



        public float GetRectangle()
        {
            return height;
        }

        public float GetWidth()
        {
            return width;
        }

        public float getX()
        {
            return x;
        }

        public float getY()
        {
            return y;
        }
        
    }

   
}
