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
        Random randomNumGen = new Random();
        public frmMinValue()
        {
            InitializeComponent();
           
        }

        private int FindMinVal(int[]array)
        {
            int minVal = 501;
            foreach (int value in array)
            {
                if (value<minVal)
                {
                    minVal = value;
                }
            }
            return minVal;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            int[] valueArray = new int[10];
            int value;
            lstValues.Items.Clear();

            for (int counter = 0; counter < 10; counter ++)
            {
                value = randomNumGen.Next(1, 501);
                valueArray[counter] = value;
                lstValues.Items.Add(value);

                this.Refresh();

            }

            int displayVal = FindMinVal(valueArray);
            MessageBox.Show("The minimum value is " + displayVal);
        }
    }
}
