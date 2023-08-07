using MultiThreadedFileDownload.Manager;

namespace MultiThreadedFileDownload
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                //new Menu().Run();

                bool repeat = true;
                while (repeat)
                {
                    Console.WriteLine("1- Install\n0-End");
                    byte menu = byte.Parse(Console.ReadLine());
                    if (menu == 1)
                    {
                        new Menu().Run();
                    }
                    else if (menu == 0)
                    {
                        repeat = false;
                    }


                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ex");
            }
            


        }
    }
}