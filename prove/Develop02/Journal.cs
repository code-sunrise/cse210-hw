using System;
using System.IO;
using System.Collections.Generic;
using System.Net.NetworkInformation;
public class Journal
{
    //load, save, and display entries from a txt file
    //function load
    static void Load()
    {
        string _filename = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("&&");

            string _date = parts[0];
            string _prompt = parts[1];
            string _entry = parts[2];
            string _wordCount = parts[3];
        }
    }
    //save
    static void Save(string input)
    {
        string _filename = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine(input);
        }
    }
    //display
    static void DisplayAll()
    {
        
    }
}