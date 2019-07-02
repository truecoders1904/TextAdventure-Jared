using System;
using System.Collections;
using System.Collections.Generic;

namespace textAdventure
{ 
    class Program
    {
        //public lists for keywords, inventory, etc., which will need to be called by different methods.
        static List<String> inventory = new List<String>(); //stores items for puzzles
        static List<String> keyWords = new List<String>(); //stores keywords as discovered
        static List<String> treasures = new List<String>(); //stores treasures collected
        static List<String> commands = new List<String>(); //stores list of commands

        static void Main(string[] args)
        {
            
            Console.Title = "Illud's Oddessy";

            //add commands
            commands.Add("use");
            commands.Add("check");
            commands.Add("punch");
            commands.Add("take");
            opening();

            //TODO: REPLACE text with .txt, reduce similar methods.
        }//main

        //methods for the game text

        static void opening()
        {
            //Basic instructions

            InstructionsFont("Welcome to Illud's Oddesy! \nIn this game, different font colors indicate different kinds of text. \nInstructions will appear in this cyan color.\n");
            InstructionsFont("When keywords appear in the text for the first time, they will look like \"");
            AddKeyWord("this");
            InstructionsFont("\".\n");
            InstructionsFont("And the normal text of the game will look like \"");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("this");
            InstructionsFont("\". \n");
            InstructionsFont("All commands will be one or two words.\nDuring any command decision, you can enter: \n\n\"Commands\". for a list of commands, \n\"Keywords\" for a list of discovered keywords,\n\"inventory\" for a list of acquired items, \nand \"treasure\" for a list of treasures.\n\n");
            InstructionsFont("The game will sometimes leave two blank lines and pause in order to break up the text. When this happens, \nPRESS ANY KEY to continue.");
            ParagraphBreak();

            //narration for the beginning of the game.

            WriteSpeed("You are Illud Moribus, amateur spelunker.\n", 50);
            WaitCustomSeconds(1);
            WriteSpeed("Really amateur.\n", 50);
            WaitCustomSeconds(1);
            WriteSpeed("Actually, this will be your first", 50);
            WriteSpeed("...", 100);
            WaitCustomSeconds(1); 
            WriteSpeed("spelunk.", 50);
            PauseText();

            WriteSpeed("There is a ", 50);
            AddKeyWord("cave");
            WriteSpeed(" near your hometown. \nLocal legends say that monsters, wizards, and other fantastical creatures live there, guarding great treasure.\n", 50);
            WriteSpeed("Supposedly, many have tried to claim these treasures for themselves, but ", 50);
            WriteSpeed("\"None have ever returned alive.\"", 100);
            WaitCustomSeconds(1);
            WriteSpeed("\nOf course, no one returning alive doesn't mean much when everyone is too frightened \nto explore the cave in the first place.", 50);
            PauseText();

            WriteSpeed("The sun is beginning to set, but you have finally arrived.\n", 50);
            WaitCustomSeconds(2);
            WriteSpeed("Your adventure begins", 100);
            WriteSpeed("....", 1000);
            ParagraphBreak();


            CaveText();
        }//opening


