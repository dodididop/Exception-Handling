using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                 Console.WriteLine("Enter number!");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number you enter: "+num);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("The operation is done.");
            }
            
        }
    }
}
