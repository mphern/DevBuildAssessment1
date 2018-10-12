using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseOwnAdventure
{
    class Program
    {
        static void Main()
        {
            string goAgain = "Y";
            while (goAgain == "Y" || goAgain == "YES")
            {
                Scenario1();
                goAgain = GoAgain();
            }
        }
        static void Scenario1()
        {
            Console.WriteLine(
            "Your walking through the woods near your house one day when come across a cave.  \"Hmmmm I've never seen this cave before\" you say, " +
            "I should probably check this out.  You walk into the cave and there is a path to the right and a path to the left.");
            Console.WriteLine("\n");
            Console.Write("What path do you want to take? Type \"R\" to take the path on the right or \"L\" to take the path on the left: ");
            string choice = ValidateChoice("R", "L"); 

            switch (choice)
            {
                case "R":
                    Scenario2();
                    break;
                case "L":
                    Scenario3();
                    break;
            }
        }

        static void Scenario2()
        {
            Console.WriteLine("You take the path to the right.  It's getting darker but you can still see a little.  You see an arrow painted " +
                "on the cave wall pointing to a spot on the wall.  Next to the arrow it says \"Push here\".  Do you push the wall?");
            Console.WriteLine("\n");
            Console.Write("To push the wall type \"Y\" or type \"N\" to ignore it and walk past it: ");
            string choice = ValidateChoice("Y", "N");

            switch(choice)
            {
                case "Y":
                    Scenario4();
                    break;
                case "N":
                    Scenario5();
                    break;
            }
        }

        static void Scenario3()
        {
            Console.WriteLine("You decide to take the path on the left. The cave is getting darker and darker but you keep pushing forward. " +
                "Eventually it gets to the point where you can't see anything and you begin walking with your hands out in front of you to " +
                "make sure you don't walk into a wall.  Suddenly your hands feel something but it isnt a wall.  It kinda feels like, uh oh, FUR!!! " +
                "You then hear the growl of an angry beast.  You turn around and start running but you hear the beast getting closer.  The path starts " +
                "getting brighter and brighter.  \"I'm going to make it!\" you say to yourself. Right before you reach the cave entrance you feel a " +
                "furry paw grab your leg and you get dragged back into the darkness.  You are never heard from again. THE END");
        }

        static void Scenario4()
        {
            Console.WriteLine("You decide to push the spot on the wall.  You hear a noise.  It sounded like a trap door opening but you didn't see " +
                "anything happen.  You then hear a whistling sound.  \"What's that noise\" you think to yourself.  UH OH! You look up just in time" +
                " to see a giant boulder come crashing down on you. THE END");
        }
        static void Scenario5()
        {
            Console.WriteLine("You decide to ignore the arrow.  \"I ain't that dumb\" you say.  You continue down the path.  It's" +
                " getting dark so you pull out the lighter in your pocket to light the way.  You eventually get to a hole in the path " +
                "with a ladder going down it.  Do you go down the ladder or jump over the hole and continue down the path?");
            Console.WriteLine("\n");
            Console.Write("To go down the ladder type \"L\". To jump over the hole type \"J\": ");
            string choice = ValidateChoice("L", "J");
            switch (choice)
            {
                case "L":
                    Scenario6();
                    break;
                case "J":
                    Scenario7();
                    break;
            }
        }
        static void Scenario6()
        {
            Console.WriteLine("You decide to go down the ladder.  It takes you to what you think at first is an empty room.  You continue to " +
                "look around and you see a flicker of light from something in the corner of the room.  You walk towards it to discover a treasure " +
                "chest filled with gold, silver, and jewelry!!! Enough treasure that you no longer need to work another day in your life. THE END");
        }
        static void Scenario7()
        {
            Console.WriteLine("You decide to jump over the hole and continue forward.  You get to room that at first looks empty but soon " +
                "notice a pedestal in the middle of room with what looks like a small solid gold statue on top.  \"JACKPOT!\" you exclaim. " +
                "You mosey over to the pedistal and grab the statue.  Just then, the room starts shaking and you notice the entrance into " +
                "the room into closing!  You try to escape the room but you're too late.  The entrance closes, trapping you in the room for " +
                "all eternity! THE END");
        }

        static string ValidateChoice(string choice1, string choice2)
        {
            string choice = Console.ReadLine().ToUpper();
            while (choice != choice1 && choice != choice2)
            {
                Console.Write("I don't understand that. Please choose " + choice1 + " or " + choice2 + ": ");
                choice = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("\n");
            return choice;
        }
        static string GoAgain()
        {
            Console.WriteLine("\n");
            Console.Write("Would you like to go on another adventure? Y/N: ");
            string answer = Console.ReadLine().ToUpper();
            while(answer != "Y" && answer != "YES" && answer != "N" && answer != "NO")
            {
                Console.Write("I don't understand that. Would you like to go on another adventure? Y/N: ");
                answer = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("\n");
            return answer;
        }

    }
}
