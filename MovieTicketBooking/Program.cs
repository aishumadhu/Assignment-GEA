using System;

namespace MovieTicketBooking
{
    class TotalTickets
    {
        public void Category()
        {
            bool count = true;
            bool count1 = true;
            int sumTicket = 0;
            string cat = null;
            Console.WriteLine(".......Moive Ticket Booking List......");
            Console.WriteLine("Thriller = 'A'\nAction = 'B'\nDrama = 'C'\nComedy = 'D'");


            while (count)
            {
                Console.Write("\nPlease choose Moive Ticket Booking List : ");
                cat = Console.ReadLine();

                if (cat == "h" || cat == "H")
                {
                    Console.WriteLine(" ........ Seat is Available.......\nThriller = " + Thriller());
                    cat = "Thriller";
                    count = false;
                }
                else if (cat == "a" || cat == "A")
                {
                    Console.WriteLine(" .....Seat is Available ......\nAction = " + Action());
                    cat = "Action";
                    count = false;
                }
                else if (cat == "b" || cat == "B")
                {
                    Console.WriteLine(" .....Seat is Available ......\nDrama = " + Drama());
                    cat = "Drama";
                    count = false;
                }
                else if (cat == "c" || cat == "C")
                {
                    Console.WriteLine(".....Seat is Available.....\nComedy = " + Comedy());
                    cat = "Comedy";
                    count = false;
                }
                else
                {
                    Console.WriteLine("\n..... enter a Key.....");
                }
            }

            while (count1)
            {
                try
                {
                    Console.Write("\nHow many Moive tickets : ");
                    sumTicket = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception e)
                {
                    Console.WriteLine("\n.....enter a  number.......");
                }


                if (sumTicket > Action() || sumTicket < 1)
                {
                    Console.WriteLine("Sorry!, the selected number of tickets are out of range of availability.");
                    bool count2 = true;
                    while (count2)
                    {
                        Console.Write("Do you wanna continue? y/n:");
                        string choice2 = Console.ReadLine();
                        if (choice2 == "yes" || choice2 == "Yes")
                        {
                            count2 = false;
                        }
                        else if (choice2 == "no" || choice2 == "No")
                        {
                            Console.WriteLine("Thank you.");
                            count1 = false;
                            count2 = false;
                        }
                        else
                        {
                            Console.WriteLine(".....Please enter a valid key......");
                        }
                    }
                }
                else
                {

                    Console.Write("You have choosen " + sumTicket + " tickets of category '" + cat + "'\nPlease enter your name : ");
                    string name = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(sumTicket + " tickets of category-"+cat+" have been booked successfully by " + name.ToUpper());
                    Console.ForegroundColor = ConsoleColor.Gray;
                    count1 = false;

                }
            }
        }
        public int Thriller()
        {
            int thrill = 20;
            return thrill;
        }
        public int Action()
        {
            int action = 20;
            return action;
        }
        public int Drama()
        {
            int drama = 20;
            return drama;
        }
        public int Comedy()
        {
            int comedy = 20;
            return comedy;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("~~~~~~~ Welcome to Movie Ticket Booking system ~~~~~~~\n");
            //TotalTickets tickets = new TotalTickets();
            bool count = true;
            string choice = null;
            while (count)
            {
                Console.Write("Do you want to book a ticket?\nPlease Enter 'Yes' for YES and 'No' for NO : ");
                choice = Console.ReadLine();

                if (choice == "y" || choice == "Y")
                {
                    TotalTickets newTicket = new TotalTickets();
                    newTicket.Category();
                    
                    count = false;
                }
                else if (choice == "n" || choice == "N")
                {
                    Console.WriteLine("Thank you.");
                    count = false;
                }
                else
                {
                    Console.WriteLine("=======Please enter a valid key======");
                }
            }
            Console.WriteLine("\n~~~~~~~ Thank you for Useing !!! ~~~~~~~");
        }
    }
}
