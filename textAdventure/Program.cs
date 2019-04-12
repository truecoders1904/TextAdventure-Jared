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
        static void beat()  //waits exactly one seconc
        {
            System.Threading.Thread.Sleep(1000);
        }//beat

        static void wait(int seconds)  //waits any multiple of 1 second
        {
            for (int i =0; i<seconds ;i++)
            {
              System.Threading.Thread.Sleep(1000);
            }//for
        }//wait

        static void write(string text) //uses Thread.Sleep to slow down the "typing speed" of Console.Write
        {                             //for the typical speed
            foreach(char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(50);
            }//foreach
        }//write

        static void writeSlower(string text) //uses Thread.Sleep to slow down the "typing speed" of Console.Write 
                                            //for a dramatic or comedic speed
        {
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(100);
            }//foreach
        }//writeDramatic

        static void writeCustom(string text, int time) //uses Thread.Sleep for different typing speeds
        {                                             //for any other spped
                                                     //can also be used with an empty string for an atypical pause
            foreach (char c in text)
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
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            writeCustom(word.ToUpper(), 200);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //LEARN KEYWORD

        }//keyWordFont

        static void instructionsFont(string text) //changes font color for instruction text
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }//instructionsFont

        static void instructions()  //Prints basic instructions and a full list of commands
        {

        }//instructions


        static double combat(double health)//more input?
        {
            return health;
        }
        static void command(string command, string keyword) //Illud attempts to do <COMMAND> on <KEYWORD>.
        {
            //PUNCH, TAKE, EXAMINE, USE, ENTER, JUMP, ATTACK

        }//command

        static void titleScreen()
        {
            //draw ascii art for title

            
        }//titleScreen

        static void opening()
        {
            //Basic instructions

            instructionsFont("Welcome to Illud's Oddesy! All commands will be one or two words.\nDuring any decision, you can enter \"Instructions\". for a list of commands and \"Keywords\" for a list of keywords.\n");
            instructionsFont("When keywords appear in the text for the first time, they will look like ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("THIS");
            instructionsFont(".\n");
            beat();
            instructionsFont("The game will sometimes pause in order to break up the text. When this happens, PRESS ANY KEY to continue.\n\n");
            paragraph();

            //narration for the beginning of the game.

            beat();
            write("You are Illud Moribus, amateur spelunker.\n");
            beat();
            write("Really amateur.\n");
            beat();
            writeCustom("...actually", 100);
            write(", this will be your first ");
            beat(); 
            writeSlower("spelunk.\n\n");
            paragraph();

            write("There is a ");
            keyWordFont("cave");
            write(" near your hometown. \nLocal legends say that monsters, wizards, and other fantastical creatures live there, guarding great treasure.\n");
            write("Supposedly, many have tried to claim these treasures for themselves, but ");
            writeSlower("\"None have ever returned alive.\"");
            beat();
            writeSlower("\n...");
            write("Of course, no one returning alive doesn't mean much when everyone is too scared to explore the cave anyway.\n\n");
            paragraph();

            write("The sun is beginning to set, but you have finally arrived.\n");
            beat();
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
           
            

            opening(); //call opening method
            
            
        }//main
    }//class
}//namespace