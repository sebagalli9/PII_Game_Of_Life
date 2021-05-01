using System;

namespace PII_Game_Of_Life
{
    public class Board
    {
        /*  La única responsabilidad de la clase Board es generar un tablero,
            y cumple con el principio SRP, ya que la única razón de 
            cambio posible es cambiar la forma en que se genera el tablero.
        */
    
        public int Width {get; set;}
        public int Height { get; set; }

        public bool[,] board;

        public Board(int width, int height, bool[,] board = null)
        {
            this.Width = width;
            this.Height = height;
            this.board = new bool[width, height];
            {
                if (board!=null)
                {
                    for (int x = 0; x < Math.Min(Width, board.GetLength(0)); x++)
                    {
                        for (int y = 0; y < Math.Min(Height, board.GetLength(1)); y++)
                        {
                            this.board[x,y] = board[x,y];
                        }
                    }
                }
            } 
        }

        public bool GetPosition(int posX, int posY)
        {
            return this.board[posX,posY];
        }

        public void IsAlive(int posX, int posY, bool alive)
        {
            this.board[posX,posY] = alive;
        }
    }
}
