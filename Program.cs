using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            // try
            // {
            //     Console.WriteLine("Enter number!");
            //     int num = Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("The number you enter: "+num);
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine("Error: "+ex.Message.ToString());
            // }
            // finally
            // {
            //     Console.WriteLine("The operation is done.");
            // }

            try
            {
                 //int a = int.Parse(null);
                 //int a = int.Parse("test");
                 int a = int.Parse("-10000000000");

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Entered null value.");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Value is not appropriate.");
                Console.WriteLine(ex);
            }  
            catch(OverflowException ex)
            {
                Console.WriteLine("Entered a value that is either too large or too small.");
                Console.WriteLine(ex);
            }
            finally{
                Console.WriteLine("The program run succesfully.");
            }          
        }
    }
}