        static void CaveText()
        {
          
            bool alive = true;          //used for gameover checks
            bool nextCheckPoint = false;   //used for NEW checkpoints
           
            do
            {
                YesOrNoDecision("You stand at the mouth of the cave. Do you enter?", "You steel yourself and enter the cave.","You are scared, but you refuse to be like the others, too cowardly to even start this adventure.\nYou take a few more minutes to collect yourself.");
                WriteSpeed("As you enter the cave, the sun sets. You are surrounded by darkness.\n", 50);
                WaitCustomSeconds(2);
                WriteSpeed("You hear a voice: \n\"There's a room to your left. You'll find what you need in there.\"\n", 50);
                WriteSpeed("Listening to a strange voice in a dark cave may not be the smartest decision you've ever made,\nbut you forgot to bring a torch, so you feel your way into the room.\n", 50);
                WriteSpeed("As you turn the corner, you see a lit ", 50);
                AddKeyWord("torch");
                WriteSpeed(" mounted on the wall. \nThe light is not enough to cover the whole chamber. The torch is all you see.\n", 50);
                CommandKeywordDecisions("take torch", "What should you do with the torch?");
                AddInventory("torch");
                InstructionsFont("\nNow that you have a torch, you can use it to see dark parts of the cave.");
                CommandKeywordDecisions("use torch", "You should have a look around the chamber.");
                WriteSpeed("\nUsing the torch, you can see more of this part of the cave. \nThere's a sleeping bag--it looks like it's been used for years.\nSome old bottles, a spellbook written in a language you don't recognize, and a ", 50);
                AddKeyWord("mural");
                CommandKeywordDecisions("check mural", "\"Maybe I should have a closer look at that...\"");
                ParagraphBreak();

                WriteSpeed("You see a figure, holding a ", 50);
                AddKeyWord("sword");
                WriteSpeed(".\nThe swordsman is facing a hooded man, who is holding out a skeletal hand, \ngathering dark magic, surely for some deadly spell.\n", 50);
                WriteSpeed("It's a Lich!\n", 100);
                WriteSpeed("An undead sorceror. If liches are real...and if one is in this cave...\n", 50);
                WriteSpeed("It's no wonder those who came here before you didn't live to tell about it.", 100);
                ParagraphBreak();

                WriteSpeed("\"I see you've found my mural.\nIt's a warning to any adventurers who may enter this cave after my time is up...\nBut maybe, with your help, I can finally slay this lich.\"\nA man in a brown robe stands before you. It was his voice directing you to this room.", 50);
                WriteSpeed("\n\"There is a consecrated sword hidden deeper in this cavern.\nIt's strong against dark magic, but it is guarded by mythic beasts.\n", 50);
                WriteSpeed("\nI can guide your way. I can show you the magic sword and help you defeat the Lich's guardians.\nAnd, if it's what your heart truly desires, you can keep the treasures you find along the way.\"", 50);
                YesOrNoDecision("\"What do you say?\"", "\"Excellent!\"", "\"Take some time to reconsider...\"");
                ParagraphBreak();

                WriteSpeed("\nThe old wizard points you towards an ancient-looking door. \n\"Your first trial lies within.\"", 50);
                WriteSpeed("\nAs you open the door, you hear a hellish sound.", 50);
                WriteSpeed("\n\"QUAAAACCCKKKK\"\n", 1000);
                WriteSpeed("It sounds like a duck....but larger.\n", 50);
                WriteSpeed("Inside the room, you see a ", 50);
                AddKeyWord("LEVER");
                WriteSpeed(", a ", 50);
                AddKeyWord("TABLE");
                WriteSpeed(", and a ", 50);
                AddKeyWord("CAULDRON");
                CommandKeywordDecisions("use lever", "A lever, a table, and a cauldron. What should you do?");
                ParagraphBreak();

                Console.WriteLine("SUDDENLY, it drops from the cealing!\n");
                WriteSpeed("A. HORSE. SIZED. DUCK.\n", 100);
                WriteSpeed("...why do they even have that lever?\n", 50);
                CommandKeywordDecisions("use torch", "What should you do in the face of such danger...?");
                ParagraphBreak();

                WriteSpeed("...Fire works. That was actually kind of easy.\n", 50);
                Console.WriteLine("[Duck-Sized Horse: Slain!]");
                WriteSpeed("\nAfter the creature dies, two objects drop from its cealing perch.", 50);
                AddInventory("MAGIC_SWORD");
                AddTreasure("Golden Scepter");
                WriteSpeed("\nYou wonder why it had those....oh well.", 50);
                nextCheckPoint = true;

            }while (alive && !nextCheckPoint); //checkpoint 1

            Ending();
        }//ch1

        static void Ending()
        {
            /*Outline:
             * 
             * 
             * 
             * */
            WriteSpeed("TO BE CONTINUED....", 2000);
        }//ending
        //methods for gameplay

        static string GetUserInput(string text) 
        {
            WriteSpeed(text, 50);
            Console.WriteLine();
            return Console.ReadLine().ToLower();
             
        }//getUserInput

        static void YesOrNoDecision(string prompt, string responseYes, string responseNo)
        {
            bool solved = false;
            string userInput = "";
            do
            {
                userInput = GetUserInput(prompt);

                if (userInput == "yes" || userInput == "y")
                {
                    Console.WriteLine(responseYes);
                    solved = true;
                }//if

                else if (userInput == "no" || userInput == "not yet" || userInput == "n")
                {
                    Console.WriteLine(responseNo);
                }//elseif

                else if (userInput =="commands" || userInput == "treasures" || userInput == "inventory" || userInput == "keywords")
                {
                    Console.WriteLine("Please wait for a command decision to check these.");
                }//elseif

                else
                {
                    InstructionsFont($"{userInput} is not a valid response.");
                }//else

                ParagraphBreak();

            } while (!solved);//do while
        }//YesOrNoDecision

