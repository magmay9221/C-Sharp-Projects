using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Author: Maggie Chen  
// ID: 564956
// Date: 10/2/2016
// Goal: the goal is to create a program that will calculate a baseball player's salary based off an
// user-entered name and number of hits. Then the program will output the tier and salary of the player
// Also, the program should keep track of the leading player and display that information as well. 
namespace TieredPlayerSalaryViaIF_Maggie_Chen
{
    public partial class Form1 : Form
    {
        //global variable for leading hits to be used to help decide who the leading player is.
        int leadingHits = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void btn_exit_Click(object sender, EventArgs e)
        {
            //exits the program
            this.Close();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            //variables for the program to be used in calculations, etc. 
            string playerName;
            int numberOfHits;
            double calculated_salary;
            int tier_1 = 1;
            int tier_2 = 2;
            int tier_3 = 3;
            int tier_4 = 4;

                //get user input of the number of hits, then check if what the user entered is a 
                //valid number of hits. If not, then don't perform any calculations. 
                if (int.TryParse(num_hits_textbox.Text, out numberOfHits))
            {
                if(numberOfHits > 0 && numberOfHits <= 300)
                {

                }
                else
                {
                    MessageBox.Show("Whoops, that is not a valid number of hits. Try again.");
                }
            }
            else
            {
                MessageBox.Show("Argh, the number of hits must be an integer!");
            }

                //if statements based off which checkboxes, if any are checked, and perform the 
                //necessary calculations based off the conditions. 
            if (all_star_checkbox.Checked)
            {

                if (numberOfHits>=1 && numberOfHits <= 49)
                {
                    calculated_salary = (numberOfHits *17500) + ((numberOfHits*17500) * .20);
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_1.ToString();
                 }

              else if (numberOfHits >= 50 && numberOfHits <= 99)
                {
                    calculated_salary = (numberOfHits* 20000) + ((numberOfHits*20000) * .20);
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_2.ToString();

                }

             else if (numberOfHits>=100 && numberOfHits <= 149)
                {
                    calculated_salary = (numberOfHits *22500) + ((numberOfHits*22500) * .20);
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_3.ToString();
                }

              else if (numberOfHits>=150 && numberOfHits <= 300)
                {
                    calculated_salary = (numberOfHits *25000) + ((numberOfHits*25000) * .20);
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_4.ToString();
                }
              else
                {

                }
            }
            if (mvp_checkbox.Checked)
            {
                if (numberOfHits >= 1 && numberOfHits <= 49)
                {
                    calculated_salary = (numberOfHits * 17500) + ((numberOfHits * 17500) * .20);
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_1.ToString();
                }

                else if (numberOfHits >= 50 && numberOfHits <= 99)
                {
                    calculated_salary = (numberOfHits * 20000) + ((numberOfHits * 20000) * .20);
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_2.ToString();

                }

                else if (numberOfHits >= 100 && numberOfHits <= 149)
                {
                    calculated_salary = (numberOfHits * 22500) + ((numberOfHits * 22500) * .20);
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_3.ToString();
                }

                else if (numberOfHits >= 150 && numberOfHits <= 300)
                {
                    calculated_salary = (numberOfHits * 25000) + ((numberOfHits * 25000) * .20);
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_4.ToString();
                }
                else
                {

                }
            }

          if(mvp_checkbox.Checked && all_star_checkbox.Checked)
            {
                if (numberOfHits >= 1 && numberOfHits <= 49)
                {
                    calculated_salary = (numberOfHits * 17500) + ((numberOfHits * 17500) * .25);
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_1.ToString();
                }

                else if (numberOfHits >= 50 && numberOfHits <= 99)
                {
                    calculated_salary = (numberOfHits * 20000) + ((numberOfHits * 20000) * .25);
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_2.ToString();

                }

                else if (numberOfHits >= 100 && numberOfHits <= 149)
                {
                    calculated_salary = (numberOfHits * 22500) + ((numberOfHits * 22500) * .25);
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_3.ToString();
                }

                else if (numberOfHits >= 150 && numberOfHits <= 300)
                {
                    calculated_salary = (numberOfHits * 25000) + ((numberOfHits * 25000) * .25);
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_4.ToString();
                }
                else
                {

                }
            }
          if(!mvp_checkbox.Checked && !all_star_checkbox.Checked)
            {
                if (numberOfHits >= 1 && numberOfHits <= 49)
                {
                    calculated_salary = numberOfHits * 17500;
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_1.ToString();
                }

                else if (numberOfHits >= 50 && numberOfHits <= 99)
                {
                    calculated_salary = numberOfHits* 20000;
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_2.ToString();

                }

                else if (numberOfHits >= 100 && numberOfHits <= 149)
                {
                    calculated_salary =numberOfHits* 22500;
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_3.ToString();
                }

                else if (numberOfHits >= 150 && numberOfHits <= 300)
                {
                    calculated_salary =numberOfHits* 25000;
                    calc_salary_label.Text = calculated_salary.ToString("c");
                    calc_tier_label.Text = tier_4.ToString();
                }
                else
                {

                }
            }
            if(isLeading(numberOfHits))//calling the boolean method for conditions in displaying the 
                //leading player's name. 
            {
                leading_name_label.Text = name_textbox.Text;
                leading_hits_label.Text = numberOfHits.ToString();
                leading_salary_label.Text = calc_salary_label.Text;
                leading_tier_label.Text = calc_tier_label.Text;

            }



        }

        private void name_textbox_Validating(object sender, CancelEventArgs e)
        {
            //this is to be used so that if a user does not enter a name into the name textbox
            //you can not move forward into program, and calculations cannot be made. 
            string errorMsg;
            if (!ValidPlayerName(name_textbox.Text, out errorMsg))
            {
                // Cancel the event so the calculations are unable to be processes if user does not
                //enter a valid name 
                e.Cancel = true;
                name_textbox.Select(0, name_textbox.Text.Length);

                // Set the ErrorProvider error with the the error message
                this.errorProvider1.SetError(name_textbox, errorMsg);
            }
        }

        private void name_textbox_Validated(object sender, EventArgs e)
        {
            //clears error message
            errorProvider1.SetError(name_textbox, "");
        }

        public bool ValidPlayerName(string playerName, out string errorMessage)
        {
            //boolean method to determine if there is any character in the name textbox
            if (playerName.Length == 0)
            {
                errorMessage = "Egads! Player name is required.";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
        }
        public bool isLeading(int numOfHits)
            //boolean method used to compare hit counts and then determining who is the leading player
        {
            if(numOfHits > leadingHits)
            {
                leadingHits = numOfHits;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //clears the necessary labels and textboxes when button is pushed.
            name_textbox.Text = null;
            num_hits_textbox.Text = null;
            calc_salary_label.Text = null;
            calc_tier_label.Text = null;
            leading_tier_label.Text = null;
            leading_name_label.Text = null;
            leading_hits_label.Text = null;
            leading_salary_label.Text = null;
            leadingHits = 0; 
        }
    }
}
