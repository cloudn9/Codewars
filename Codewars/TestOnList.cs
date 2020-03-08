using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    class TestOnList
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 1, 1, 1 };
            List<string> textList = new List<string> { "cat", "cat", "cat" };

            ChangeList(ref intList); // intList = 1, 2, 3
            ChangeList(intList); // intList = 1, 2, 3, 123
            //ChangeList(ref textList);

            printList(intList);
            printList(textList);

            Console.ReadKey();
        }

        static void ChangeList(ref List<int> myList)
        {
            myList.Add(123); // myList = 1, 1, 1, 123
            myList = new int[] { 1, 2, 3 }.ToList(); // myList = 1, 2, 3
        }
        static void ChangeList(List<int> myList)
        {
            myList.Add(123); // myList = 1, 1, 1, 123
            myList = new int[] { 1, 2, 3 }.ToList();
        }

        static void printList(IList myList)
        {
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }
        }


    }
}
