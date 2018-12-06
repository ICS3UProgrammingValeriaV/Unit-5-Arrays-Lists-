using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListsValeriaV
{
    public partial class frmList : Form
    {
        //create global variables
        int numOfVal = 0;
        List<int> userValues = new List<int>();
        public frmList()
        {
            InitializeComponent();
        }

        //Function: CalculateAverage
        //Input: List<int>tmpList
        //Output: int average
        //Description this function calculates the average
        private int CalculateAverage(List<int>tmpList, int listElem)
        {
            //declare local variables
            int average = 0;
            int sum = 0;
            //loop through each element in the list 
            for (int index = 0; index < tmpList.Count; index = 0)
            {
                //calculate the sum of the elemts in the list
                sum = sum + tmpList[index];
                Console.WriteLine(sum);
            }
            //divide the sum by the number of elements in the list to find the average
            average = sum / listElem;
            Console.WriteLine(average);
            //return the average
            return average;
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            //declare local variables
            int userMark = 0;

            //increment the number of values
            numOfVal++;

            //convert the value from the text box to an integer
            try
            {
                userMark = int.Parse(txtMark.Text);
            }
            //catch if the value from the text box is not an integer and write an error to the console
            catch(Exception parseError)
            {
                Console.WriteLine("An error occured:{0}", parseError);
            }

            //check if the user entered a number between 1 and 100
            if ((userMark >= 1) && (userMark<= 100))
            {
                //add the mark to the list box
                this.lstMarks.Items.Add(userMark);
                //add the mark to the list
                userValues.Add(userMark);
            }
            //if the number is not between 1 and 100, display an error to the message box
            else
            {
                MessageBox.Show("Please enter a number between 1 and 100");
            }


        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //declare local variables
            int average;
            //disable the enter button
            btnEnter.Enabled = false;
            //call the calculate average function
            average = CalculateAverage(userValues, numOfVal);
            //display the average in a message box
            MessageBox.Show("The average is " + average);

        }
    }
}
