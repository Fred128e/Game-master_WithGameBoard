﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spil
{

    public class TicTacToe
    {

        public char[,] GameBoard { get; set; }
        public TicTacToe()
        {
            GameBoard = new char[3, 3] { {' ', ' ', ' '},
                {' ', ' ', ' '},
                { ' ', ' ', ' '} };
        }

        public string GetGameBoardView()
        {
            string resultat = "";
            resultat = resultat + "Y\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "3 *  " + GameBoard[0, 2] + "  *  " + GameBoard[1, 2] + "  *  " + GameBoard[2, 2] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "2 *  " + GameBoard[0, 1] + "  *  " + GameBoard[1, 1] + "  *  " + GameBoard[2, 1] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "1 *  " + GameBoard[0, 0] + "  *  " + GameBoard[1, 0] + "  *  " + GameBoard[2, 0] + "  *\n";
            resultat = resultat + "  *     *     *     *\n";
            resultat = resultat + "  *******************\n";
            resultat = resultat + "     1     2     3    X\n";

            return resultat;
        }


        
        public int counter = 0;
        public string result = " ";
        public static Boolean hasWon = false;


        




            public string Validate()
        {

            int u = 0;

            for (int i = 0; i < 3; i++)
            {

                if (GameBoard[i, u] == currentplayer && GameBoard[i, u + 1] == currentplayer && GameBoard[i, u + 2] == currentplayer)
                {

                    result = "w";
                    hasWon = true;

                }

                if (GameBoard[u, i] == currentplayer && GameBoard[u + 1, i] == currentplayer && GameBoard[u + 2, i] == currentplayer)
                {
                    result = "w";
                    hasWon = true;
                }

                if (GameBoard[0, 0] == currentplayer && GameBoard[1, 1] == currentplayer && GameBoard[2, 2] == currentplayer)
                {
                    result = "w";
                    hasWon = true;
                }

                if (GameBoard[0, 2] == currentplayer && GameBoard[1, 1] == currentplayer && GameBoard[2, 0] == currentplayer)
                {
                    result = "w";
                    hasWon = true;
                }
                if (GameBoard.Length == counter)
                {
                    result = "game over";

                }

               

                
            }

            return result;
        }

        

       
          
       



    public int player = 0; 

        public char currentplayer = ' ';
       
        public char ChangePlayer() 
        {
            if (player % 2 == 0)
            {
                currentplayer = 'x'; 

            }

            else
            { currentplayer = 'o'; } 

            return currentplayer; 
        }


        public void PlaceTile()

        {
            


            int xValue;

            int yValue;

            Console.Write("Vælg X: "); 

            xValue = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Vælg y: "); 

            yValue = Convert.ToInt32(Console.ReadLine()); 

            ChangePlayer();

            GameBoard[xValue - 1, yValue - 1] = currentplayer;

            counter++;

            player++;

            Validate();

            if (hasWon == true)

            {
                PlayAgain();
            }
            if (player1 == currentplayer)
            {
                player1Counter = player1Counter + 1;
            }

            if (player2 == currentplayer)
            {
                player2Counter = player2Counter + 1;
            }




        }

  
        // her kan implementeres metoder til at sætte og flytte en brik

        public void MoveTile()
        {

            Console.Write(currentplayer);
            int xValue;

            int yValue;
            int newYValue;
            int newXValue;
            Console.Write("Vælg X: "); 
            xValue = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Vælg y: "); 

            yValue = Convert.ToInt32(Console.ReadLine());
           

            Console.Write("Vælg X: "); 

            newXValue = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Vælg y: "); 

            newYValue = Convert.ToInt32(Console.ReadLine());


            

            GameBoard[newXValue - 1, newYValue - 1] = GameBoard[xValue - 1, yValue - 1];
            GameBoard[xValue - 1, yValue - 1] = ' ';

           
            player++;
            ChangePlayer();
            counter++;




            Validate();

            if (hasWon == true)

            {
                PlayAgain();
            }

        }

          char player1 = 'x';
            int player1Counter = 0;
            char player2 = 'o';
            int player2Counter = 0;
       
        public void Limiter()
        {

          


           if (player1Counter < 3 || player2Counter < 3)
            {
                
                PlaceTile();
            } 

            else
                Console.WriteLine("STOP HAMMERTIME");
           

        }
        private void PlayAgain()
        {
            
                Console.WriteLine("GZ u vandt");
                Console.WriteLine("wanna play again? ");
            Console.ReadKey();
            hasWon = false;
            
              
        }

    }
}
