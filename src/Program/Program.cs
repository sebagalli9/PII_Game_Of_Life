using System;
using System.IO;
using System.Threading;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
        
     
            string path = Path.Combine("..", "..", "assets", "board.txt");

            bool[,] importedBoard = ArchiveReader.GetBoard(path);

            Board board = new Board(importedBoard.GetLength(0),importedBoard.GetLength(1), importedBoard);
            GameRules gameRules = new GameRules(board);

            while(true)
            {
                Console.Clear();
                Console.WriteLine(BoardPrinter.PrintBoard(gameRules.Board));
                gameRules.NextGeneration();
                Thread.Sleep(300);
            }

        }
    }
}
