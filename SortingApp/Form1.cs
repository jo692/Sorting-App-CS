﻿namespace SortingApp
{
    using System;
    using System.Threading;
    using System.Windows.Forms;
    public partial class sortingForm : Form
    {
        int[] integerArray = new int[10];    //Variable to hold the array of integers to be sorted

        public sortingForm()
        {
            InitializeComponent();
        }

        //Button allowing the user to generate a new list of 10 random integers
        private void NewListClick(object sender, EventArgs e)
        {
            Random rng = new Random();

            //Clear the current display for new numbers
            listDisplay.Clear();
            
            //Loop for 10 random integers
            for (int i = 0; i < 10; i++)
            {
                integerArray[i] = rng.Next(-100, 500);
                //Add first 9 numbers with comma seperation, final without
                listDisplay.Text += (i < 9) ? $"{integerArray[i]}, " : $"{integerArray[i]}";
            }
        }

        //Sort the current number list using the bubble sort algorithm, printing the list on each pass
        private void BubbleSortButtonClick(object sender, EventArgs e)
        {
            //Update label
            currentOperationLabel.Text = "BubbleSort in progress...";
            currentOperationLabel.Refresh();
            for (int i = 0; i < integerArray.Length - 1; i++)
            {
                for (int j = 0; j < integerArray.Length - 1 - i; j++)
                {
                    if (integerArray[j] > integerArray[j + 1])
                    {
                        Tools.SwapValues(ref integerArray[j], ref integerArray[j + 1]);
                    }
                }
                //Clear display and redisplay the list after each pass
                listDisplay.Clear();
                for (int k = 0; k < 10; k++)
                {
                    listDisplay.Text += (k < 9) ? $"{integerArray[k]}, " : $"{integerArray[k]}";
                }
                Thread.Sleep(500);
                listDisplay.Refresh();
            }
            //Clear the label
            currentOperationLabel.Text = "";
        }

        //Perform the selection sort algorithm on the current integer array, updating the display on each pass
        private void SelectionSortButtonClick(object sender, EventArgs e)
        {
            //Update label
            currentOperationLabel.Text = "SelectionSort in progress...";
            currentOperationLabel.Refresh();

            //Variables to hold the current smallest value and its index within integerArray
            int smallest = int.MaxValue; int smallestIndex = 0;
            for (int i = 0; i < integerArray.Length; i++)
            {
                smallest = int.MaxValue;
                for (int j = i; j < integerArray.Length; j++)
                {
                    if(integerArray[j] <= smallest)
                    {
                        smallest = integerArray[j];
                        smallestIndex = j;
                    }
                }
                Tools.SwapValues(ref integerArray[i], ref integerArray[smallestIndex]);

                //Clear display and redisplay the list after each pass
                listDisplay.Clear();
                for (int k = 0; k < 10; k++)
                {
                    listDisplay.Text += (k < 9) ? $"{integerArray[k]}, " : $"{integerArray[k]}";
                }
                Thread.Sleep(500);
                listDisplay.Refresh();
            }
            //Clear the label
            currentOperationLabel.Text = "";
        }
    }
}