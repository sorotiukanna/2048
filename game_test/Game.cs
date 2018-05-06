using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace game_test
{
    class Game
    {
        private int[,] gameBoard;

        public void getBoard(int [,] arr){
            gameBoard = arr;
            return;
        }

        public void setBoard(out int [,] arr) {
            arr = gameBoard;
            return;
        }

        public void left() {
            int[] temp = {0, 0, 0, 0};
            //int k = 0;
            
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++) {
                    temp[j] = gameBoard[i, j];
                }

                int size = temp.Length;
                for (int l = 0; l < size; l++) {
                    if (temp[l] < 1) {
                        Array.Copy(temp, l + 1, temp, l, size - l - 1);
                        size--;
                        l--;
                        temp[size] = 0;
                    }
                }

                size = temp.Length-1;
                for (int l = 0; l < size; l++) {
                    if (temp[l] == temp[l + 1]) {
                        temp[l + 1] = temp[l + 1] * 2;
                        Array.Copy(temp, l + 1, temp, l, size - l - 1);
                        size--;
                        //l--;
                        temp[size] = 0;
                    }
                }

                for (int j = 0; j < 4; j++) {
                    gameBoard[i, j] = temp[j];
                }
            }
        }


        public void right()
        {
            int[] temp = { 0, 0, 0, 0 };
            //int k = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    temp[j] = gameBoard[i, j];
                }

                Array.Reverse(temp);

                int size = temp.Length;
                for (int l = 0; l < size; l++)
                {
                    if (temp[l] < 1)
                    {
                        Array.Copy(temp, l + 1, temp, l, size - l - 1);
                        size--;
                        l--;
                        temp[size] = 0;
                    }
                }

                size = temp.Length-1;
                for (int l = 0; l < size; l++)
                {
                    if (temp[l] == temp[l + 1])
                    {
                        temp[l + 1] = temp[l + 1] * 2;
                        Array.Copy(temp, l + 1, temp, l, size - l - 1);
                        size--;
                        //l--;
                        temp[size] = 0;
                    }
                }

                Array.Reverse(temp);

                for (int j = 0; j < 4; j++)
                {
                    gameBoard[i, j] = temp[j];
                }
            }
        }

        public void up()
        {
            int[] temp = { 0, 0, 0, 0 };
            //int k = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    temp[j] = gameBoard[j, i];
                }

                //Array.Reverse(temp);

                int size = temp.Length;
                for (int l = 0; l < size; l++)
                {
                    if (temp[l] < 1)
                    {
                        Array.Copy(temp, l + 1, temp, l, size - l - 1);
                        size--;
                        l--;
                        temp[size] = 0;
                    }
                }

                size = temp.Length-1;
                for (int l = 0; l < size; l++)
                {
                    if (temp[l] == temp[l + 1])
                    {
                        temp[l + 1] = temp[l + 1] * 2;
                        Array.Copy(temp, l + 1, temp, l, size - l - 1);
                        size--;
                        //l--;
                        temp[size] = 0;
                    }
                }

                //Array.Reverse(temp);

                for (int j = 0; j < 4; j++)
                {
                    gameBoard[j, i] = temp[j];
                }
            }
        }


        public void down()
        {
            int[] temp = { 0, 0, 0, 0 };
            //int k = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    temp[j] = gameBoard[j, i];
                }

                Array.Reverse(temp);

                int size = temp.Length;
                for (int l = 0; l < size; l++)
                {
                    if (temp[l] < 1)
                    {
                        Array.Copy(temp, l + 1, temp, l, size - l - 1);
                        size--;
                        l--;
                        temp[size] = 0;
                    }
                }

                size = temp.Length-1;
                for (int l = 0; l < size; l++)
                {
                    if (temp[l] == temp[l + 1])
                    {
                        temp[l + 1] = temp[l + 1] * 2;
                        Array.Copy(temp, l + 1, temp, l, size - l - 1);
                        size--;
                        //l--;
                        temp[size] = 0;
                    }
                }

                Array.Reverse(temp);

                for (int j = 0; j < 4; j++)
                {
                    gameBoard[j, i] = temp[j];
                }
            }
        }

    }
}
