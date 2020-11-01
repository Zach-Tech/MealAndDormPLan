namespace Zachary_Childers_CPT_185_Lab_9
{
    partial class PlanSelect
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanSelect));
            this.grpBoxDorms_Select = new System.Windows.Forms.GroupBox();
            this.rdBtnUniSuite = new System.Windows.Forms.RadioButton();
            this.rdBtnFarthing = new System.Windows.Forms.RadioButton();
            this.rdBtnPike = new System.Windows.Forms.RadioButton();
            this.rdBtnAllen = new System.Windows.Forms.RadioButton();
            this.grpBxMeal = new System.Windows.Forms.GroupBox();
            this.rdBtnMeals_Unlimited = new System.Windows.Forms.RadioButton();
            this.rdBtnMeals_14 = new System.Windows.Forms.RadioButton();
            this.rdBtnMeals_7 = new System.Windows.Forms.RadioButton();
            this.iconExt = new FontAwesome.Sharp.IconButton();
            this.btnTotal = new FontAwesome.Sharp.IconButton();
            this.btnClr = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnHelp = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpBoxDorms_Select.SuspendLayout();
            this.grpBxMeal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxDorms_Select
            // 
            this.grpBoxDorms_Select.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBoxDorms_Select.BackColor = System.Drawing.Color.White;
            this.grpBoxDorms_Select.Controls.Add(this.rdBtnUniSuite);
            this.grpBoxDorms_Select.Controls.Add(this.rdBtnFarthing);
            this.grpBoxDorms_Select.Controls.Add(this.rdBtnPike);
            this.grpBoxDorms_Select.Controls.Add(this.rdBtnAllen);
            this.grpBoxDorms_Select.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxDorms_Select.Location = new System.Drawing.Point(112, 52);
            this.grpBoxDorms_Select.Name = "grpBoxDorms_Select";
            this.grpBoxDorms_Select.Size = new System.Drawing.Size(258, 220);
            this.grpBoxDorms_Select.TabIndex = 0;
            this.grpBoxDorms_Select.TabStop = false;
            this.grpBoxDorms_Select.Text = "Select a Dorm";
            this.toolTip1.SetToolTip(this.grpBoxDorms_Select, "Select your Dorm Plan");
            // 
            // rdBtnUniSuite
            // 
            this.rdBtnUniSuite.AutoSize = true;
            this.rdBtnUniSuite.Location = new System.Drawing.Point(52, 151);
            this.rdBtnUniSuite.Name = "rdBtnUniSuite";
            this.rdBtnUniSuite.Size = new System.Drawing.Size(148, 25);
            this.rdBtnUniSuite.TabIndex = 3;
            this.rdBtnUniSuite.TabStop = true;
            this.rdBtnUniSuite.Text = "University Suites";
            this.rdBtnUniSuite.UseVisualStyleBackColor = true;
            this.rdBtnUniSuite.CheckedChanged += new System.EventHandler(this.rdBtnUniSuite_CheckedChanged);
            // 
            // rdBtnFarthing
            // 
            this.rdBtnFarthing.AutoSize = true;
            this.rdBtnFarthing.Location = new System.Drawing.Point(52, 120);
            this.rdBtnFarthing.Name = "rdBtnFarthing";
            this.rdBtnFarthing.Size = new System.Drawing.Size(119, 25);
            this.rdBtnFarthing.TabIndex = 2;
            this.rdBtnFarthing.TabStop = true;
            this.rdBtnFarthing.Text = "Farthing Hall";
            this.rdBtnFarthing.UseVisualStyleBackColor = true;
            this.rdBtnFarthing.CheckedChanged += new System.EventHandler(this.rdBtnFarthing_CheckedChanged);
            // 
            // rdBtnPike
            // 
            this.rdBtnPike.AutoSize = true;
            this.rdBtnPike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdBtnPike.Location = new System.Drawing.Point(52, 89);
            this.rdBtnPike.Name = "rdBtnPike";
            this.rdBtnPike.Size = new System.Drawing.Size(90, 25);
            this.rdBtnPike.TabIndex = 1;
            this.rdBtnPike.TabStop = true;
            this.rdBtnPike.Text = "Pike Hall";
            this.rdBtnPike.UseVisualStyleBackColor = true;
            this.rdBtnPike.CheckedChanged += new System.EventHandler(this.rdBtnPike_CheckedChanged);
            // 
            // rdBtnAllen
            // 
            this.rdBtnAllen.AutoSize = true;
            this.rdBtnAllen.Location = new System.Drawing.Point(52, 58);
            this.rdBtnAllen.Name = "rdBtnAllen";
            this.rdBtnAllen.Size = new System.Drawing.Size(97, 25);
            this.rdBtnAllen.TabIndex = 0;
            this.rdBtnAllen.TabStop = true;
            this.rdBtnAllen.Text = "Allen Hall";
            this.rdBtnAllen.UseVisualStyleBackColor = true;
            this.rdBtnAllen.CheckedChanged += new System.EventHandler(this.rdBtnAllen_CheckedChanged);
            // 
            // grpBxMeal
            // 
            this.grpBxMeal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpBxMeal.BackColor = System.Drawing.Color.White;
            this.grpBxMeal.Controls.Add(this.rdBtnMeals_Unlimited);
            this.grpBxMeal.Controls.Add(this.rdBtnMeals_14);
            this.grpBxMeal.Controls.Add(this.rdBtnMeals_7);
            this.grpBxMeal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBxMeal.Location = new System.Drawing.Point(565, 52);
            this.grpBxMeal.Name = "grpBxMeal";
            this.grpBxMeal.Size = new System.Drawing.Size(258, 220);
            this.grpBxMeal.TabIndex = 1;
            this.grpBxMeal.TabStop = false;
            this.grpBxMeal.Text = "Select a Meal Plan";
            this.toolTip1.SetToolTip(this.grpBxMeal, "Select your Meal plan");
            // 
            // rdBtnMeals_Unlimited
            // 
            this.rdBtnMeals_Unlimited.AutoSize = true;
            this.rdBtnMeals_Unlimited.Location = new System.Drawing.Point(46, 130);
            this.rdBtnMeals_Unlimited.Name = "rdBtnMeals_Unlimited";
            this.rdBtnMeals_Unlimited.Size = new System.Drawing.Size(146, 25);
            this.rdBtnMeals_Unlimited.TabIndex = 2;
            this.rdBtnMeals_Unlimited.TabStop = true;
            this.rdBtnMeals_Unlimited.Text = "Unlimited Meals";
            this.rdBtnMeals_Unlimited.UseVisualStyleBackColor = true;
            this.rdBtnMeals_Unlimited.CheckedChanged += new System.EventHandler(this.rdBtnMeals_Unlimited_CheckedChanged);
            // 
            // rdBtnMeals_14
            // 
            this.rdBtnMeals_14.AutoSize = true;
            this.rdBtnMeals_14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdBtnMeals_14.Location = new System.Drawing.Point(46, 99);
            this.rdBtnMeals_14.Name = "rdBtnMeals_14";
            this.rdBtnMeals_14.Size = new System.Drawing.Size(162, 25);
            this.rdBtnMeals_14.TabIndex = 1;
            this.rdBtnMeals_14.TabStop = true;
            this.rdBtnMeals_14.Text = "14 Meals Per Week";
            this.rdBtnMeals_14.UseVisualStyleBackColor = true;
            this.rdBtnMeals_14.CheckedChanged += new System.EventHandler(this.rdBtnMeals_14_CheckedChanged);
            // 
            // rdBtnMeals_7
            // 
            this.rdBtnMeals_7.AutoSize = true;
            this.rdBtnMeals_7.Location = new System.Drawing.Point(46, 68);
            this.rdBtnMeals_7.Name = "rdBtnMeals_7";
            this.rdBtnMeals_7.Size = new System.Drawing.Size(156, 25);
            this.rdBtnMeals_7.TabIndex = 0;
            this.rdBtnMeals_7.TabStop = true;
            this.rdBtnMeals_7.Text = "7 Meals Per Week";
            this.rdBtnMeals_7.UseVisualStyleBackColor = true;
            this.rdBtnMeals_7.CheckedChanged += new System.EventHandler(this.rdBtnMeals_7_CheckedChanged);
            // 
            // iconExt
            // 
            this.iconExt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconExt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.iconExt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconExt.FlatAppearance.BorderSize = 0;
            this.iconExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconExt.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconExt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconExt.ForeColor = System.Drawing.Color.White;
            this.iconExt.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconExt.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(73)))));
            this.iconExt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExt.IconSize = 30;
            this.iconExt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconExt.Location = new System.Drawing.Point(665, 436);
            this.iconExt.Name = "iconExt";
            this.iconExt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconExt.Rotation = 0D;
            this.iconExt.Size = new System.Drawing.Size(158, 50);
            this.iconExt.TabIndex = 4;
            this.iconExt.Text = "&Exit";
            this.iconExt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.iconExt, "Quick Exit");
            this.iconExt.UseVisualStyleBackColor = false;
            this.iconExt.Click += new System.EventHandler(this.iconExt_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnTotal.FlatAppearance.BorderSize = 0;
            this.btnTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotal.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.ForeColor = System.Drawing.Color.White;
            this.btnTotal.IconChar = FontAwesome.Sharp.IconChar.Calculator;
            this.btnTotal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(151)))), ((int)(((byte)(75)))));
            this.btnTotal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTotal.IconSize = 30;
            this.btnTotal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTotal.Location = new System.Drawing.Point(112, 23);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTotal.Rotation = 0D;
            this.btnTotal.Size = new System.Drawing.Size(158, 50);
            this.btnTotal.TabIndex = 0;
            this.btnTotal.Text = "Dis&play Total";
            this.btnTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnTotal, "Display the total");
            this.btnTotal.UseVisualStyleBackColor = false;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnClr
            // 
            this.btnClr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.btnClr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClr.FlatAppearance.BorderSize = 0;
            this.btnClr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClr.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnClr.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.ForeColor = System.Drawing.Color.White;
            this.btnClr.IconChar = FontAwesome.Sharp.IconChar.HandSparkles;
            this.btnClr.IconColor = System.Drawing.Color.White;
            this.btnClr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClr.IconSize = 30;
            this.btnClr.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClr.Location = new System.Drawing.Point(385, 436);
            this.btnClr.Name = "btnClr";
            this.btnClr.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnClr.Rotation = 0D;
            this.btnClr.Size = new System.Drawing.Size(158, 50);
            this.btnClr.TabIndex = 3;
            this.btnClr.Text = "&Clear";
            this.btnClr.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.btnClr, "Clear all the selections");
            this.btnClr.UseVisualStyleBackColor = false;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.btnTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 95);
            this.panel1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(948, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbout});
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(45, 22);
            this.btnHelp.Text = "Help";
            // 
            // btnAbout
            // 
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(180, 22);
            this.btnAbout.Text = "About";
            this.btnAbout.ToolTipText = "About this Application";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // PlanSelect
            // 
            this.AcceptButton = this.btnTotal;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.CancelButton = this.iconExt;
            this.ClientSize = new System.Drawing.Size(948, 508);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.iconExt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpBxMeal);
            this.Controls.Add(this.grpBoxDorms_Select);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlanSelect";
            this.Text = "PlanSelect";
            this.grpBoxDorms_Select.ResumeLayout(false);
            this.grpBoxDorms_Select.PerformLayout();
            this.grpBxMeal.ResumeLayout(false);
            this.grpBxMeal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxDorms_Select;
        private System.Windows.Forms.RadioButton rdBtnUniSuite;
        private System.Windows.Forms.RadioButton rdBtnFarthing;
        private System.Windows.Forms.RadioButton rdBtnPike;
        private System.Windows.Forms.RadioButton rdBtnAllen;
        private System.Windows.Forms.GroupBox grpBxMeal;
        private System.Windows.Forms.RadioButton rdBtnMeals_Unlimited;
        private System.Windows.Forms.RadioButton rdBtnMeals_14;
        private System.Windows.Forms.RadioButton rdBtnMeals_7;
        private FontAwesome.Sharp.IconButton iconExt;
        private FontAwesome.Sharp.IconButton btnTotal;
        private FontAwesome.Sharp.IconButton btnClr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnHelp;
        private System.Windows.Forms.ToolStripMenuItem btnAbout;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}