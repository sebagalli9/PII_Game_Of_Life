using System;

namespace PII_Game_Of_Life
{
    public class GameRules
    {
         
        public Board Board{get; set;}

        public GameRules(Board board)
        {
            this.Board = board;
        }

        public void NextGeneration()
        {
            Board newBoard = new Board(this.Board.Width, this.Board.Height);

           for (int x = 0; x < Board.Width; x++)
            {
                for (int y = 0; y < Board.Height; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<Board.Width && j>=0 && j < Board.Height && this.Board.GetPosition(i,j))
                            {
                                aliveNeighbors++;
                            }
                        }
                    }

                    if(this.Board.GetPosition(x,y))
                    {
                        aliveNeighbors--;
                    }
                    if (this.Board.GetPosition(x,y) && aliveNeighbors < 2) 
                    {
                        //Celula muere por baja población
                        newBoard.IsAlive(x,y,false); 
                    }
                    else if (this.Board.GetPosition(x,y) && aliveNeighbors > 3) 
                    {
                        //Celula muere por sobrepoblación
                        newBoard.IsAlive(x,y,false); 
                    }
                    else if (!this.Board.GetPosition(x,y) && aliveNeighbors == 3) 
                    {
                        //Celula nace por reproducción 
                        newBoard.IsAlive(x,y,true);
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        newBoard.IsAlive(x,y,this.Board.GetPosition(x,y));
                    }
                } 
            } 

            //Se resetea el tablero con los ultimos valores del tablero anterior como los valores iniciales del nuevo tablero
            this.Board = newBoard; 

        }
    }
}
