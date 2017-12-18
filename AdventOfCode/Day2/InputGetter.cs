using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Day2
{
    public static class InputGetter
    {
        public static string[] GetInputText(string fileName)
        {

            // Čita cijelu datoteku u 1 string
            string text = File.ReadAllText(fileName);
            //Console.WriteLine(text);

            //Console.WriteLine("\n\nSad liniju po liniju\n\n");

            // Čitanje cijele datoteke liniju po liniju
            string[] lines = File.ReadAllLines(fileName);
            /*
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
            */

            //Console.WriteLine("\n");

            // Parsiranje stringa u int
            //string stringNumber = "123456";
            //int parsedNumber;
            // TryParse vraća bool je li parsiranje uspjelo ili ne i vrijednost parsiranog broja pohranjuje u
            // varijablu tipa int. Prije imena varijable u koju želite pohraniti parsiranu vrijednost, obavezno
            // staviti ključnu riječ out
            //Int32.TryParse(stringNumber, out parsedNumber);
            //Console.WriteLine(parsedNumber);
            // Alternativno, malo stariji API omogućuje parsiranje direktno, kao što se učilo na OOP
            //parsedNumber = Int32.Parse(stringNumber);
            //Console.WriteLine(parsedNumber);
            return lines;
        }
    }
}
