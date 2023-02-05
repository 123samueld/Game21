using System;

namespace Game21
{
    class Game
    {
        static void Main()
        {
            Console.WriteLine("Welcome to 21!");
            Random random= new Random();
            int[] deck = new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int randInt;
            int dealersCard;
            bool gameRunning =true;
            bool handRunning =true;
            string hitOrHold;
            int playersHand;
            float handsPlayed;
            float handsWon;
            float winRatio;
            string anotherGame;

            handsPlayed =0;
            handsWon = 0;

            while (gameRunning)
            {
                hitOrHold = "";
                playersHand = 0;
                winRatio = 0;
                handRunning = true;
               
                while (handRunning)
                {
                    Console.WriteLine("Hit or hold? ");
                    hitOrHold = Console.ReadLine().ToLower();
                    if(hitOrHold == "hold"){ handRunning = false; }
                    randInt = random.Next(0, 12);
                    dealersCard = deck[randInt];
                    if (hitOrHold == "hit") { playersHand += dealersCard; }
                    if (playersHand == 21) 
                    { 
                        Console.WriteLine("BlackJack! You win.");
                        handsWon++;
                        handRunning = false; 
                    }
                    else if(playersHand >= 22) 
                    { 
                        Console.WriteLine("Bust! You loose.");
                        handRunning = false; 
                    }
                    Console.WriteLine("The house deals: " + dealersCard);
                    Console.WriteLine("Players hand: " + playersHand);
                }
                handsPlayed++;
                Console.WriteLine("Please press \"Q\" to quit or anything else to play again: ");
                anotherGame = Console.ReadLine().ToLower();
                if(anotherGame == "q")
                {
                    gameRunning = false;
                }
            }

            winRatio = handsWon / (handsPlayed / 100) ;
            Console.WriteLine("You played "+handsPlayed+
                " hands and won "+ handsWon +
                " of them. Your win rate was "+winRatio+"%.");
            Console.WriteLine("Game Over. Thank you for playing 21.");

        }
    }
}