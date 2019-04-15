/*                              Project Name:    textAdventure
 *                              Game Title:      Ilud's Oddessy
 *                              Created by:      Jared Clark on 4/11/19
 *                                               Wrote opening method, made list for inventory
 *                              Edited on:       4/12/19
 *                                               Added methods for chapters, combat, title screen, ending
 *                                               Added lists for keywords, tools, treasures, equipment, characterStats
 *                                               4/13/19
 *                                               Rewrote method names to be clearer.
 *                                         
 *                                               
 */


using System;
using System.Collections.Generic;

namespace textAdventure
{
    class Program
    {
        static void waitOneSecond()  //used to wait for one second.
        {
            System.Threading.Thread.Sleep(1000);
        }//waitOneSecond

        static void waitCustomSeconds(int seconds)  //used to wait for any multiple of 1 second.
        {
            for (int i =0; i<seconds ;i++)
            {
              System.Threading.Thread.Sleep(1000);
            }//for
        }//waitCustomSeconds

        static void writeSpeedFiftyMS(string text) //uses foreach and Thread.Sleep to slow down the "typing speed" of Console.Write.
        {                             //used for the chosen typical speed.
            foreach(char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(50);
            }//foreach
        }//writeSpeedFiftyMS

        static void writeSpeedOneHundredMS(string text) //uses foreach and Thread.Sleep to slow down the "typing speed" of Console.Write 
        {                                              //used for a chosen slower speed.
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(100);
            }//foreach
        }//writeSpeedOneHundredMS

        static void writeSpeedCustom(string text, int time) //uses foreach and Thread.Sleep for different typing speeds.
        {                                                  //used for any other speed.
            foreach (char c in text)                      //also used with an empty string for an atypical pause.
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(time);
            }//foreach
        }//writeSpeedCustom

        static void paragraphBreak() //used to break up paragraphs
        {
            Console.ReadLine();
            Console.Clear();
        }//paragraphBreak

        static void keyWordFont(string word) //changes font color of a keyword 
        {                                   //writes keyword at a slower speed
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            writeSpeedOneHundredMS(word.ToUpper());
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
            waitOneSecond();
            instructionsFont("The game will sometimes pause in order to break up the text. When this happens, PRESS ANY KEY to continue.\n\n");
            paragraphBreak();

            //narration for the beginning of the game.

            waitOneSecond();
            writeSpeedFiftyMS("You are Illud Moribus, amateur spelunker.\n");
            waitOneSecond();
            writeSpeedFiftyMS("Really amateur.\n");
            waitOneSecond();
            writeSpeedCustom("...actually", 100);
            writeSpeedFiftyMS(", this will be your first ");
            waitOneSecond(); 
            writeSpeedOneHundredMS("spelunk.\n\n");
            paragraphBreak();

            writeSpeedFiftyMS("There is a ");
            keyWordFont("cave");
            writeSpeedFiftyMS(" near your hometown. \nLocal legends say that monsters, wizards, and other fantastical creatures live there, guarding great treasure.\n");
            writeSpeedFiftyMS("Supposedly, many have tried to claim these treasures for themselves, but ");
            writeSpeedOneHundredMS("\"None have ever returned alive.\"");
            waitOneSecond();
            writeSpeedOneHundredMS("\n...");
            writeSpeedFiftyMS("Of course, no one returning alive doesn't mean much when everyone is too scared to explore the cave anyway.\n\n");
            paragraphBreak();

            writeSpeedFiftyMS("The sun is beginning to set, but you have finally arrived.\n");
            waitOneSecond();
            writeSpeedOneHundredMS("Your adventure begins");
            writeSpeedCustom("....", 1000);
            paragraphBreak();

            //place title screen here

            writeSpeedFiftyMS("You stand at the mouth of the cave, wondering whether dangers and riches truly lie within.\nIt is time to enter the cave.");
            paragraphBreak();
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
                writeSpeedFiftyMS("Test");
                checkPoint = false; //leave one checkpoint, start the next
                paragraphBreak();
            }//while alive--checkpoint system.

            if (!alive)
            {
                writeSpeedFiftyMS("Game over");
            }//if
            checkPoint = true;
            
            while (alive && checkPoint)
            {

                writeSpeedFiftyMS("Second checkpoint");
                paragraphBreak();
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

            



            opening(); //call opening method

            //chapterOne();
        }//main
    }//class
}//namespace