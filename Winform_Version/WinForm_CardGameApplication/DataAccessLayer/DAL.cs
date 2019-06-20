using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm_CardGameApplication
{
    class DAL
    {
        public List<Deck> DeckList = new List<Deck>();
        public Deck Deck = new Deck();
        public Deck ShuffeldDeck = new Deck();
        public Random RandCard = new Random();
        public List<Player> PlayerList = new List<Player>();

        public DAL()
        {

        }

        public void CreateGame(string _name)
        {
            //Create Players
            Player HumanPlayer = new Player(1, _name, 0);
            Player AIPlayer = new Player(2, "AI_Bob", 0);
            PlayerList.Add(HumanPlayer);
            PlayerList.Add(AIPlayer);

            //Clubs
            Deck.DeckOfCards.Add(new Card(14, "Clubs-A", "Cards//AC.png"));
            Deck.DeckOfCards.Add(new Card(2, "Clubs-2", "Cards//2C.png"));
            Deck.DeckOfCards.Add(new Card(3, "Clubs-3", "Cards//3C.png"));
            Deck.DeckOfCards.Add(new Card(4, "Clubs-4", "Cards//4C.png"));
            Deck.DeckOfCards.Add(new Card(5, "Clubs-5", "Cards//5C.png"));
            Deck.DeckOfCards.Add(new Card(6, "Clubs-6", "Cards//6C.png"));
            Deck.DeckOfCards.Add(new Card(7, "Clubs-7", "Cards//7C.png"));
            Deck.DeckOfCards.Add(new Card(8, "Clubs-8", "Cards//8C.png"));
            Deck.DeckOfCards.Add(new Card(9, "Clubs-9", "Cards//9C.png"));
            Deck.DeckOfCards.Add(new Card(10, "Clubs-10", "Cards//10C.png"));
            Deck.DeckOfCards.Add(new Card(11, "Clubs-J", "Cards//JC.png"));
            Deck.DeckOfCards.Add(new Card(12, "Clubs-Q", "Cards//QC.png"));
            Deck.DeckOfCards.Add(new Card(13, "Clubs-K", "Cards//KC.png"));

            //Hearts
            Deck.DeckOfCards.Add(new Card(14, "Hearts-A", "Cards//AH.png"));
            Deck.DeckOfCards.Add(new Card(2, "Hearts-2", "Cards//2H.png"));
            Deck.DeckOfCards.Add(new Card(3, "Hearts-3", "Cards//3H.png"));
            Deck.DeckOfCards.Add(new Card(4, "Hearts-4", "Cards//4H.png"));
            Deck.DeckOfCards.Add(new Card(5, "Hearts-5", "Cards//5H.png"));
            Deck.DeckOfCards.Add(new Card(6, "Hearts-6", "Cards//6H.png"));
            Deck.DeckOfCards.Add(new Card(7, "Hearts-7", "Cards//7H.png"));
            Deck.DeckOfCards.Add(new Card(8, "Hearts-8", "Cards//8H.png"));
            Deck.DeckOfCards.Add(new Card(9, "Hearts-9", "Cards//9H.png"));
            Deck.DeckOfCards.Add(new Card(10, "Hearts-10", "Cards//10H.png"));
            Deck.DeckOfCards.Add(new Card(11, "Hearts-J", "Cards//JH.png"));
            Deck.DeckOfCards.Add(new Card(12, "Hearts-Q", "Cards//QH.png"));
            Deck.DeckOfCards.Add(new Card(13, "Hearts-K", "Cards//KH.png"));

            //Spades
            Deck.DeckOfCards.Add(new Card(14, "Spades-A", "Cards//AS.png"));
            Deck.DeckOfCards.Add(new Card(2, "Spades-2", "Cards//2S.png"));
            Deck.DeckOfCards.Add(new Card(3, "Spades-3", "Cards//3S.png"));
            Deck.DeckOfCards.Add(new Card(4, "Spades-4", "Cards//4S.png"));
            Deck.DeckOfCards.Add(new Card(5, "Spades-5", "Cards//5S.png"));
            Deck.DeckOfCards.Add(new Card(6, "Spades-6", "Cards//6S.png"));
            Deck.DeckOfCards.Add(new Card(7, "Spades-7", "Cards//7S.png"));
            Deck.DeckOfCards.Add(new Card(8, "Spades-8", "Cards//8S.png"));
            Deck.DeckOfCards.Add(new Card(9, "Spades-9", "Cards//9S.png"));
            Deck.DeckOfCards.Add(new Card(10, "Spades-10", "Cards//10S.png"));
            Deck.DeckOfCards.Add(new Card(11, "Spades-J", "Cards//JS.png"));
            Deck.DeckOfCards.Add(new Card(12, "Spades-Q", "Cards//QS.png"));
            Deck.DeckOfCards.Add(new Card(13, "Spades-K", "Cards//KS.png"));

            //Diamonds
            Deck.DeckOfCards.Add(new Card(14, "Diamonds-A", "Cards//AD.png"));
            Deck.DeckOfCards.Add(new Card(2, "Diamonds-2", "Cards//2D.png"));
            Deck.DeckOfCards.Add(new Card(3, "Diamonds-3", "Cards//3D.png"));
            Deck.DeckOfCards.Add(new Card(4, "Diamonds-4", "Cards//4D.png"));
            Deck.DeckOfCards.Add(new Card(5, "Diamonds-5", "Cards//5D.png"));
            Deck.DeckOfCards.Add(new Card(6, "Diamonds-6", "Cards//6D.png"));
            Deck.DeckOfCards.Add(new Card(7, "Diamonds-7", "Cards//7D.png"));
            Deck.DeckOfCards.Add(new Card(8, "Diamonds-8", "Cards//8D.png"));
            Deck.DeckOfCards.Add(new Card(9, "Diamonds-9", "Cards//9D.png"));
            Deck.DeckOfCards.Add(new Card(10, "Diamonds-10", "Cards//10D.png"));
            Deck.DeckOfCards.Add(new Card(11, "Diamonds-J", "Cards//JD.png"));
            Deck.DeckOfCards.Add(new Card(12, "Diamonds-Q", "Cards//QD.png"));
            Deck.DeckOfCards.Add(new Card(13, "Diamonds-K", "Cards//KD.png"));

            //Shuffle Deck
            while (Deck.DeckOfCards.Count() > 0)
            {
                int RandomCard = RandCard.Next(Deck.DeckOfCards.Count());
                Card TKaart = Deck.DeckOfCards[RandomCard];
                ShuffeldDeck.DeckOfCards.Add(TKaart);
                Deck.DeckOfCards.Remove(TKaart);
            }

            //Deal the cards into the hands
            int DealCounter = 0;
            while (DealCounter < 52)
            {
                if (DealCounter % 2 == 0)
                    HumanPlayer.PlayerHand.Add(ShuffeldDeck.DeckOfCards[DealCounter]);
                else
                    AIPlayer.PlayerHand.Add(ShuffeldDeck.DeckOfCards[DealCounter]);
                DealCounter++;
            }
        }
        public void PlayGame()
        {
            if (PlayerList[0].PlayerHand.Count != 0)
            {
                //Card getters
                Card TempPlayerCard = PlayerList[0].PlayerHand[0];
                Card TempComputerCard = PlayerList[1].PlayerHand[0];

                //PictureBoxFiller



                //Card value counter
                if (TempPlayerCard.Get_CardValue() > TempComputerCard.Get_CardValue())
                {

                    PlayerList[0].Set_PlayerScore(1);
                }
                else if (TempPlayerCard.Get_CardValue() == TempComputerCard.Get_CardValue())
                {

                    PlayerList[0].Set_PlayerScore(1);
                    PlayerList[1].Set_PlayerScore(1);
                }
                else
                {

                    PlayerList[1].Set_PlayerScore(1);
                }
                PlayerList[0].PlayerHand.RemoveAt(0);
                PlayerList[1].PlayerHand.RemoveAt(0);
            }
        }
    }
}
