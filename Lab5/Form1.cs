using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        /*Name: GABRIEL JAY CATAJOY
        Date: NOVEMBER 2022
        This program demonstrates random numbers, displays strings, and using the power of listboxes to display some information.
        */

        const string PROGRAMMER = "Gabriel Jay Catajoy";
        int numAttempts = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private int GetRandom(int min, int max)
        {

            Random rand = new Random();
            int anyNum = rand.Next(min, max);
            return anyNum;

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //Adds class-level constant in form load title, hides all grpbox except Login
            this.Text += " " + PROGRAMMER;
            grpChoose.Visible = false;
            grpText.Visible = false;
            grpStats.Visible = false;
            lblCode.Text = GetRandom(100000, 200000 + 1).ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            //Compares the code entered by the user to the generated code in the label
            if (txtCode.Text != lblCode.Text)
            {
                //adds 1 to class-level variable number of attempts if the input does not match, clears and focuses on the textox
                numAttempts++;
                if (numAttempts < 3)
                {
                    MessageBox.Show("1 incorrent code(s) entered \n" + "Try again - only 3 attempts allowed", PROGRAMMER);
                    txtCode.Focus();
                    txtCode.Text = "";
                }

            }
            //if code matches, show Choose groupbox and disable login groupbox
            else
            {
                grpLogin.Enabled = false;
                grpChoose.Visible = true;
            }

            //Program closes when number of failed attempts reaches 3
            if (numAttempts == 3)
            {
                MessageBox.Show("3 attempts to login\n" + "Account locked - Closing program",PROGRAMMER);
                this.Close();
            }
        }

        private void ResetTextGrp()
        {
            //Clears out all textboxes and labels, unchecks Swap checkbox, and change form properties accept and cancel to join and reset btn respectively.
            txtString1.Text = "";
            txtString2.Text = "";
            chkSwap.Checked = false;
            lblResults.Text = "";
            this.AcceptButton = btnJoin;
            this.CancelButton = btnReset;
        }

        private void ResetStatsGrp()
        {
            //Clears out all labels, clears listbox, resets numUpDown to 10, and change form properties accept and cancel to generate and clear btn
            nudHowMany.Text = "10";
            lblSum.Text = "";
            lblMean.Text = "";
            lblOdd.Text = "";
            lstNumbers.Items.Clear
            this.AcceptButton = btnGenerate;
            this.CancelButton = btnClear;
        }

        private void SetupOption()
        {
            //if Text radio btn is selected, perform ResetTextGrp function, Show Text grpbox, hide Stats grpbox
            if (radText.Checked)
            {
                ResetTextGrp();
                grpText.Show();
                grpStats.Hide();
            }
            //if Stats radio btn is selected, perform ResetStatsGrp function, Show Stats grpbox, hide Text grpbox
            else
            {
                ResetStatsGrp();
                grpStats.Show();
                grpText.Hide();
            }
        }

        private void radText_CheckedChanged(object sender, EventArgs e)
        {
            SetupOption();
        }

        private void radStats_CheckedChanged(object sender, EventArgs e)
        {
            SetupOption();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetTextGrp();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetStatsGrp();
        }

        private void Swap(ref string string1,ref string string2)
        {
            // calls a temporary container and swaps value of string1 to string2 with the help of container variable
            string container = string1;
            string1 = string2;
            string2 = container;

            //re-assigns value of txtboxes with the swapped variables
            txtString1.Text = string1;
            txtString2.Text = string2;
        }

        private bool CheckInput()
        {
            //if both textboxes is not empty, return true. Otherwise, return false
            bool isThisTrue = false;

            if (txtString1.Text != "" && txtString2.Text != "")
            {
                isThisTrue = true;
            }
            return isThisTrue;

        }

        private void chkSwap_CheckedChanged(object sender, EventArgs e)
        {
            //Performs Swap function once checkbox is checked AND there are values in both textboxes
            if (chkSwap.Checked && CheckInput() == true)
            {
                string string1 = txtString1.Text;
                string string2 = txtString2.Text;
                Swap(ref string1,ref string2);
                CheckInput();
                lblResults.Text = "Strings have been swapped!";
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            //if both strings have data, display the information and join the strings
            if (CheckInput() == true)
            {
                lblResults.Text = "First string = " + txtString1.Text + "\n"
                                    + "Second string = " + txtString2.Text + "\n"
                                    + "Joined = " + txtString1.Text + "-->" + txtString2.Text;
            }
        }

        private void btnAnalyze_Click(object sender, EventArgs e)
        {
            //if both strings have data, perform Analyze and count the length of each string using TextLength method
            if (CheckInput() == true)
            {
                lblResults.Text = "First string = " + txtString1.Text + "\n"
                                    + "  Characters = " + txtString1.TextLength + "\n"
                                    + "Second string = " + txtString1.Text + "\n"
                                    + "  Characters = " + txtString2.TextLength;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //Generate random number with seed value of 733, clear out the listbox
            Random generateRandom = new Random(733);
            lstNumbers.Items.Clear();

            //Perform random number until the count reaches nud's current value
            for (int count = 1; count <= nudHowMany.Value; count++)
            {
                lstNumbers.Items.Add(generateRandom.Next(1000,5000 + 1));
            }

            //calls AddList function, which returns sum
            lblSum.Text = AddList().ToString("n0");

            //calculate mean by generating a variable and dividing the sum (AddList) to the listbox items count.
            double mean = Convert.ToDouble(AddList()) / lstNumbers.Items.Count;
            lblMean.Text = mean.ToString("n2");

            //calculate the count of odd numbers by calling CountOdd ftn
            lblOdd.Text = CountOdd().ToString("n0");

        }

        private int AddList()
        {
            //initializes count, performs a while loop to get the sum of the numbers as count increases
            int count = 0, sum = 0, numbers;

            while (count < nudHowMany.Value)
            {
                numbers = Convert.ToInt32(lstNumbers.Items[count++]);
                sum += numbers;
            }

            //returns int sum
            return sum;
        }

        private int CountOdd()
        {
            int numbers, count = 0, odds = 0;

            //same parameters as the while loop: do this loop while count is less than the value of nud
            do
            {
                numbers = Convert.ToInt32(lstNumbers.Items[count++]);

                //add count to odds if the mod of numbers is not equal to 0
                if (numbers % 2 != 0)
                {
                    odds++;
                }

            } while (count < nudHowMany.Value);

            return odds;
        }


    }

}
