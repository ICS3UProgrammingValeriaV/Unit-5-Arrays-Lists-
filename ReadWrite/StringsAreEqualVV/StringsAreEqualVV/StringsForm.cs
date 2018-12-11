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
            //hide the instruction
            lblAnswer.Hide();
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
            //create a local array 
            //Read each line of the file into the string array
            string[] lines = System.IO.File.ReadAllLines(@"input.txt");

            //characters that I want to take out when spliting the lines of txt
            char[] separators = new char[] { ' ', '\t' };

            //output string
            string output = " ";

            //Split each line into words and add them to lines array
            foreach(string line in lines)
            {
                string[] words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);


                //check if the strings are equal
                if (StringsAreEqual(words[0], words[1]) == true)
                {
                    output = output + "True\r\n";
                }
                else
                {
                    output = output + "False\r\n";
                }
            }

            //write the output to a new text file
            System.IO.File.WriteAllText(@"output.txt", output);

            //show the user the instruction
            lblAnswer.Show();
        }
    }
}
