//Zachary Childers
//CPT-185-A01S
//Spartanburg Community College
//Lab 9 (10-6)

using System;
using System.Windows.Forms;

namespace Zachary_Childers_CPT_185_Lab_9
{
    public partial class PlanSelect : Form
    {
        //These arrays contain the values for meals/dorms
        private int[] dormPrice = { 1500, 1600, 1800, 2500 };
        private int[] mealPrice = { 600, 1200, 1700 };
        //integer declaring index selection in panel box
        private int dormSelect = 0;
        private int mealSelect = 0;
        public PlanSelect()
        {
            InitializeComponent();
        }

        private void dorm_selection_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                RadioButton dormRadioButton = (RadioButton)sender;
            }
           
        }

        private void meal_selection_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                RadioButton mealRadioButton = (RadioButton)sender;

            }
        }
        //rdBtnAllen        =       Allen Hall
        //rdBtnPike         =       Pike Hall
        //rdBtnFarthing     =        Farthing Hall
        //rdBtnUniSuite      =        University Suites
        //rdBtnMeals_7      =        7 Meals Per Week Option
        //rdBtnMeals_14      =      14 Meals Per Week Option
        //rdBtnMeals_Unlimited      =    Unlimited Meals Per Week Option
        private void rdBtnAllen_CheckedChanged(object sender, EventArgs e)
        {
            dormSelect = dormPrice[0];
            dorm_selection_CheckedChanged(sender, e);

        }

        private void rdBtnPike_CheckedChanged(object sender, EventArgs e)
        {
            dormSelect = dormPrice[1];
            dorm_selection_CheckedChanged(sender, e);

        }

        private void rdBtnFarthing_CheckedChanged(object sender, EventArgs e)
        {
            dormSelect = dormPrice[2];
            dorm_selection_CheckedChanged(sender, e);
        }

        private void rdBtnUniSuite_CheckedChanged(object sender, EventArgs e)
        {
            dormSelect = dormPrice[3];
            dorm_selection_CheckedChanged(sender, e);
        }

        private void rdBtnMeals_7_CheckedChanged(object sender, EventArgs e)
        {
            mealSelect = mealPrice[0];
            meal_selection_CheckedChanged(sender, e);
        }

        private void rdBtnMeals_14_CheckedChanged(object sender, EventArgs e)
        {
            mealSelect = mealPrice[1];
            meal_selection_CheckedChanged(sender, e);
        }

        private void rdBtnMeals_Unlimited_CheckedChanged(object sender, EventArgs e)
        {
            mealSelect = mealPrice[2];
            meal_selection_CheckedChanged(sender, e);
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //onTotals button click, the below happens
            // essentially:
            // if the user has no inputs -> error
            // if the user has one input from either location,
            // but not the other -> error
            // It will open PlanResults.cs upon success
            if(!rdBtnAllen.Checked 
                && !rdBtnPike.Checked 
                && !rdBtnFarthing.Checked 
                && !rdBtnUniSuite.Checked 
                && !rdBtnMeals_7.Checked 
                && !rdBtnMeals_14.Checked 
                && !rdBtnMeals_Unlimited.Checked)
            {
                MessageBox.Show("Please select a plan!", 
                    "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                rdBtnAllen.Checked = false;
                rdBtnFarthing.Checked = false;
                rdBtnPike.Checked = false;
                rdBtnUniSuite.Checked = false;
                rdBtnMeals_7.Checked = false;
                rdBtnMeals_14.Checked = false;
                rdBtnMeals_Unlimited.Checked = false;
            }
            else
            {

                if (!rdBtnAllen.Checked 
                    && !rdBtnPike.Checked 
                    && !rdBtnFarthing.Checked 
                    && !rdBtnUniSuite.Checked)
                {
                    MessageBox.Show("Please select a Dorm Plan!",
                      "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rdBtnMeals_7.Checked = false;
                    rdBtnMeals_14.Checked = false;
                    rdBtnMeals_Unlimited.Checked = false;
                }
                else
                {
                    if (!rdBtnMeals_7.Checked 
                        && !rdBtnMeals_14.Checked 
                        && !rdBtnMeals_Unlimited.Checked)
                    {
                        MessageBox.Show("Please select a Meal Plan!",
                    "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rdBtnAllen.Checked = false;
                        rdBtnFarthing.Checked = false;
                        rdBtnPike.Checked = false;
                        rdBtnUniSuite.Checked = false;
                    }
                    else
                    {
                        var totalCost = dormSelect + mealSelect;
                        var mealCost = mealSelect;
                        var dormCost = dormSelect;
                        PlanResults resultShow = new PlanResults(totalCost, mealCost, dormCost);
                        resultShow.Show();
                    }

                }
            }
            //Yo dawg
            //I heard you like If/Else Statements...
            



        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            rdBtnAllen.Checked = false;
            rdBtnFarthing.Checked = false;
            rdBtnPike.Checked = false;
            rdBtnUniSuite.Checked = false;
            rdBtnMeals_7.Checked = false;
            rdBtnMeals_14.Checked = false;
            rdBtnMeals_Unlimited.Checked = false;
            this.Focus();
        }

        private void iconExt_Click(object sender, EventArgs e)
        {
            //could use application.close here
            //can't decide which is better UX-wise.
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            //this.Close();
            PlanMiniAbout mini = new PlanMiniAbout();
            mini.Show();
        }
    }
}
