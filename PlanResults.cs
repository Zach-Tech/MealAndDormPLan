using System;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Zachary_Childers_CPT_185_Lab_9
{

    public partial class PlanResults : Form
    {
        public PlanResults(int totalCost, int mealCost, int dormCost)
        {
            this.TotalCost = totalCost;
            this.MealCost = mealCost;
            this.DormCost = dormCost;
            InitializeComponent();
            totalOutput.Text = totalCost.ToString("C");
            txtMealOutput.Text = mealCost.ToString("C");
            txtDormOutput.Text = dormCost.ToString("C");
        }
        
        public int TotalCost { get; set; }
        public int MealCost { get; set; }
        public int DormCost { get; set; }

        private void iconExt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abtBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            PlanMiniAbout mini = new PlanMiniAbout();
            mini.Show();
        }
    }
}
