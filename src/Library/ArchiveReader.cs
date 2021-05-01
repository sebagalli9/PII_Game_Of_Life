using System;
using System.Text;
using System.IO;
using System.Collections.Generic;

namespace PII_Game_Of_Life
{
    public class ArchiveReader
    {
        /*  Esta clase tiene cómo única responsabilidad importar un tablero
            de acuerdo a la información obtenida mediante un archivo de texto,
            por lo tanto cumple con el principio SRP, debido a que la única razón 
            de cambio posible es cambiar el tipo de archivo a interpretar.
        */
        
        public static bool[,] GetBoard(string url){

            string content = File.ReadAllText(url);
            string[] contentLines = content.Split('\n');
            bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
            for (int  y=0; y<contentLines.Length;y++)
            {
                for (int x=0; x<contentLines[y].Length; x++)
                {
                    if(contentLines[y][x]=='1')
                    {
                        board[x,y]=true;
                    }
                }
            }
            return board;
        }
    }
}
