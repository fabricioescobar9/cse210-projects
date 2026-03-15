using System.ComponentModel;
using System.IO.Enumeration;
using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.IO;


public class Journal
{
   public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
   {  
      _entries.Add();
   }
   public void DisplayAll()
   {
      foreach (Entry entry in _entries)
      {
         Console.Write($"Date: {entry._date} — ");
         Console.WriteLine($"Prompt: {entry._promptText}");
         Console.WriteLine($"{entry._entryText}");
         Console.WriteLine();
      }
   }
   public void SaveToFile(string file)
   {
      using (StreamWriter outputFile = new StreamWriter(file))
      {
         if (file.EndsWith(".cvs"))
         {
            foreach (Entry entry in _entries)
            {
               outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText} ");
            }
         }
         else
         {
            foreach (Entry entry in _entries)
            {
               outputFile.Write($"Date: {entry._date} — ");
               outputFile.WriteLine($"Prompt: {entry._promptText}");
               outputFile.WriteLine($"{entry._entryText}");
               outputFile.WriteLine();
            }
         }
      }
   }   
   public void LoadFromFile(string file)
       {
        if (file.EndsWith(".csv"))
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string date = parts[0];
                string prompt = parts[1];
                string entry = parts[2];
                Console.WriteLine($"Date: {date}");
                Console.WriteLine($"Prompt: {prompt}");
                Console.WriteLine($"{entry}");
                Console.WriteLine();
            }
        }
        else
        {
            using (StreamReader reader = new StreamReader(file))
            {
                string journalEntries = reader.ReadToEnd();
                Console.Write(journalEntries);
            }
        }
    }
}