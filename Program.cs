using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab4_5_TriviaLeaderboard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 4.5 Trivia Leaderboard \n");

            //create generic list and add values
            List<int> tList = new List<int>();
            tList.Add(4400);
            tList.Add(8900);
            tList.Add(1200);
            tList.Add(3700);
            tList.Add(7200);
            
            //print values as added to list 
            Console.WriteLine(" *Unordered list");
            foreach (int score in tList)
            {
                Console.WriteLine(score);
            }

            //sort the list in default order and print it.
            tList.Sort();
            Console.WriteLine("\n *Default Order List");
            foreach (int score in tList)
            {
                Console.WriteLine(score);
            }

            //sort the list in reverse order and print it.
            tList.Reverse();
            Console.WriteLine("\n *Reverse Order List");
            foreach (int score in tList)
            {
                Console.WriteLine(score);
            }

            //Add new score and print list in descending order 
            tList.Add(2400);
            tList.Sort();
            tList.Reverse();
            Console.WriteLine("\n *Reverse Order List with new score 2400 added");
            foreach (int score in tList)
            {
                Console.WriteLine(score);
            }

            //Remove the score 4400 from the list.
            tList.Remove(4400);
            Console.WriteLine("\n *Reverse Order List with score 4400 removed");
            foreach (int score in tList)
            {
                Console.WriteLine(score);
            }


        }
    }
}
