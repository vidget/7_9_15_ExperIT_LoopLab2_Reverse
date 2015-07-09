using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_9_15_ExperIT_LoopLab2_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "";
            int iterator = 0; //counts the number of strings the user wants to enter
            List<string> myList = new List<string>(); //Collection of strings to hold the users input

            Console.WriteLine("Enter a String to Reverse");//user is first prompted to enter a string to just reverse
            name = Console.ReadLine();

 //print the string the user entered  in reverse by looping through the name array backwards printing each element
            for(int x=name.Length-1; x>=0 ;x--)
            {
                Console.Write(name[x]);
            }

            Console.WriteLine();//pause 

 //takes in the number of strings the user wants to enter
            Console.WriteLine("How many strings do you want to enter?");
            iterator = int.Parse(Console.ReadLine());

 //iterates through the loop based on the number of strings the user wants to enter
            for (int x = 0; x < iterator;x++)
            {
            Console.WriteLine("Enter a String to Reverse");//prompts the user for a string
            name =Console.ReadLine();//pause
            myList.Add(name);//adds the string to myList
            }

//based on the length of the list (COUNT) it iterates through the list loading each string into a tempName string
            for (int x = myList.Count()-1; x>=0 ; x--)
            {
                String tempName = "";//creates a tempName string to hold on individual string to reverse
                tempName = myList[x];

//tempName string array is printed to screen backward by decrimenting through the tempName based on it's length
                for (int y = tempName.Length - 1; y >= 0; y--)
                {
                    Console.Write(tempName[y]);
                }
                Console.Write(" ");//adds a space inbetween names
            }
   
            Console.Read();
        }
    }
}
