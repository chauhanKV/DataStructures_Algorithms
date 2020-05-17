using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {

            FirstNonRepeatingChar obj = new FirstNonRepeatingChar();
            string ch = obj.FindFirstNonRepeatingChar("a green apple");
            Console.WriteLine(obj.ToString());
            Console.WriteLine("First Non-Repeating character is " + ch);


            FirstRepeatedCharacter rep = new FirstRepeatedCharacter();
            char repCh = rep.FindFirstRepeatedCharacter("a green apple");
            Console.WriteLine("First Repeated character is " + repCh);


            MyHashTable hashtbl = new MyHashTable();
            //hashtbl.remove(6);

            hashtbl.put(6, "A");
            hashtbl.put(8, "B");
            hashtbl.put(11, "C");
            hashtbl.put(6, "D");
            Console.WriteLine("Value of key 11 is "+ hashtbl.get(11));
            Console.WriteLine("Value of key 10 is " + hashtbl.get(10));

            //hashtbl.remove(6);
            //hashtbl.remove(7);

            //================ Most frequently repeated item in array ==============//
            HashTableExercise ex = new HashTableExercise();
            var mostRepeated = ex.GetMostFrequent(new int[12] { 1, 2, 2, 3, 3, 3, 8,8,8,8,8, 4 });
            Console.WriteLine("Most Repeated element in array is :" + mostRepeated);

            var uniquePairs = ex.countPairsWithDiff(new int[7] { 1, 7, 5, 9, 2, 12, 3 }, 2);
            Console.WriteLine("Count of numbers of unique pairs with difference of 2 :" + uniquePairs);

            var indices = ex.twoSum(new int[4] { 2, 7, 11, 15 }, 9);

            //================== Linear Probing Hash Table ========================//

            LinearProbingHashTable linearProbing = new LinearProbingHashTable();
            linearProbing.put(1, 2);
            linearProbing.put(11, 3);
            linearProbing.put(17, 5);
            linearProbing.put(3, 4);
            linearProbing.put(2, 10);
            //linearProbing.put(22, 11);

            linearProbing.remove(17);
            
            Console.WriteLine("Size of array is :" + linearProbing.size());

            Console.WriteLine("Value of key 11 is :" + linearProbing.getValue(11));

            Console.ReadLine();
        }
    }
}
