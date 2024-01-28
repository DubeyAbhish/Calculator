using System;
namespace Ram
{
    class Laxman
    {
        public static void CalCulator()
        {
            int Res;

            Console.Write("Enter your First Number :");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your Secound Number :");
            int B = Convert.ToInt32(Console.ReadLine());
           

            Console.Write("Enter your Operator(+,-,*,/) :");
            string Ope = Console.ReadLine();

            switch (Ope)
            {
                case "+":
                    Res = A + B;
                    Console.WriteLine("Add :" + Res);
                    break;
                case "-":
                    Res = A - B;
                    Console.WriteLine("Sub :" + Res);
                    break;
                case "*":
                    Res = A * B;
                    Console.WriteLine("Mul :" + Res);
                    break;
                case "/":
                    Res = A / B;
                    Console.WriteLine("Div :" + Res);
                    break;             


            }  

            Console.ReadKey();
        }
    }
}
