/*                              Project Name:    textAdventure
 *                              Game Title:      Ilud's Oddessy
 *                              Created by:      Jared Clark on 4/11/19
 *                                               Wrote opening method, made list for inventory.
 *                                               
 *                              Edited by:       Jared Clark on 4/12/19
 *                                               Added methods for chapters, combat, title screen, ending.
 *                                               Added lists for keywords, tools, treasures, equipment, characterStats.
 *                                               
 *                                               Jared Clark on 4/13/19
 *                                               Rewrote method names to be clearer.
 *                                               
 *                                               Jared Clark on 4/14/19
 *                                               Removed methods and lists pertaining to combat in order to simplify gameplay.
 *                                               Removed separate list for reusable items to simplify gameplay.
 *                                               Added title screen ASCII art. Needs work on size.
 *                                               
 *                                               Jared Clark on 4/15/19
 *                                               Made lists for inventory, keywords, treasures public.
 *                                               Added methods for adding to these lists.
 *                                               Added methods for printing these lists.
 *                                               
 */


using System;
using System.Collections;
using System.Collections.Generic;

namespace textAdventure
{ 
    class Program
    {

        //public lists for keywords, inventory, etc., which will need to be called by different methods.
        static List<string> inventory = new List<string>(); //stores items for puzzles
        static List<String> keyWords = new List<String>(); //stores keywords as discovered
        static List<String> treasures = new List<String>(); //stores treasures collected

        //methods for gameplay

        static string getUserInput(string text) 
        {

            Console.WriteLine(text);
            return Console.ReadLine();
        }//getUserInput



        //methods to add to lists

        static void addInventory(string item) 
        {

            inventory.Add(item);
        }//addInventory

        static void addTreasure(string treasure) 
        {
            treasures.Add(treasure);
        }//addTreasure

        static void addKeyWord(string keyword) 
        {

            keyWords.Add(keyword);
        }//addKeyWord



        //methods to write lists

        static void checkInventory() 
        {
            for (int i = 0; i < inventory.Count; i++)
            {

                Console.WriteLine(inventory[i]);
            }//for
        }//checkInventory

        static void checkTreasure()
        {

            for (int i = 0; i < treasures.Count; i++)
            {
                Console.WriteLine(treasures[i]);
            }//for
        }//checkTreasures

        static void checkKeyWords()
        {

            for (int i = 0; i < keyWords.Count; i++)
            {
                Console.WriteLine(keyWords[i]);
            }//for
        }//checkKeyWords

        static void checkCommands()  //Prints a full list of commands
        {
            List<string> commands = new List<String>();
            for (int i = 0; i < commands.Count; i++)
            {

                Console.WriteLine("");
            }//for
        }//commands



        //methods for fonts

        static void keyWordFont(string word) //changes font color of a keyword and writes it at 100 MS.
        {                                   
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            writeSpeedOneHundredMS(word.ToUpper());
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }//keyWordFont

        static void instructionsFont(string text) //changes font color for instruction text.
        {
            //use color other than gray?
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }//instructionsFont



        //methods for pacing the text:

        static void paragraphBreak()
        {
            Console.ReadLine();
            Console.Clear();
        }//paragraphBreak

        static void waitOneSecond()  
        {
            System.Threading.Thread.Sleep(1000);
        }//waitOneSecond

        static void waitCustomSeconds(int seconds)  
        {
            for (int i =0; i<seconds ;i++)
            {
              System.Threading.Thread.Sleep(1000);
            }//for
        }//waitCustomSeconds

        static void writeSpeedFiftyMS(string text) 
        {                                         
            foreach(char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(50);
            }//foreach
        }//writeSpeedFiftyMS

        static void writeSpeedOneHundredMS(string text) 
        {                                             
            foreach (char c in text)
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(100);
            }//foreach
        }//writeSpeedOneHundredMS

