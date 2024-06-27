using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGen promptGen = new PromptGen();
        
        string choice = "-1";
        while (choice != "5");

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            
            string userInput =  Console.ReadLine();
            
                if (choice == "1")
                {
                
                Entry entry = new Entry();
                
                {
                entry._date = entry.EntryGetDate();
                entry._promptText = promptGen.DisplayRandomPrompt();
                }

                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
        }
                else if (choice == "2")
                {
                    journal.DisplayAll();
                }
                else if (choice == "3")
                {
                    journal.LoadFromFile("jnal.txt");

                }
                else if(choice == "4")
                {
                    journal.SaveToFile("jnal.txt");
                }
    } }