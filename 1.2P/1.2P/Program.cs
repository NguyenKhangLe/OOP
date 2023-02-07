using HelloWorld;
using System;

namespace HelloWord
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var myMessage = new Message("Hello World - from Message object");
            myMessage.Print();

            Message[] messages = new Message[5];
            messages[0] = new Message("Welcome back!");
            messages[1] = new Message("What a lovely name");
            messages[2] = new Message("Great name");
            messages[3] = new Message("Oh hi!");
            messages[4] = new Message("That is a silly name");

            Console.Write("Enter the name: ");
            string name = Console.ReadLine();

            if (name.ToLower() == "phuong")
            {
                messages[0].Print();
            }

            else if (name.ToLower() == "messi")
            {
                messages[1].Print();
            }

            else if (name.ToLower() == "ronaldo")
            {
                messages[2].Print();
            }

            else if (name.ToLower() == "neymar")
            {
                messages[3].Print();
            }

            else
                messages[4].Print();
        }
    }
}