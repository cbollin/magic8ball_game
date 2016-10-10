using System;
using System.Threading;
using System.Collections.Generic;

namespace ConsoleApplication
{
    public class magic8ball
    {
        public static void Main(string[] args)
        {
            TellPeopleWhatProgramThisIs();

            Random random = new Random();


            while (true)
            {
                string question = GetQuestion();

                if (question.Length == 0)
                {
                    Console.WriteLine("It's ok if you don't say anything, i'll still be here... waiting...");
                    continue;
                }

                if (question.ToLower() == "quit")
                {
                    Console.WriteLine("Sorry I couldn't help ya..");
                    break;
                }

                if (question.ToLower() == "you suck")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you are entitled to your own opinion, I still think you're an ok human");
                    break;
                }


                int randNum = random.Next(4);

                switch (randNum)
                {
                    case 0:
                        {
                            Console.WriteLine("Possibly..");
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("You should ask your doctor..");
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("I think you're asking the wrong ball");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Who even knows anymore..");
                            break;
                        }
                }
            }

        }
        static void TellPeopleWhatProgramThisIs()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("              ._a$$$$$a_. ");
            Console.WriteLine("            ,$$$$$$$$$$$$$. ");
            Console.WriteLine("          ,$$$$$$$$$$$$$$$$$. ");
            Console.WriteLine("         d$$$$$$$$$$$$$$$$$$$b ");
            Console.WriteLine("        d$$$$$$$$~.-.~$$$$$$$$b ");
            Console.WriteLine("       ($$$$$$$p   _   q$$$$$$$) ");
            Console.WriteLine("       $$$$$$$$   (_)   $$$$$$$$ ");
            Console.WriteLine("       $$$$$$$$   (_)   $$$$$$$$ ");
            Console.WriteLine("       ($$$$$$$b       d$$$$$$$) ");
            Console.WriteLine("        q$$$$$$$$a._.a$$$$$$$$p ");
            Console.WriteLine("         q$$$$$$$$$$$$$$$$$$$p ");
            Console.WriteLine("          `$$$$$$$$$$$$$$$$$ ");
            Console.WriteLine("             $$$$$$$$$$$$$ ");
            Console.WriteLine("               ~$$$$$$$~ ");
            Console.WriteLine("    Welcome to Apathetic 8 Ball - by Cassidy");

            Random random = new Random();

            Console.WriteLine("Now Loading Video Game...");
            int numberOfSecondsToSleep = random.Next(5) +1;
            Thread.Sleep(numberOfSecondsToSleep * 1000);
            Console.WriteLine("Generating Beemo Console...");
            Thread.Sleep(numberOfSecondsToSleep * 1000);

            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("░░░░▄██████████████████████▄░░░░");
            Console.WriteLine("░░░░█░░░░░░░░░░░░░░░░░░░░░░█░░░░");
            Console.WriteLine("░░░░█░▄██████████████████▄░█░░░░");
            Console.WriteLine("░░░░█░█░░░░░░░░░░░░░░░░░░█░█░░░░");
            Console.WriteLine("░░░░█░█░░░░░░░░░░░░░░░░░░█░█░░░░");
            Console.WriteLine("░░░░█░█░░█░░░░░░░░░░░░█░░█░█░░░░");
            Console.WriteLine("░░░░█░█░░░░░▄▄▄▄▄▄▄▄░░░░░█░█░░░░");
            Console.WriteLine("░░░░█░█░░░░░▀▄░░░░▄▀░░░░░█░█░░░░");
            Console.WriteLine("░░░░█░█░░░░░░░▀▀▀▀░░░░░░░█░█░░░░");
            Console.WriteLine("░░░░█░█░░░░░░░░░░░░░░░░░░█░█░░░░");
            Console.WriteLine("░█▌░█░▀██████████████████▀░█░▐█░");
            Console.WriteLine("░█░░█░░░░░░░░░░░░░░░░░░░░░░█░░█░");
            Console.WriteLine("░█░░█░████████████░░░░░██░░█░░█░");
            Console.WriteLine("░█░░█░░░░░░░░░░░░░░░░░░░░░░█░░█░");
            Console.WriteLine("░█░░█░░░░░░░░░░░░░░░▄░░░░░░█░░█░");
            Console.WriteLine("░▀█▄█░░░▐█▌░░░░░░░▄███▄░██░█▄█▀░");
            Console.WriteLine("░░░▀█░░█████░░░░░░░░░░░░░░░█▀░░░");
            Console.WriteLine("░░░░█░░░▐█▌░░░░░░░░░▄██▄░░░█░░░░");
            Console.WriteLine("░░░░█░░░░░░░░░░░░░░▐████▌░░█░░░░");
            Console.WriteLine("░░░░█░▄▄▄░▄▄▄░░░░░░░▀██▀░░░█░░░░");
            Console.WriteLine("░░░░█░░░░░░░░░░░░░░░░░░░░░░█░░░░");
            Console.WriteLine("░░░░▀██████████████████████▀░░░░");
            Console.WriteLine("░░░░░░░░██░░░░░░░░░░░░██░░░░░░░░");
            Console.WriteLine("░░░░░░░░██░░░░░░░░░░░░██░░░░░░░░");
            Console.WriteLine("░░░░░░░░██░░░░░░░░░░░░██░░░░░░░░");
            Console.WriteLine("░░░░░░░░██░░░░░░░░░░░░██░░░░░░░░");
            Console.WriteLine("░░░░░░░▐██░░░░░░░░░░░░██▌░░░░░░░");
            Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.WriteLine("Who wants to play video gaaaaaames?");

        }
        public static string GetQuestion()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("What is your question for the 8 ball...");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            string question = Console.ReadLine();
            return question;
        }
    }
}
