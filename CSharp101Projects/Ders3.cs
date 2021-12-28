using System;

namespace CSharp101Projects
{
    public class Ders3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("------ ATAMA VE İŞLEMLİ ATAMA -------------");

            int x = 6;
            int y = 4;
            Console.WriteLine("x is = " + x + "\ny is = " + y);
            y = y + 2;
            Console.WriteLine("y = y + 2, y is = " + y);
            y += 2;
            Console.WriteLine("y += 2, y is = " + y);
            y /= 2;
            Console.WriteLine("y /= 2, y is = " + y);            
            x *= 2;
            Console.WriteLine("x *= 2, x is = " + x);       
            x -= 10;
            Console.WriteLine("x -= 10, x is = " + x);            

            Console.WriteLine("---- MANTIKSAL OPERATORLER -------");
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect");
                
            if(isSuccess || isCompleted)
                Console.WriteLine("Great");
            
            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine");
            
            
            Console.WriteLine("---- İLİŞKİSEL OPERATORLER -------");

            int a = 5;
            int b = 7;
            Console.WriteLine("a is = " + a + "\nb is = " + b);
            bool result = a < b;
            Console.WriteLine("a < b is " + result);
            result = a > b;
            Console.WriteLine("a > b is " + result);
            result = a >= b;
            Console.WriteLine("a >= b is " + result);
            result = a == b;
            Console.WriteLine("a == b is " + result);
            result = a <= b;
            Console.WriteLine("a <= b is " +result);
            result = a < b;
            Console.WriteLine("a < b is " + result);
            result = a != b;
            Console.WriteLine("a != b is " + result);


        }
    }
}