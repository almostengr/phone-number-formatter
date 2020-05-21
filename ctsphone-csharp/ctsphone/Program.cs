using System;
using System.Text.RegularExpressions;

namespace TheAlmostEngineer.ctsphone
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the default area code:");
            String defaultAreaCode = Console.ReadLine();

            while(true){
                Console.WriteLine("Enter a phone number: ");
                String inputText = Console.ReadLine();

                if (inputText == "STOP"){
                    break;
                }

                inputText = Regex.Replace(inputText,"[^0-9]","");

                switch(inputText.Length) {
                    case 7:
                        Console.WriteLine("({0}) {1}-{2}",
                            defaultAreaCode,
                            inputText.Substring(0,3),
                            inputText.Substring(3,4));
                        break;
                    case 10:
                        Console.WriteLine("({0}) {1}-{2}",
                            inputText.Substring(0,3),
                            inputText.Substring(3,3),
                            inputText.Substring(6,4));
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }
            }

            Console.WriteLine("Exiting...");
        }
    }
}
