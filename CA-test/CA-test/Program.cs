﻿namespace CA_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Defining values step
            string personName = "Mahmood ";
            string personLastName = "Garibov";
            int personAge = 34;
            string personFullName = personName + " " + personLastName; //string Concantenation

            Console.WriteLine("Full name : " + personFullName);
            Console.WriteLine("Age : " + personAge);
        }
    }
}