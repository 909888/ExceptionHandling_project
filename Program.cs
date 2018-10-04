using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Project
{
    class Program
    {
        static void Main(string[] args)

        {                        //1 creating a list if int to divide
                                 //List<int> dividedNum = new List<int>() { 10, 20, 30, 40, 50 };

            //Console.WriteLine("Choose a number to divide");
            //int userNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Perfect! Now we will use the number {0} to divide the in house number we have", userNum);

            //for (int i = 0; i < dividedNum.Count; i++)
            //{

            //    Console.WriteLine(dividedNum[i] / userNum);

            //}
            //Console.ReadLine();
            //2, 3, 4 creating a list if int to divide...error
            //List<int> dividedNum = new List<int>() { 10, 20, 30, 40, 50 };

            //Console.WriteLine("Choose a number to divide");
            //int userNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Perfect! Now we will use the number {0} to divide the in house number we have", userNum);

            //for (int i = 0; i < dividedNum.Count; i++)
            //{

            //    Console.WriteLine(dividedNum[i] / userNum);

            //}
            //Console.ReadLine();


            //5 creating a list if int to divide

            try
            {
                List<int> dividedNum = new List<int>() { 10, 20, 30, 40, 50 };

                Console.WriteLine("Choose a number to divide");
                int userNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Perfect! Now we will use the number {0} to divide the in house number we have", userNum);

                for (int i = 0; i < dividedNum.Count; i++)
                {

                    Console.WriteLine(dividedNum[i] / userNum);

                }
            } 
            catch (FormatException ex)
            {
                Console.WriteLine("Error!! use a whole number. Please!");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("NO! Cant divide by zero! Try again");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }

        }   
    }
}
