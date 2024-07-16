using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        
        string response;
        string goalType;
        string record;

        do 
        {
            Console.WriteLine("Select a choice from the menu");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6.Quit");
            
            response = Console.ReadLine();

            if (response == "1")
            {
            Console.WriteLine("What type of goal would you like to create?:");
            Console.WriteLine("1. Simple goal");
            Console.WriteLine("2. Eternal goal");
            Console.WriteLine("3. Checklist goal");
            goalType = Console.ReadLine();
            

            if (goalType == "1")
            {

            }

            else if (goalType == "2")
            {

            }

            else if (goalType == "3")
            {

            }

            else
            {
                Console.WriteLine("Please choose a valid number: 1, 2 o3 3.");
            }
        }

            else if (response == "2") 
            {
                
            }

            else if (response == "3")
            {
                    
            }

            else if (response == "4")
            {
                
            }

            else if (response == "5")

            {
                
                Console.WriteLine("What type of goal would you like to record?:");
                Console.WriteLine("1. Simple goal");
                Console.WriteLine("2. Eternal goal");
                Console.WriteLine("3. Checklist goal");
                record = Console.ReadLine();

                if (record == "1")
                {

                }

                else if (record == "2")
                {

                }

                else if (record == "3")
                {

                }

                else
                {
                    Console.WriteLine("Please choose a valid number");
                }
            }

            else 
            {
                Console.WriteLine("Nice job! Keep moving forward!!");
            }

        }

        while (response != "6");
    }
}