using System;
using System.Collections.Generic;

class Program
{

    static List<String> notes = new List<String>();
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, This is a note taking program: ");
        Console.WriteLine("What is your name? ");

        String name = Console.ReadLine();

        Console.WriteLine("Hello " + name + " \n    Please input a number from the following choices: 1-4 ");

        while (true)
        {
            Console.WriteLine(" 1 = Add Note" +
                "\n 2 = Remove Note" +
                "\n 3 = View All Notes" +
                "\n 4 = Exit ");
            Console.WriteLine("Please enter a number");

            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("What's on your mind? \n \t");
                    string note = Console.ReadLine();
                    notes.Add(note);
                    Console.WriteLine(" Got it!");
                    break;
                case 2:
                    Console.WriteLine("Which number of the note you wanna delete: ");
                    string input = Console.ReadLine();
                    int index;
                 
                    if(int.TryParse(input, out index) && index >= 1 && index <= notes.Count){
                        notes.RemoveAt(index - 1);
                        Console.WriteLine(" Deleted! ");

                    } else
                    {
                        Console.WriteLine( "Invalid ");
                    }
                        break;

                case 3:
                    Console.WriteLine("Your notes :");
                    for(int i = 0; i<notes.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ": " + notes[i]);
                    }


                    break;


                case 4:
                    Console.WriteLine("CLOSING");
                    return;

                default:
                    Console.WriteLine( "Invalid ");
                    break;
                    Console.ReadKey();
            }

        }

        

    }
}
