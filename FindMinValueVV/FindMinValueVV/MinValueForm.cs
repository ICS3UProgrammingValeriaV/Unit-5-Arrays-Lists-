/*
 * Created by: Valeria Veverita
 * Created on: 03-December-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #37 - Find Min Value
 * This program generates ten random values and picks the lowest one
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindMinValueVV
{
    public partial class frmMinValue : Form
    {
        //declare global variable
        Random randomNumGen = new Random();
        public frmMinValue()
        {
            InitializeComponent();
           
        }

        //Functin: FindMinVal
        //Input: int[]array
        //Output: int minVal
        //Description: this function picks the lowest value in the array
        private int FindMinVal(int[]array)
        {
            //declare local variable
            int minVal = 501;
            //loop through each value in the array
            foreach (int value in array)
            {   //check if the value is less than the minValue
                if (value<minVal)
                {   //set the minValue to be equal to the value
                    minVal = value;
                }
            }
            //return the minValue
            return minVal;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            //create an array
            int[] valueArray = new int[10];
            //declare local variables
            int value;
            //clear the list box
            lstValues.Items.Clear();
            //check if the counter is less than 10
            for (int counter = 0; counter < 10; counter ++)
            {   //generate a random number between 1 and 500
                value = randomNumGen.Next(1, 501);
                //add the value to the array
                valueArray[counter] = value;
                //add the value to the listbox
                lstValues.Items.Add(value);
                //refresh the form
                this.Refresh();

            }
            //call the functionFindMinValue and assign the return to the displayVal variable
            int displayVal = FindMinVal(valueArray);
            //display the minimum value
            MessageBox.Show("The minimum value is " + displayVal);
        }
    }
}
