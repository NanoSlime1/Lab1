using System;

namespace Lab1
{
    public class GameHistory
    {
        private static int Games = 0;
        private int GameID;
        private GameAccount FirstPlayer;
        private GameAccount SecondPlayer;
        private bool bWinFirstPlayer;
        private int GameRating;

        public string GetPlayerOneName() { return FirstPlayer.GetUserName(); }
        public string GetPlayerTwoName() { return SecondPlayer.GetUserName(); }
        public bool IsFirstPlayerWin() { return bWinFirstPlayer; }

        public GameHistory(GameAccount firstPlayer, GameAccount secondPlayer, bool bFirstPlayerWin, int RatingGame)
        {
            FirstPlayer = firstPlayer;
            SecondPlayer = secondPlayer;
            bWinFirstPlayer = bFirstPlayerWin;
            GameRating = RatingGame;
            GameID = Games++;
        }

        public void ShowInfo()
        { 
            Console.Write("Game ID: " + GameID + "\tPlayer One: " + FirstPlayer.GetUserName() + "\tPlayer Two: " + SecondPlayer.GetUserName() + "\tWinner of the game is ");
            Console.WriteLine(bWinFirstPlayer ? FirstPlayer.GetUserName() : SecondPlayer.GetUserName());
        }
    }
    
}