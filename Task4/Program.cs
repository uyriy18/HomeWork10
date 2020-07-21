using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This method does not support searching arrays that contain negative indexes. array must be sorted before calling " +
                "this method. If the Array does not contain the specified value, the method returns a negative integer." +
                "You can apply the bitwise complement operator (~ in C#, Not in Visual Basic) to the negative result to produce" +
                "an index. If this index is one greater than the upper bound of the array, there are no elements larger than value in the array. " +
                "Otherwise, it is the index of the first element that is larger than value.";
            string[] atext = text.Split(' ');
            int count = 0;
            Console.WriteLine("Enter the world you want to check");
            string word = Console.ReadLine();
            foreach(string item in atext)
            {
                if(word == item)
                {
                    count++;
                }
            }
            Console.WriteLine($"The word {word} was found {count} times ");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(count, word);
            

        }
    }
}
