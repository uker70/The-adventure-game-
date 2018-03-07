using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_adventure_game_
{
    class Program
    {
        static void Main(string[] args)
        {
            //farver
            //cyan er endgame
            //red er playeraction
            //white er travel direction
            //darkred er playerdeath
            //white er "action" tekst
            //green er food tekst
            //yellow er money

            //death = food = -20;





            Console.ForegroundColor = ConsoleColor.White;

            //variables
            int food = 10;
            int knight = 1;
            int game = 1;
            int money = 5;
            int griffin = 1;
            int robber = 1;

            //random
            Random encounterrand = new Random();
            Random travelrand = new Random();
            Random rugsackrand = new Random();
            Random moneyrand = new Random();
            Random random = new Random();

            //start
            Console.WriteLine("You pack your stuff, you bring food for 10 days, once you run out of food, the game is over");
            Console.WriteLine("The game can also end if you are unlucky and get killed on your journey");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press <Enter> to continue");
            Console.ForegroundColor = ConsoleColor.White;
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
            Console.WriteLine();

            //spil
            do
            {
                //random variable og food counter
                int encounter = encounterrand.Next(1, 11);
                int traveldirection = travelrand.Next(1, 4);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("You have " + food + " food left");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;

                //travel diretion
                Console.ForegroundColor = ConsoleColor.White;
                switch (traveldirection)
                {
                    case 1:
                        Console.WriteLine("You follow the path and walk for hours without anything happening");
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("You take a turn and head into the forest, you walk for hours");
                        Console.WriteLine();
                        break;

                    case 3:
                        int farmmoney = moneyrand.Next(3, 7);
                        int goldonfarm = random.Next(1, 6);

                        Console.WriteLine("You walk over fields, through swamps and past farms");
                        Console.ForegroundColor = ConsoleColor.White;

                        switch (goldonfarm)
                        {
                            case 1:
                                Console.WriteLine("You see something shiny in the field, you walk over and pick it up");
                                Console.WriteLine("You realize that you found a bag with some gold coins in it");
                                money = money + farmmoney;
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("You found " + farmmoney + " gold coins, you now have " + money + " gold coins");
                                Console.ForegroundColor = ConsoleColor.White;
                                int farmer = random.Next(1, 4);

                                switch (farmer)
                                {
                                    case 1:
                                        Console.WriteLine();
                                        Console.WriteLine("You meet a farmer, that asks if you have seen bag with coins in it");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Press <Enter> to say yes and press <Aything else> to say no");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }

                                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                                        {
                                            Console.WriteLine();
                                            Console.WriteLine("Thanks for finding my money, here, take this food for your journey");
                                            Console.ForegroundColor = ConsoleColor.Green;
                                            money = money - farmmoney;
                                            food = food + farmmoney;
                                            Console.WriteLine("The farmer gets his money and gives you " + farmmoney + " food, for your journey");
                                            Console.WriteLine();
                                        }
                                        break;

                                }
                                break;

                            default:
                                break;
                        }
                        Console.WriteLine();
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Press <Enter> to continue");
                Console.ForegroundColor = ConsoleColor.White;
                while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }

                //events
                switch (encounter)
                {
                    case 1:
                        //rugsack
                        Console.WriteLine("You see a rugsack laying on the ground, what do you do?");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Press <Enter> to interact with it and press <Anything else> for ignoring");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;

                        int rugsackfood = rugsackrand.Next(1, 6);

                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine("You walk over to the rugsack and open it");
                            Console.WriteLine();

                            switch (rugsackfood)
                            {
                                case 1:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You find 2 food");
                                    food++; food++;
                                    Console.WriteLine("You know have " + food + " food");
                                    Console.WriteLine();
                                    break;

                                case 2:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You find 3 food");
                                    food++; food++; food++;
                                    Console.WriteLine("You know have " + food + " food");
                                    Console.WriteLine();
                                    break;

                                case 3:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("You find 4 food");
                                    food++; food++; food++; food++;
                                    Console.WriteLine("You know have " + food + " food");
                                    Console.WriteLine();
                                    break;

                                case 4:
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("You find some food that you eat, the food makes you even more hungry");
                                    Console.WriteLine("You become so hungry that you need to eat more and eats 2 food");
                                    food--; food--;
                                    Console.WriteLine("You know have " + food + " food");
                                    Console.WriteLine();
                                    break;

                                case 5:
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.WriteLine("You find some food that you eat, the food makes you even more hungry");
                                    Console.WriteLine("You become so hungry that you need to eat more and eats 3 food");
                                    food--; food--; food--;
                                    Console.WriteLine("You know have " + food + " food");
                                    Console.WriteLine();
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("You choose to ignore the rugsack and continue on your journey");
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        //knight
                        Console.WriteLine("You meet a knight that calls you a peasent, what do you do?");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Press <Enter> to respond and press <Anything else> for ignoring");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine("You tell him to say sorry, but he refuses, pulls out his sword and cuts you in two pieces");
                            Console.WriteLine("You are killed");
                            Console.WriteLine();
                            food = -20;
                            knight++;
                        }
                        else
                        {
                            Console.WriteLine("You ignore the knight and countinue on your journey");
                            Console.WriteLine();
                        }
                        break;

                    case 3:
                        //the blue rock
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("After you walk for what felt like a year, you stumpel over a small blue rock");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("If you want to pick up the blue rock, press <Enter> if not press <Anything else>");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        int bluestone = 0;
                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            bluestone = 1;
                            Console.WriteLine("You pick it up, as it might come in handy");
                            Console.WriteLine();
                            if (bluestone == 1)
                            {
                                Console.WriteLine("After you pick up the rock, you realize the rock is really heavy and might slow you down");
                                Console.WriteLine("You can keep the rock, but your journey will probably be slower");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("If you want to drop the blue rock press <Enter> if not press <Anything else>");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine();
                            }
                            if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                            {
                                Console.WriteLine("After dropping the rock, you feel light and agile again, it feels like you can walk for miles now");
                                Console.WriteLine();
                                bluestone = 0;
                            }
                            else
                            {
                                Console.WriteLine("You trust you instincts that the blue rock is important, even though it will slow you down");
                                Console.WriteLine("The rock makes you slow and makes you eat");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("-1 food");
                                food--;
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }

                        else
                        {
                            Console.WriteLine("You dont pick it up, who needs it anyways");
                            Console.WriteLine();
                        }

                        int efterbluestone = random.Next(1, 7);
                        if (efterbluestone == 1)
                        {
                            Console.Write("A griffin comes sweeping down towards you");
                            if (bluestone == 1)
                            {
                                Console.WriteLine("You act fast and pull out the blue rock, you hold the blue rock up towards the griffin");
                                Console.WriteLine("To your suprise, the griffin takes the rock and flies away, the blue rock saved you");
                                Console.WriteLine();
                                bluestone--;

                            }
                            else
                            {
                                Console.WriteLine("You are running as fast as you can, but the griffin still catches you and sinks its giant claws into your body");
                                Console.WriteLine();
                                food = -20;
                                griffin = 2;

                            }
                        }
                        break;

                    case 4:
                        Console.WriteLine("");
                        Console.WriteLine();
                        break;

                    case 5:
                        //bush

                        int bush = random.Next(1, 11);
                        int moneysteal = moneyrand.Next(3, 7);

                        Console.WriteLine("You hear some noises coming from a bush");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Press <Enter> to investigate, press <Anything else> for ignoring");
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                        {
                            Console.WriteLine("You go towards the bush, to investigate what made the sound");
                            Console.WriteLine();

                            switch (bush)
                            {
                                case 1:
                                    Console.WriteLine("You apporach the bush and a robber jumps out and knocks you unconcious");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("While you are unconcious, he steals " + moneysteal + " money from your purse");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    money = money - moneysteal;
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("You rethink your decesion and go back and continue your journey");
                        }
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.WriteLine("");
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.WriteLine("");
                        Console.WriteLine();
                        break;

                    case 8:
                        Console.WriteLine("");
                        Console.WriteLine();
                        break;

                    case 9:
                        Console.WriteLine("");
                        Console.WriteLine();
                        break;

                    case 10:
                        Console.WriteLine("");
                        Console.WriteLine();
                        break;


                }

                if (money >= 25)
                {
                    Console.WriteLine("You have gathered a small fortune");
                    food = -20;
                }

                food--;

                if (0 >= food)
                {
                    game--;
                }
            } while (game > 0);

            if (food > -20)
            {
                food = 0;
            }
            else
            {
                food = 5;
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Your journey ended, press <Enter> to see how it went");
            Console.ForegroundColor = ConsoleColor.White;
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }

            Console.WriteLine();

            if (money >= 25)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You are now a wealthy man, and the next generations of your familly will be rich enough to live on your money");
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            if (knight == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Your journey ended, you met a knight that you insulted, so he killed you");
            }

            if (0 == food)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Your journey ended, you ran out of food and had to resolve to begging for food");
                Console.WriteLine("Forcing you to stay in the nearest city for the rest of your days");
            }

            if (griffin == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You died by a giant griffin, becoming its victim and dinnir, better luck next time");
            }

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Press <Enter> to end the game");
            Console.ForegroundColor = ConsoleColor.White;
            while (Console.ReadKey(true).Key != ConsoleKey.Enter) { }
        }
    }
}