        static void writeSpeedCustom(string text, int time) 
        {                                                  
            foreach (char c in text)                      
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(time);
            }//foreach
        }//writeSpeedCustom



        //methods for the game text

        static void titleScreen()
        {
            //draw ascii art for title

            //Needs work
           Console.WriteLine(@"
           @@@@@@@@@   + @ '     ,@@`                                       `@@:     @@@@,                                                                                                    
           @@@@@@@@@   @@@@@    #@@@@.                                     `@@@@     @@@@.                                                                                                    
           @@@@@@@@@   @@@@@    #@@@@.                                     `@@@@     @@@@,                                                                                                    
           @@@@@@@@@   @@@@@    #@@@@.                                     `@@@@     @@@@:                                                                                                    
            #@@@@@     @@@@@    #@@@@.                                     `@@@@     @@@@'                                                                                                    
            #@@@@@     @@@@@    #@@@@.                                     `@@@@      @@@+                                                                                                    
            #@@@@@     @@@@@    #@@@@.                                     `@@@@     `@@@#                                                                                                    
            #@@@@@     @@@@@    #@@@@.                                     `@@@@     .@@@#                                                                                                    
            #@@@@@     @@@@@    #@@@@.                              ; @.   `@@@@     ,@@@         ;`@ :                                                                                       
            #@@@@@     @@@@@    #@@@@.    `@@@@       @@@@@        @@@@@@@ `@@@@     :@@@       @@@@@@@@@#                                                                                    
            #@@@@@     @@@@@    #@@@@.    `@@@@       @@@@@      @@@@@@@@@@`@@@@               @@@@@@@@@@@                                                                                    
            #@@@@@     @@@@@    #@@@@.    `@@@@       @@@@@     .@@@@@@@@@@@@@@@              @@@@@@@@@@@@                                                                                    
            #@@@@@     @@@@@    #@@@@.    `@@@@       @@@@@     @@@@@@' .@@@@@@@             #@@@@:     @                                                                                     
            #@@@@@     @@@@@    #@@@@.    `@@@@       @@@@@    ,@@@@@     @@@@@@             '@@@@                                                                                            
            #@@@@@     @@@@@    #@@@@.    `@@@@       @@@@@    @@@@@+      @@@@@             '@@@@:                                                                                           
            #@@@@@     @@@@@    #@@@@.    `@@@@       @@@@@    @@@@@       `@@@@             #@@@@@@                                                                                          
            #@@@@@     @@@@@    #@@@@.    `@@@@       @@@@@    @@@@@       `@@@@              @@@@@@@@,                                                                                       
            #@@@@@     @@@@@    #@@@@.    `@@@@       @@@@@    @@@@@       `@@@@               @@@@@@@@@,                                                                                     
            #@@@@@     @@@@@    #@@@@.    `@@@@       @@@@@    @@@@@       `@@@@                `@@@@@@@@`                                                                                    
            #@@@@@     @@@@@    #@@@@.    `@@@@       @@@@@    @@@@@       `@@@@                  ,@@@@@@@#                                                                                   
            #@@@@@     @@@@@    #@@@@.    `@@@@#      @@@@@    @@@@@       `@@@@                    #@@@@@`                                                                                   
            #@@@@@     @@@@@    #@@@@.    .@@@@,     .@@@@@    @@@@@#      @@@@@                      @@@@@                                                                                   
            #@@@@@     @@@@@    #@@@@.    :@@@@@     @@@@@@    `@@@@@     @@@@@@             #,       @@@@                                                                                    
          @@@@@@@@@@   @@@@@    #@@@@.    #@@@@@@@@@@@@@@@@    #@@@@@@+ `@@@@@@@             ,@@,     @@@@,                                                                                   
          @@@@@@@@@@   @@@@@    #@@@@.     @@@@@@@@@@@@@@@@     @@@@@@@@@@@@@@@@             ,@@@@@@@@@@@@                                                                                    
          @@@@@@@@@@   @@@@@    #@@@@.     #@@@@@@@@@ #@@@@      @@@@@@@@@@ @@@@             '@@@@@@@@@@@+                                                                                    
          @@@@@@@@@@   @@@@@    #@@@@.      #@@@@@@@; #@@@@       @@@@@@@@  @@@@              `@@@@@@@@@                                                                                      
          @@@@@@@@@@                          #`@`#                 .@@,                         ,@@`'                                                                                        
                                                                                                                                                                                              
                                                                                                                                                                           
                                                                                       @@@@@                                                                                                  
                                                         ,`@@`;                        @@@@@                                                                                                  
                                                     #@@@@@@@@@@@                      @@@@@                                                                                                  
                                                     @@@@@@@@@@@@@@;                   @@@@@                                                                                                  
                                                   @@@@@@@@@@@@@@@@@,                  @@@@@                                                                                                  
                                                  @@@@@@@@@@@@@@@@@@@#                 @@@@@                                                                                                  
                                                 ,@@@@@@#      @@@@@@@                 @@@@@                                                                                                  
                                                 @@@@@@          @@@@@+                @@@@@                                                                                                  
                                                :@@@@@           @@@@@          @@@@;  @@@@@   ,@@@+        ;@@`#     +@@@@@@+        +@@@@@@+          ,@@@@@@       ,@@@+        ;@@`#      
                                                @@@@@            .@@@@@      :@@@@@@@@ @@@@@   @@@@@        @@@@@    @@@@@@@@@@      @@@@@@@@@@       .@@@@@@@@@@     @@@@@        @@@@@      
                                                @@@@@+           #@@@@@     :@@@@@@@@@@@@@@@   @@@@@+      +@@@@.   @@@@@@@@@@@     @@@@@@@@@@@      @@@@@@@@@@@@@    @@@@@+      +@@@@.      
                                                @@@@@             @@@@@#    @@@@@@@@@@@@@@@@   :@@@@        @@@@#   @@@@ # ;@@@     @@@@ # ;@@@     ,@@@@@; '@@@@@.   :@@@@        @@@@#      
                                               #@@@@@             @@@@@+   `@@@@@+  +@@@@@@@    @@@@@      @@@@@   @@@@`      @    @@@@`      @     @@@@@     @@@@@    @@@@@      @@@@@       
                                               '@@@@@             @@@@@'   @@@@@+     @@@@@@    @@@@@'    #@@@@,   @@@@:           @@@@:           ,@@@@      #@@@@'   @@@@@'    #@@@@,       
                                               '@@@@@             @@@@@'   @@@@@       @@@@@    +@@@@@    `@@@@    @@@@@           @@@@@           @@@@@       @@@@.   +@@@@@    `@@@@        
                                               '@@@@@             @@@@@+  +@@@@`       @@@@@     @@@@@    @@@@@    @@@@@@@#        @@@@@@@#        @@@@@       @@@@@    @@@@@    @@@@@        
                                               +@@@@@             @@@@@#  :@@@@:       @@@@@     .@@@@:  #@@@@,    #@@@@@@@@`      #@@@@@@@@`      @@@@@@@@@@@@@@@@@    .@@@@:  #@@@@,        
                                               #@@@@@             @@@@@   ,@@@@'       @@@@@      @@@@@  `@@@@      +@@@@@@@@@+     +@@@@@@@@@+    @@@@@@@@@@@@@@@@@     @@@@@  `@@@@         
                                                @@@@@+           '@@@@@   ,@@@@'       @@@@@      @@@@@  @@@@@         @@@@@@@@#       @@@@@@@@#   @@@@@@@@@@@@@@@@'     @@@@@  @@@@@         
                                                @@@@@            @@@@@    :@@@@,       @@@@@      :@@@@,#@@@@:          '@@@@@@@        '@@@@@@@   @@@@@                 :@@@@,#@@@@:         
                                                .@@@@@          +@@@@@+   +@@@@@       @@@@@       @@@@@.@@@@             +@@@@@          +@@@@@   @@@@@                  @@@@@.@@@@          
                                                #@@@@@@        #@@@@@@     @@@@@      @@@@@@        @@@@@@@@@               @@@@            @@@@   @@@@@                   @@@@@@@@@          
                                                 @@@@@@@:      @@@@@@#     @@@@@@    @@@@@@@       #@@@@@@@@'      @:      @@@@@   @:      @@@@@   :@@@@@        +        #@@@@@@@@'          
                                                  @@@@@@@@@@@@@@@@@@.      :@@@@@@@@@@@@@@@@        @@@@@@@@       @@@ + '@@@@@@   @@@ + '@@@@@@    @@@@@@`+ #:@@@@        @@@@@@@@           
                                                  #@@@@@@@@@@@@@@@@`        @@@@@@@@@@@.@@@@        .@@@@@@@       @@@@@@@@@@@@#   @@@@@@@@@@@@#    +@@@@@@@@@@@@@@        .@@@@@@@           
                                                    @@@@@@@@@@@@@@+          @@@@@@@@@;#@@@@         @@@@@@'       @@@@@@@@@@@+    @@@@@@@@@@@+      +@@@@@@@@@@@@@         @@@@@@'           
                                                      @@@@@@@@@@;              @@@@@@   @@@@         @@@@@@         `@@@@@@@        `@@@@@@@           `@@@@@@@@@+          @@@@@@            
                                                                                                     '@@@@                                                                  '@@@@             
                                                                                                     @@@@@+                                                                 @@@@@+            
                                                                                                     @@@@@                                                                  @@@@@             
                                                                                                    .@@@@                                                                  .@@@@              
                                                                                                    @@@@@#                                                                 @@@@@#             
                                                                                                   '@@@@@                                                                 '@@@@@              
                                                                                                   .@@@@:                                                                 .@@@@:");

            Console.ReadLine();
        }//titleScreen

        static void opening()
        {
            //Basic instructions

            instructionsFont("Welcome to Illud's Oddesy! All commands will be one or two words.\nDuring any decision, you can enter \"Commands\". for a list of commands and \"Keywords\" for a list of keywords.\n");
            instructionsFont("When keywords appear in the text for the first time, they will look like ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("THIS");
            instructionsFont(".\n");
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
            addKeyWord("cave");
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
            bool nextCheckPoint = false;   //used for NEW checkpoints

            do
            {

            }while (alive && !nextCheckPoint); //checkpoint 1
           
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
            
            Console.Title = "Illud's Oddessy";
            
            //opening(); //call opening method
            //chapterOne();
           
           
           
        }//main

    }//class
}//namespace