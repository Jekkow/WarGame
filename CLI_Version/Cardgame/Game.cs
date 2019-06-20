using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cardgame
{
    class Game
    {
        public List<Deck> DeckList = new List<Deck>();
        public Deck Deck = new Deck();
        public Deck ShuffeldDeck = new Deck();
        public Random RandCard = new Random();

        public Game()
        {
            
        }

        public void GameRun()
        {
            Console.Clear();
            //Welcome screen, Set Player_Name
            Console.WriteLine("Welcome in this cardgame!\n\n" +
                "This game is made by:\n" +
                "Jacco Dammer\n1850385 Zuyd\n\n");
            Console.WriteLine("------------Rules------------\n" +
                "[1] Game style is WarGame\n" +
                "[2] Aces have the highest value\n" +
                "[3] Have fun!");

            Console.WriteLine("What is your name?");
            string _Name = Console.ReadLine();
            Player Player1 = new Player(1, _Name, 0);
            Player Player2 = new Player(2, "AI_Bob", 0);
            Console.Clear();

            Console.WriteLine("Welcome " + Player1.Get_PlayerName() + " !\n\n" +
                "You are playing against: " + Player2.Get_PlayerName());
            Console.WriteLine("Press [ENTER] to shuffle the cards...");
            Console.ReadKey();

            //Clubs
            Deck.DeckOfCards.Add(new Card(14, "Clubs-A"));
            Deck.DeckOfCards.Add(new Card(2, "Clubs-2"));
            Deck.DeckOfCards.Add(new Card(3, "Clubs-3"));
            Deck.DeckOfCards.Add(new Card(4, "Clubs-4"));
            Deck.DeckOfCards.Add(new Card(5, "Clubs-5"));
            Deck.DeckOfCards.Add(new Card(6, "Clubs-6"));
            Deck.DeckOfCards.Add(new Card(7, "Clubs-7"));
            Deck.DeckOfCards.Add(new Card(8, "Clubs-8"));
            Deck.DeckOfCards.Add(new Card(9, "Clubs-9"));
            Deck.DeckOfCards.Add(new Card(10, "Clubs-10"));
            Deck.DeckOfCards.Add(new Card(11, "Clubs-J"));
            Deck.DeckOfCards.Add(new Card(12, "Clubs-Q"));
            Deck.DeckOfCards.Add(new Card(13, "Clubs-K"));

            //Hearts
            Deck.DeckOfCards.Add(new Card(14, "Hearts-A"));
            Deck.DeckOfCards.Add(new Card(2, "Hearts-2"));
            Deck.DeckOfCards.Add(new Card(3, "Hearts-3"));
            Deck.DeckOfCards.Add(new Card(4, "Hearts-4"));
            Deck.DeckOfCards.Add(new Card(5, "Hearts-5"));
            Deck.DeckOfCards.Add(new Card(6, "Hearts-6"));
            Deck.DeckOfCards.Add(new Card(7, "Hearts-7"));
            Deck.DeckOfCards.Add(new Card(8, "Hearts-8"));
            Deck.DeckOfCards.Add(new Card(9, "Hearts-9"));
            Deck.DeckOfCards.Add(new Card(10, "Hearts-10"));
            Deck.DeckOfCards.Add(new Card(11, "Hearts-J"));
            Deck.DeckOfCards.Add(new Card(12, "Hearts-Q"));
            Deck.DeckOfCards.Add(new Card(13, "Hearts-K"));

            //Spades
            Deck.DeckOfCards.Add(new Card(14, "Spades-A"));
            Deck.DeckOfCards.Add(new Card(2, "Spades-2"));
            Deck.DeckOfCards.Add(new Card(3, "Spades-3"));
            Deck.DeckOfCards.Add(new Card(4, "Spades-4"));
            Deck.DeckOfCards.Add(new Card(5, "Spades-5"));
            Deck.DeckOfCards.Add(new Card(6, "Spades-6"));
            Deck.DeckOfCards.Add(new Card(7, "Spades-7"));
            Deck.DeckOfCards.Add(new Card(8, "Spades-8"));
            Deck.DeckOfCards.Add(new Card(9, "Spades-9"));
            Deck.DeckOfCards.Add(new Card(10, "Spades-10"));
            Deck.DeckOfCards.Add(new Card(11, "Spades-J"));
            Deck.DeckOfCards.Add(new Card(12, "Spades-Q"));
            Deck.DeckOfCards.Add(new Card(13, "Spades-K"));

            //Diamonds
            Deck.DeckOfCards.Add(new Card(14, "Diamonds-A"));
            Deck.DeckOfCards.Add(new Card(2, "Diamonds-2"));
            Deck.DeckOfCards.Add(new Card(3, "Diamonds-3"));
            Deck.DeckOfCards.Add(new Card(4, "Diamonds-4"));
            Deck.DeckOfCards.Add(new Card(5, "Diamonds-5"));
            Deck.DeckOfCards.Add(new Card(6, "Diamonds-6"));
            Deck.DeckOfCards.Add(new Card(7, "Diamonds-7"));
            Deck.DeckOfCards.Add(new Card(8, "Diamonds-8"));
            Deck.DeckOfCards.Add(new Card(9, "Diamonds-9"));
            Deck.DeckOfCards.Add(new Card(10, "Diamonds-10"));
            Deck.DeckOfCards.Add(new Card(11, "Diamonds-J"));
            Deck.DeckOfCards.Add(new Card(12, "Diamonds-Q"));
            Deck.DeckOfCards.Add(new Card(13, "Diamonds-K"));

            while (Deck.DeckOfCards.Count() > 0)
            {
                int RandomCard = RandCard.Next(Deck.DeckOfCards.Count());
                Card TKaart = Deck.DeckOfCards[RandomCard];
                ShuffeldDeck.DeckOfCards.Add(TKaart);
                Deck.DeckOfCards.Remove(TKaart);
            }


            Console.Clear();
            Console.WriteLine("Cards are now being shuffeled, please wait...");

            //Loading animation
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);

            for (int i = 0; i <= 52; i++)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.Write("█");
                }
                Console.WriteLine(i + "/52");
                Console.SetCursorPosition(1, 1);
                System.Threading.Thread.Sleep(50);
            }
            Console.CursorVisible = true;

            Console.WriteLine("\n\nCards are succesfully shuffeled!\n" +
                "Press [ENTER] to start the game...");
            Console.ReadKey();

            //Deal the cards into the hands
            int DealCounter = 0;
            while (DealCounter < 52)
            {
                if (DealCounter % 2 == 0)
                    Player1.PlayerHand.Add(ShuffeldDeck.DeckOfCards[DealCounter]);
                else
                    Player2.PlayerHand.Add(ShuffeldDeck.DeckOfCards[DealCounter]);
                DealCounter++;
            }


            int PlayCounter = 0;
            while (PlayCounter <= 25)
            {
                //ScoreBoard
                Console.Clear();
                Console.WriteLine("-----------ScoreBoard-----------");
                Console.WriteLine("Player: {0}\t\tPoints: {1}", Player1.Get_PlayerName(), Player1.Get_PlayerScore());
                Console.WriteLine("Player: {0}\t\tPoints: {1}", Player2.Get_PlayerName(), Player2.Get_PlayerScore());
                Console.WriteLine("--------------------------------");

                //Roundcounter
                Console.WriteLine("Round: " + (PlayCounter + 1) + "\n");

                //Card getters
                Card TempPlayerCard = Player1.PlayerHand[PlayCounter];
                Console.WriteLine("Your card is:\t\t" + TempPlayerCard.Get_CardName());
                Card TempComputerCard = Player2.PlayerHand[PlayCounter];
                Console.WriteLine("AI_Bob's card is:\t" + TempComputerCard.Get_CardName() + "\n");

                //Card value counter
                if (TempPlayerCard.Get_CardValue() > TempComputerCard.Get_CardValue())
                {
                    Console.WriteLine("You won this round!");
                    Player1.Set_PlayerScore(1);
                }
                else if (TempPlayerCard.Get_CardValue() == TempComputerCard.Get_CardValue())
                {
                    Console.WriteLine("It's a Draw!");
                    Player1.Set_PlayerScore(1);
                    Player2.Set_PlayerScore(1);
                }
                else
                {
                    Console.WriteLine("AI_Bob wins this round...");
                    Player2.Set_PlayerScore(1);
                }
                PlayCounter++;
                Console.WriteLine("\nPress [ENTER] for next round...");
                Console.ReadKey();
            }
            //Final scoreboard
            Console.Clear();
            Console.WriteLine("-----------ScoreBoard-----------");
            Console.WriteLine("Player: " + Player1.Get_PlayerName() + "\t\t| Points: " + Player1.Get_PlayerScore());
            Console.WriteLine("Player: " + Player2.Get_PlayerName() + "\t\t| Points: " + Player2.Get_PlayerScore());
            Console.WriteLine("--------------------------------");

            if (Player1.Get_PlayerScore() > Player2.Get_PlayerScore())
            {
                Console.WriteLine("You won the game! Congrats!");
            }
            else if (Player1.Get_PlayerScore() == Player2.Get_PlayerScore())
            {
                Console.WriteLine("You did not lose, but you also did not win...");
            }
            else
            {
                Console.WriteLine("To bad, AI_Bob won the game...");
            }
        }
    }
}
