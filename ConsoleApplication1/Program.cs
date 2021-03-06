﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//using static ConsoleApplication1.std;

namespace ConsoleApplication1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            //new ProgramXX().ain(null);
            //new std(); //std -> constructor1
            //new std(2); //std -> constructor2

            Console.Write("Enter a value: ");
            

            try
            {
                int inp = Int16.Parse(Console.ReadLine());
                Console.WriteLine(inp);
                switch (inp)
                {
                    case 1:
                        new files(); 
                        break;                        
                    case 2:
                        new files(0); 
                        break;
                    case 3:
                        new files(0, 0);
                        break;
                    case 4:
                        new exter1();
                        break;
                    case 5:
                        new db2();
                        break;
                    case 6:
                        new db2(0);
                        break;
                    default:
                        Console.WriteLine("invalid argument");
                        break; //must to have break.
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("exception occured\n-----------------------");
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }


    //this class represents a simple word guessing game
    class ProgramXX
    {
        //public int x = 0;
        public void ain(string[] args)
        {
            //new Program();
            //Program.Program(
            //initialize variables, user inputs, word list and scanner
            String[] wlist = {"cat", "dog", "donkey", "monkey", "bird", "lion", "desk", "chair", "table", "plane", "train"};
            String rword;
            char guess;
            char[] guesses = {'x', 'x', 'x', 'x', 'x', 'x'};
            int usr_in, wno;
            //Scanner no = new Scanner(System.in);

		    Console.WriteLine("You are given 10 chances to guess the correct word. Use only lower case letters");
		    //select random word from list
            Random rnd= new Random();
            wno = rnd.Next(0,11);

            //wno = (int) (Math.random()*10);
            rword = wlist[wno];

            for (int i = 0; i < rword.Length; i++){
                Console.Write("_ ");
            }
		    Console.WriteLine();
		
		    //user is givem 10 chances
            for (int i=0; i<10; i++){
    			Console.Write("Guess: ");
                //guess = no.nextLine().charAt(0);
                guess = char.Parse(Console.ReadLine().Substring(0,1));

                checkguess(guess, rword, guesses);
            
                if(isWin(guesses, rword)){
                    Console.Write("You won");
                    //System.exit(0);
                    Console.Read();
                    return;
                }
                
            }

            Console.WriteLine("you lost..\n Correct word: " + rword);


            //Console.ReadLine();
            Console.Read();
        }

        //check whether user guess is correct
        static void checkguess(char uin, String word, char[] gword){
            for (int i=0; i<word.Length; i++) {
                if (uin == word[i]) {
                    gword[i] = uin;
                }
        

			    //display user progress
                if (gword[i]!='x') {
                    Console.Write(gword[i]);
                } else {
                    Console.Write(" _");
                }
            }
            Console.WriteLine();
        }

        //check whether user won or not
        static bool isWin(char[] word, String rand_word)
        {

            for (int i = 0; i < rand_word.Length; i++)
            {
                //if (word[i] != rand_word.charAt(i))
                if (word[i] != rand_word[i])
                    return false;
            }
            return true;
        }
    }
}
