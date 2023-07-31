using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment19_Part2
{
    public delegate T Operation<T>(T num1, T num2);

    internal class Program
    {
        static void Main(string[] args)
        {

            Operation<int> addIntOperation = Calcs.Add;
         

            Operation<int> subtractIntOperation = Calcs.Subtract;
          

            Operation<int> multiplyIntOperation = Calcs.Multiply;
          

            Operation<int> divideIntOperation = Calcs.Divide;
          


            Console.WriteLine("Choose an operation:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int choice = int.Parse(Console.ReadLine());
            
            int num1,num2;
        

            try
            {
                int Intresult = 0;
              
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter number 1");
                            num1= int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter number 2 ");
                            num2= int.Parse(Console.ReadLine());
                     
                            Intresult = addIntOperation(num1, num2);
                            Console.WriteLine($"{num1}+{num2}=" + Intresult);
                        
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter number 1");
                            num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter number 2");
                            num2 = int.Parse(Console.ReadLine());
                       
                            Intresult = subtractIntOperation(num1, num2);
                            Console.WriteLine($"{num1}-{num2}=" + Intresult);
                           
                            break;
                        }
                    case 3:
                        {

                            Console.WriteLine("Enter number 1 ");
                            num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter number 2");
                            num2 = int.Parse(Console.ReadLine());
                   
                            Intresult = multiplyIntOperation(num1, num2);
                            Console.WriteLine($"{num1}*{num2}=" + Intresult);
                          
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter number 1");
                            num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter number 2");
                            num2 = int.Parse(Console.ReadLine());
                            Intresult = divideIntOperation(num1, num2);
                            Console.WriteLine($"{num1}/{num2}=" + Intresult);

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid Choice");
                            break;
                        }

                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Error " + e.Message);

            }
            Console.ReadKey();
        }
    }
}
 