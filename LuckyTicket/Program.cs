using System;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                try
                {
                    Console.WriteLine("Input ticket number:");
                    String ticketNum = "";
                    int sumLeft = 0, sumRight = 0;
                    ticketNum = Console.ReadLine();
                    if (ticketNum.Length >= 4 && ticketNum.Length <= 8)
                    {
                        if (ticketNum.Length % 2 == 1) ticketNum = ticketNum.Insert(0, "0");
                        for (int i = 0; i < ticketNum.Length; i++)
                        {
                            if (i < ticketNum.Length / 2) sumLeft += int.Parse(ticketNum[i].ToString());
                            else sumRight += int.Parse(ticketNum[i].ToString());
                        }
                        if (sumLeft == sumRight) Console.WriteLine("Ticket number " + ticketNum + " is lucky!");
                        else Console.WriteLine("Ticket number " + ticketNum + " isn't lucky :(");
                    }
                    else
                        Console.WriteLine("Number should be 4 to 8 digits long!");
                    flag = Console.ReadKey().Key != ConsoleKey.Escape;
                }

                catch (Exception e)
                {
                    Console.WriteLine("Something is wrong :(");
                }
            }
        }
    }
}