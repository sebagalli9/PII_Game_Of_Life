using System;
using System.IO;
using System.Text;

namespace PII_Game_Of_Life
{
    public class BoardPrinter
    {
        /*  La clase BoardPrinter tiene como única razón 
            de cambio, modificar la forma en la que el tablero
            se muestra en consola, por lo tanto cumple con el 
            principio SRP.
        */

       public static string PrintBoard(Board board)
       {
            
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<board.Height;y++)
                {
                    for (int x = 0; x<board.Width; x++)
                    {
                        if(board.GetPosition(x,y))
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                return(s.ToString());
       }
    }
}
