﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace C0726407
{ 
class Program
{
    ArrayList Beowulf;
    static void Main(string[] args)
    {
        Program p = new Program();
        p.Beowulf = new ArrayList();


        p.ReadTextFiles();

        Console.ReadLine();

    }
    public void  Run()

    { this.ReadTextFiles(); }
    public void ReadTextFiles()
    {
        // Read file using StreamReader. Reads file line by line
        using (StreamReader file = new StreamReader("U:/Users/726407/Downloads/Beowulf.txt"))
        {
            int counter = 0;
            string ln;

            while ((ln = file.ReadLine()) != null)
            {

                Console.WriteLine(ln);
                Beowulf.Add(ln);
            }
            file.Close();
            counter = File.ReadLines("U:/Users/726407/Downloads/Beowulf.txt").Count();
            
                Console.WriteLine($"File has {counter } lines.");
                Console.WriteLine($"File has {counter * 10} lines.");
            }
    }

    public int FindNumberOfBlankSpaces(string line)
    {
        // https://stackoverflow.com/questions/17812566/count-words-and-spaces-in-string-c-sharp
        int countletters = 0;
        int countSpaces = 0;

        foreach (char c in line)
        {
            if (char.IsLetter(c)) { countletters++; }
            if (char.IsWhiteSpace(c)) { countSpaces++; }
        }
        return countSpaces;
    }
}
}