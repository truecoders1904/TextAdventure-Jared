/*                              Project Name:    textAdventure
 *                              Game Title:      Ilud's Oddessy
 *                              Created by:      Jared Clark on 4/11/19
 *                                               Wrote opening method, made list for inventory
 *                              Edited on:       4/12/19
 *                                               Added methods for chapters, combat, title screen, ending
 *                                               Added lists for keywords, tools, treasures, equipment, characterStats
 *                                               
 */


using System;
using System.Collections.Generic;

namespace textAdventure
{
    class Program
    {
        static void wait()  //used to wait for one second.
        {
            System.Threading.Thread.Sleep(1000);
        }//beat

        static void waitCustom(int seconds)  //used to wait for any multiple of 1 second.
        {
            for (int i =0; i<seconds ;i++)
            {
              System.Threading.Thread.Sleep(1000);
            }//for
        }//wait

        static void write(string text) //uses foreach and Thread.Sleep to slow down the "typing speed" of Console.Write.
        {                             //used for the chosen typical speed.
            foreach(char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(50);
            }//foreach
        }//write

        static void writeSlower(string text) //uses foreach and Thread.Sleep to slow down the "typing speed" of Console.Write 
        {                                   //used for a chosen slower speed.
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(100);
            }//foreach
        }//writeDramatic

        static void writeCustom(string text, int time) //uses foreach and Thread.Sleep for different typing speeds.
        {                                             //used for any other speed.
            foreach (char c in text)                 //also used with an empty string for an atypical pause.
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(time);
            }//foreach
        }//writeCustom

        static void paragraph() //used to break up paragraphs
        {
            Console.ReadLine();
            Console.Clear();
        }

        static void keyWordFont(string word) //changes font color of a keyword 
        {                                   //writes keyword at a slower speed
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            writeCustom(word.ToUpper(), 100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //LEARN KEYWORD
        }//keyWordFont

        static void instructionsFont(string text) //changes font color for instruction text
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }//instructionsFont

        static void commands()  //Prints a full list of commands
        {

        }//commands


        static double combat(double health)//more input?
        {
            return health;
        }//combat

        static void titleScreen()
        {
            //draw ascii art for title

            
        }//titleScreen

        static void opening()
        {
            //Basic instructions

            instructionsFont("Welcome to Illud's Oddesy! All commands will be one or two words.\nDuring any decision, you can enter \"Commands\". for a list of commands and \"Keywords\" for a list of keywords.\n");
            instructionsFont("When keywords appear in the text for the first time, they will look like ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("THIS");
            instructionsFont(".\n");
            wait();
            instructionsFont("The game will sometimes pause in order to break up the text. When this happens, PRESS ANY KEY to continue.\n\n");
            paragraph();

            //narration for the beginning of the game.

            wait();
            write("You are Illud Moribus, amateur spelunker.\n");
            wait();
            write("Really amateur.\n");
            wait();
            writeCustom("...actually", 100);
            write(", this will be your first ");
            wait(); 
            writeSlower("spelunk.\n\n");
            paragraph();

            write("There is a ");
            keyWordFont("cave");
            write(" near your hometown. \nLocal legends say that monsters, wizards, and other fantastical creatures live there, guarding great treasure.\n");
            write("Supposedly, many have tried to claim these treasures for themselves, but ");
            writeSlower("\"None have ever returned alive.\"");
            wait();
            writeSlower("\n...");
            write("Of course, no one returning alive doesn't mean much when everyone is too scared to explore the cave anyway.\n\n");
            paragraph();

            write("The sun is beginning to set, but you have finally arrived.\n");
            wait();
            writeSlower("Your adventure begins");
            writeCustom("....", 1000);
            paragraph();

            //place title screen here

            write("You stand at the mouth of the cave, wondering whether dangers and riches truly lie within. It is time to enter the cave.");
            paragraph();
        }//opening


        static void chapterOne()
        {
            /*Outline:
             * 
             * 
             * 
             */
            bool alive = true;          //used for gameover checks
            bool checkPoint = true;   //used for NEW checkpoints

            while (alive && checkPoint)
            {
                write("Test");
                checkPoint = false; //leave one checkpoint, start the next
                paragraph();
            }//while alive--checkpoint system.

            if (!alive)
            {
                write("Game over");
            }//if
            checkPoint = true;
            
            while (alive && checkPoint)
            {

                write("Second checkpoint");
                paragraph();
            }
        }//ch1

        static void chapterTwo()
        {
            /*Outline:
             * 
             * 
             * 
             */

        }//ch2

        static void chapterThree()
        {
            /*Outline:
             * 
             * 
             * 
             */
        }//ch3

        static void ending()
        {


        }//ending

        

        static void Main(string[] args)
        {

            //Do lists need to be public to work as intended?
            //Save/checkpoint system?Maybe checkpoints at beginning of each chapter?
            //Actually, just use while loops for a basic checkpoint
            //Use Do...while for room puzzles

            List<String> inventory = new List<String>(); //items used for health management, one time puzzles, etc.
            List<String> equipment = new List<String>(); //gear automatically equiped
            List<String> stats = new List<String>(); //Illud's health, strength, defense, current level and experience points.
            List<String> tools = new List<String>(); //items used in more than one puzzle
            List<String> keyWordsALL = new List<String>(); //keywords work even if undiscovered
            List<String> keyWordsDiscovered = new List<String>(); //user can check keywords as discovered
            List<String> treasures = new List<String>(); //can check during decisions. ASCII depiction in credits?


            Console.Title = "Illud's Oddessy";
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            //use console.beep for jumpscare?



            //opening(); //call opening method

            chapterOne();
        }//main
    }//class
}//namespace