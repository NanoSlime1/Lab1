using System;


namespace Lab1
{
    public class Lab1
    {
        public static void Main(String[] args)
        {
            
            GameAccount Player1 = new GameAccount("Player1", 100);
            GameAccount Player2 = new GameAccount("Player2", 50);

            Player1.WinGame(ref Player2, 20);
            Player1.LoseGame(ref Player2, 30);
            Player2.WinGame(ref Player1, 100);
            Player2.LoseGame(ref Player1, 20);
            
            Player2.ShowPlayerInfo();
            Player1.ShowHistory();
        }
    }
}
