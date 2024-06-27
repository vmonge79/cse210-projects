using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{ 
    public List<Entry> entries = new List <Entry>();


    public void AddEntry(Entry newEntry)
    {
    
    entries.Add(newEntry);
    
    }

    public void DisplayAll()
    {
      foreach (Entry entry in entries)
        entry.Display(); 
    }

    public void SaveToFile(string filename)
    {
        Console.WriteLine("Saving...");
        using (StreamWriter outputfile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputfile.WriteLine($"{entry._date} >> {entry._promptText} >> {entry._entryText}");
            }
        }
        
    }

    public void LoadFromFile(string filename)
    {
        Console.WriteLine("Loading...");
       
        List<Entry> entries = new List<Entry>(); 
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string []parts = line.Split(">>");

            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts [1];
            newEntry._promptText = parts [2];

            entries.Add(newEntry);
        }
        
    

    }}

