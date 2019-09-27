namespace SortingApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Windows.Forms;
    public partial class sortingForm : Form
    {
        int[] integerArray = new int[10];    //Variable to hold the array of integers to be sorted
        Random rng = new Random();           //Random number generator for the New List and Shuffle buttons

        public sortingForm()
        {
            InitializeComponent();
        }

        //Button allowing the user to generate a new list of 10 random integers
        private void NewListClick(object sender, EventArgs e)
        {
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

        //Perform the mergesort algorithm, updating the display with each merge 
        private void MergeSortButtonClick(object sender, EventArgs e)
        {
            //Set the label
            currentOperationLabel.Text = "MergeSort in progress...";
            currentOperationLabel.Refresh();

            //Merge functions take and return List<int> so need to cast before and after the algorithm
            List<int> sortedList = MergeSort(integerArray.ToList());
            integerArray = sortedList.ToArray();

            //Clear the label
            currentOperationLabel.Text = "";

        }

        //Recursive algorithm to sort the array by splitting the problem into manageable chunks
        public List<int> MergeSort(List<int> arr)
        {
            if (arr.Count <= 1)
            {
                return arr;
            }

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = arr.Count / 2;

            for (int i = 0; i < middle; i++)
            {
                left.Add(arr[i]);
            }
            for (int j = middle; j < arr.Count; j++)
            {
                right.Add(arr[j]);
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        //Combines two SORTED lists into one SORTED list
        public List<int> Merge(List<int> left, List<int> right)
        {
            List<int> c = new List<int>();
            //Run until both lists are empty
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    //Sort them until one is empty
                    if (left.First() <= right.First())
                    {
                        c.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        c.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                //Add any remaining elements
                else if (left.Count > 0)
                {
                    c.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    c.Add(right.First());
                    right.Remove(right.First());
                }
            }
            //Clear display and redisplay the list after each merge
            listDisplay.Clear();
            for (int k = 0; k < c.Count; k++)
            {
                listDisplay.Text += (k < c.Count - 1) ? $"{c[k]}, " : $"{c[k]}";
            }
            Thread.Sleep(500);
            listDisplay.Refresh();
            return c;
        }

        //Perform the quicksort algorithm on the integerArray, would like to possibly highlight the pivot in another colour each time?
        private void QuickSortButtonClick(object sender, EventArgs e)
        {
            //Update label
            currentOperationLabel.Text = "QuickSort in progress...";
            currentOperationLabel.Refresh();

            //Perform the algorithm
            QuickSort(integerArray, 0, integerArray.Length - 1);

            //Clear the label
            currentOperationLabel.Text = "";
        }

        //Recursive quicksort and partition methods
        public void QuickSort(int[] nums, int low, int high)
        {
            if (low < high)
            {
                int pIndex = Partition(nums, low, high);   //pIndex will be in sorted position
                QuickSort(nums, low, pIndex - 1);
                QuickSort(nums, pIndex + 1, high);
            }
        }
        public int Partition(int[] nums, int low, int high)
        {
            //Select furthest most right value to be the pivot
            int pivot = nums[high];
            //pIndex will be the index of the pivot after sorting
            int pIndex = low;

            for (int i = low; i < high; i++)
            {
                if (nums[i] <= pivot)
                {
                    //Ensure all numbers smaller than pivot are to the left of pIndex 
                    Tools.SwapValues(ref nums[pIndex], ref nums[i]);
                    pIndex++;
                }
            }
            //Swap pivot with pIndex so pivot is in sorted position
            Tools.SwapValues(ref nums[pIndex], ref nums[high]);

            //Clear display and redisplay the list after partition
            listDisplay.Clear();
            for (int k = 0; k < 10; k++)
            {
                listDisplay.Text += (k < 9) ? $"{integerArray[k]}, " : $"{integerArray[k]}";
            }
            Thread.Sleep(500);
            listDisplay.Refresh();

            return pIndex;
        }

        //Perform a shuffle on the current integerArray so the same array can be sorted again. (Knuth Shuffle)
        private void ShuffleButtonClick(object sender, EventArgs e)
        {
            int n = integerArray.Length;
            while (n > 1)
            {
                //Choose value up to n, then deincrement n
                int k = rng.Next(n--);
                //Let temp be the last unshuffled value
                int temp = integerArray[n];
                //Let the last unshuffled value equal the random value at index k
                integerArray[n] = integerArray[k];
                //Assign the overwritten value
                integerArray[k] = temp;
            }

            //Clear display and redisplay the list after shuffling
            listDisplay.Clear();
            for (int k = 0; k < 10; k++)
            {
                listDisplay.Text += (k < 9) ? $"{integerArray[k]}, " : $"{integerArray[k]}";
            }

        }
    }
}
