﻿namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Bu bir custom contains methodudur";


            Console.WriteLine(sentence.CustomContains(Console.ReadLine()));

            string sentencee = "Bu bir custom split methodudur";

            string[] arr = sentencee.CustomSplitn();
            foreach (string item in arr)
            {
                Console.WriteLine(item);


            }

        }
    }
}