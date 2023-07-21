using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Madlib();
            int number = Add(1, 2, 3);
            Console.WriteLine(number);
            int number1  = Multiply(2, 2, 2);
            Console.WriteLine(number1);
            int number2 = Subtract(10, 5, 5);
            Console.WriteLine(number2);
            int number3 = Divide(10, 5);
            Console.WriteLine(number3);

        }
        public static void Madlib()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();


        }



        public static int Add(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public static int Multiply(int num1, int num2, int num3) 
        {
            return num1 * num2 * num3;
        }
        public static int Subtract(int num1, int num2, int num3) 
        {
            return num1 - num2 - num3;
        }
        public static int Divide(int num1, int num2) 
        {
            return num1 / num2;
        }
    }

}    

 
    

