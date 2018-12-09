/*
 * Created by: Valeria Veverita
 * Created on: 26-November-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #35 - String Equality
 * This program checks if two strings are similar or not
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

namespace StringsAreEqualVV
{
    public partial class frmStrings : Form
    {
        public frmStrings()
        {
            InitializeComponent();
        }

        /*
         * Function: StringsAreEqual
         * Input: string1, string2
         * Output: bool isEqual
         * Description: this function checks the length of the strings, if the strings are the same or not
         */ 
       private bool StringsAreEqual(string string1, string string2)
        {
            //declare local variable 
            bool isEqual = false;

            //check the length of the string
            if (string1.Length == string2.Length)
            {
                //compare the strings
                //convert the strings to lower case
                if (string1.ToLower() == string2.ToLower())
                {
                    //if strings are the same set the boolean variable to true & write the strings to the console
                    Console.WriteLine(string1.ToLower());
                    Console.WriteLine(string2.ToLower());

                    isEqual = true;
                }
                else
                //if the strings are not the same set the boolean variable to false
                {
                    isEqual = false;
                }
            }
            //if the lengthes of the strings are not equal set the boolena variable to false
            else
            {
                isEqual = false;
            }

            //return the boolean variable
            return isEqual;
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            //declare local variables and get the strings from the user
            string userString1, userString2;
            userString1 = txtString1.Text;
            userString2 = txtString2.Text;
            

            //declare and set the boolena variable to false
           bool userCheck = false;
            //call the StringsAreEqual function and pass teh strings to the function
            //set the userCheck to equal the return boolean 
            userCheck = StringsAreEqual(userString1, userString2);

            //check if the boolean variable is true, display to the user that the strings are equal
            if (userCheck == true)
            {
                MessageBox.Show("The strings are the same");
            }
            //check if the boolean variable is false, display to the user that the strings are not equal
            else if (userCheck == false)
            {
                MessageBox.Show("The strings are not the same");
            }
            //if the function doesn't return anything, display to the console "Error"
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
