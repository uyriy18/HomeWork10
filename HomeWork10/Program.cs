using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork10
{


    class Program
    {
        static void Main(string[] args)
        {

            string word;
            while (true)
            {
                Console.WriteLine("If you want to translate from RUSSIAN into ENGLISH press - \"1\"\nOR if you want to tramslate from ENGLISH into RUSSIAN - press \"2\"");
                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    Console.WriteLine("Enter the Russian world");
                    word = Console.ReadLine();
                    Console.WriteLine("English meaning is : ");
                    Console.WriteLine(Dictionary.getValue(word));
                }
                else if (choose == "2")
                {
                    Console.WriteLine("Enter the English world");
                    word = Console.ReadLine();
                    Console.WriteLine("The russian meaning is : ");
                    Console.WriteLine(Dictionary.getKey(word));
                }
                else
                {
                    Console.WriteLine("Incorrect value");
                }
            }
        }
    }
    public class Dictionary
    {
        static Dictionary<string, string> myDictionary = new Dictionary<string, string>()
        {
            ["Привет"] = "Hello",
            ["Пока"] = "Good bye",
            ["Папа"] = "Father",
            ["Мама"] = "Mother",
            ["Сын"] = "Son",
            ["Дочь"] = "Daugther"
        };
        public static string getKey(string val)
        {
            foreach (var item in myDictionary)
            {
                if (item.Value.Equals(val))
                {
                    return item.Key;
                }
            }
            return null;
        }
        public static string getValue(string val)
        {
            foreach (var item in myDictionary)
            {
                if (item.Key.Equals(val))
                {
                    return item.Value;
                }
            }
            return null;
        }




    }
}