        static void CommandKeywordDecisions(string correctSolution, string prompt)
        {
            string userInput = "";
            bool nextAction = false;
            bool validCommand = false;
            bool validKeyword = false;
            string command = "";
            string keyword = "";
            string[] input;
            do
            {
                ParagraphBreak();
                userInput = GetUserInput(prompt);
                nextAction = (userInput == correctSolution.ToLower());
                input = userInput.Split(' ');
                command = input[0];

                if (input.Length > 1) //to catch one-word commands
                {
                    keyword = input[1];
                }//if

                //catch erroneous input
                foreach (string word in commands)
                {
                    if (word == command || command == "commands" || command == "inventory" || command == "keywords" || command == "treasures")
                    {
                        validCommand = true;
                        break;
                    }//if
                }//foreach

                foreach (string word in keyWords)
                {
                    if (word == keyword || keyword == "")
                    {
                        validKeyword = true;
                        break;
                    }//if

                }//foreach

                if (nextAction)
                {
                    WriteSpeed($"You {command} the {keyword}.", 50);
                }//true path

                else if (!validCommand)
                {
                    WriteSpeed("Invalid command.", 50);
                }//elseif

                else if (!validKeyword)
                {
                    WriteSpeed("Invalid keyword.", 50);
                }//elseif

                else if (!validCommand && !validKeyword)
                {
                    WriteSpeed("Invalid command.\nInvalid Keyword.\n", 50);
                }//elseif

                //"funny" responses
                else if (command == "punch")
                {
                    WriteSpeed($"You punch the {keyword}. Your hand hurts. Nothing else happened.\n", 50);
                }//elseif

                else if (command == "use")
                {
                    WriteSpeed($"You try to use {keyword}, but nothing happened.\n", 50);
                }//elseif

                else if (command == "check")
                {
                    WriteSpeed($"You check {keyword}. You've learned nothing.\n", 50);
                }//elseif

                //information responses
                else if (command == "commands")
                {
                    CheckCommands();
                }//elseif

                else if (command == "keywords")
                {
                    CheckKeyWords();
                }//elseif

                else if (command == "treasures")
                {
                    CheckTreasure();
                }//elseif

                else if (command == "inventory")
                {
                    CheckInventory();
                }//elseif

                //in case I missed something
                else
                {
                    InstructionsFont("Invalid input");
                }//else
            } while (!nextAction);

        }//userDecision

        //methods to add to lists

        static void AddInventory(string item) 
        {
            WriteSpeed($"\n[GOT {item}!]\n", 50);
            inventory.Add(item);
        }//addInventory

        static void AddTreasure(string treasure) 
        {
            
            WriteSpeed($"\n[GOT {treasure}!]\n", 50);
            treasures.Add(treasure);
        }//addTreasure

        //methods to write lists

        static void CheckInventory() 
        {
            foreach (string item in inventory)
            {
                WriteSpeed(item, 50);
                Console.WriteLine();

            }//foreach
        }//checkInventory

        static void CheckTreasure()
        {

            foreach (string treasure in treasures)
            {
           
                WriteSpeed(treasure, 50);
                Console.WriteLine();
            }//foreach
        }//checkTreasures

        static void CheckKeyWords()
        {

            foreach (string keyword in keyWords)
            {
                WriteSpeed(keyword, 50);
                Console.WriteLine();
            }//foreach
        }//checkKeyWords

        static void CheckCommands()  //Prints a full list of commands
        {
            foreach (string command in commands)
            {
                WriteSpeed(command, 50);
                Console.WriteLine();
            }//foreach
        }//commands

        //methods for fonts

        static void AddKeyWord(string word) //changes font color of a keyword and writes it at 100 MS. Add keyword to list
        {                                   
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            WriteSpeed(word.ToUpper(), 100);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            keyWords.Add(word);
        }//keyWordFont

        static void InstructionsFont(string text) //changes font color for instruction text.
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }//instructionsFont

        //methods for pacing the text:

        static void ParagraphBreak()
        {
            Console.WriteLine( "\n"); //two lines to make it clear that the game is waiting for input
            Console.ReadLine();
            Console.Clear();
        }//paragraphBreak

        static void PauseText()
        {
            //similar to paragraphBreak(), but without clearing
            Console.WriteLine("\n"); 
            Console.ReadLine();
        }//pauseText

        static void WaitCustomSeconds(int seconds)  
        {
            for (int i =0; i < seconds ;i++)
            {
              System.Threading.Thread.Sleep(1000);
            }//for
        }//waitCustomSeconds

        static void WriteSpeed(string text, int time) 
        {                                                  
            foreach (char c in text)                      
            {
                Console.Write(c);
                System.Threading.Thread.Sleep(time);
            }//foreach
        }//writeSpeedCustom
    }//class
}//namespace