using System;
using System.Collections.Generic;

namespace Lab1
{
    public class GameAccount
    {
        public GameAccount(string userName, int rating = 0, int gamesCount = 0)
        {
            UserName = userName;
                
            CurrentRating = rating < 1 ? 1 : rating;
            GamesCount = gamesCount;
        }
            
        private string UserName;
        private int CurrentRating;
        private int GamesCount;
        private List<GameHistory> GamesHistory = new List<GameHistory>();
            
        public int GetRating() { return CurrentRating;}
        public void SetRating(int Value) { CurrentRating = Value < GlobalInfo.MinRating ? GlobalInfo.MinRating : Value ;}

        public int GetGamesCount() { return GamesCount;}
        public void SetGamesCount(int Value) { GamesCount = Value < 0 ? 0 : Value;}
            
        public string GetUserName() { return UserName;}

        public void WinGame(ref GameAccount Opponent, int GameRating)
        {
            if (CurrentRating < GameRating || Opponent.GetRating() < GameRating)
            {
                Console.WriteLine("Player " + UserName + "(" + CurrentRating + ")" + " and player " + Opponent.GetUserName() + "(" + Opponent.GetRating() + ")" + " cannot play with rating " + GameRating);
                return;
            }
            
            Opponent.SetGamesCount(Opponent.GetGamesCount() + 1);
            GamesCount++;
                
            CurrentRating += GameRating;
            Opponent.SetRating(Opponent.GetRating() - GameRating);

            GamesHistory.Add( new GameHistory(this, Opponent, true, GameRating));
        }
            
        public void LoseGame(ref GameAccount Opponent, int GameRating)
        {            
            if (CurrentRating < GameRating || Opponent.GetRating() < GameRating)
            {
                Console.WriteLine("Player " + UserName + "(" + CurrentRating + ")" + " and player " + Opponent.GetUserName() + "(" + Opponent.GetRating() + ")" + " cannot play with rating " + GameRating);
                return;
            }
            
            Opponent.SetGamesCount(Opponent.GetGamesCount() + 1);
            GamesCount++;
                
            CurrentRating -= GameRating;
            Opponent.SetRating(Opponent.GetRating() + GameRating);
            
            GamesHistory.Add(new GameHistory(this, Opponent, true, GameRating));
        }

        public void ShowPlayerInfo()
        {
            Console.WriteLine("Player: " + UserName + "\t\tRating: " + CurrentRating + "\tGames quantity: " + GamesCount);
        }            


        public void ShowHistory()
        {
            Console.WriteLine("\nGame history: ");
            foreach (GameHistory History in GamesHistory)
            {
                History.ShowInfo();
            }
        }
    }
}