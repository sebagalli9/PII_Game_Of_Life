using System;
using System.IO;
using System.Text;

namespace PII_Game_Of_Life
{
    public class BoardPrinter
    {

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
