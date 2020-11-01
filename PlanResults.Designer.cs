namespace Zachary_Childers_CPT_185_Lab_9
{
    partial class PlanResults
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanResults));
            this.iconExtRslt = new FontAwesome.Sharp.IconButton();
            this.label = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.RichTextBox();
            this.txtDormOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMealOutput = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.abtBtn = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconExtRslt
            // 
            this.iconExtRslt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.iconExtRslt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.iconExtRslt.FlatAppearance.BorderSize = 0;
            this.iconExtRslt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconExtRslt.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconExtRslt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconExtRslt.ForeColor = System.Drawing.Color.White;
            this.iconExtRslt.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconExtRslt.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(75)))), ((int)(((byte)(73)))));
            this.iconExtRslt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExtRslt.IconSize = 30;
            this.iconExtRslt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconExtRslt.Location = new System.Drawing.Point(804, 21);
            this.iconExtRslt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconExtRslt.Name = "iconExtRslt";
            this.iconExtRslt.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.iconExtRslt.Rotation = 0D;
            this.iconExtRslt.Size = new System.Drawing.Size(131, 57);
            this.iconExtRslt.TabIndex = 1;
            this.iconExtRslt.Text = "&Exit";
            this.iconExtRslt.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.toolTip1.SetToolTip(this.iconExtRslt, "Exit to Home");
            this.iconExtRslt.UseVisualStyleBackColor = true;
            this.iconExtRslt.Click += new System.EventHandler(this.iconExt_Click);
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(25, 24);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(52, 20);
            this.label.TabIndex = 30;
            this.label.Text = "Totals:";
            // 
            // totalOutput
            // 
            this.totalOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalOutput.BackColor = System.Drawing.Color.White;
            this.totalOutput.Location = new System.Drawing.Point(79, 10);
            this.totalOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.ReadOnly = true;
            this.totalOutput.Size = new System.Drawing.Size(187, 46);
            this.totalOutput.TabIndex = 31;
            this.totalOutput.TabStop = false;
            this.totalOutput.Text = "";
            this.toolTip1.SetToolTip(this.totalOutput, "Total = Meals + Dorms charge");
            // 
            // txtDormOutput
            // 
            this.txtDormOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDormOutput.BackColor = System.Drawing.Color.White;
            this.txtDormOutput.Location = new System.Drawing.Point(412, 245);
            this.txtDormOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDormOutput.Name = "txtDormOutput";
            this.txtDormOutput.ReadOnly = true;
            this.txtDormOutput.Size = new System.Drawing.Size(187, 46);
            this.txtDormOutput.TabIndex = 33;
            this.txtDormOutput.TabStop = false;
            this.txtDormOutput.Text = "";
            this.toolTip1.SetToolTip(this.txtDormOutput, "Cost of Dorm Plan");
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(299, 259);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Dorm Charges:";
            // 
            // txtMealOutput
            // 
            this.txtMealOutput.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMealOutput.BackColor = System.Drawing.Color.White;
            this.txtMealOutput.Location = new System.Drawing.Point(412, 165);
            this.txtMealOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMealOutput.Name = "txtMealOutput";
            this.txtMealOutput.ReadOnly = true;
            this.txtMealOutput.Size = new System.Drawing.Size(187, 46);
            this.txtMealOutput.TabIndex = 35;
            this.txtMealOutput.TabStop = false;
            this.txtMealOutput.Text = "";
            this.toolTip1.SetToolTip(this.txtMealOutput, "Cost of Meal Plan");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(299, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "Meal Charges:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(130)))), ((int)(((byte)(196)))));
            this.panel1.Controls.Add(this.totalOutput);
            this.panel1.Controls.Add(this.label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 75);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(46)))));
            this.panel2.Controls.Add(this.abtBtn);
            this.panel2.Controls.Add(this.iconExtRslt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 99);
            this.panel2.TabIndex = 0;
            // 
            // abtBtn
            // 
            this.abtBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.abtBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.abtBtn.FlatAppearance.BorderSize = 0;
            this.abtBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.abtBtn.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.abtBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abtBtn.ForeColor = System.Drawing.Color.White;
            this.abtBtn.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.abtBtn.IconColor = System.Drawing.Color.White;
            this.abtBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.abtBtn.IconSize = 30;
            this.abtBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.abtBtn.Location = new System.Drawing.Point(13, 21);
            this.abtBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.abtBtn.Name = "abtBtn";
            this.abtBtn.Padding = new System.Windows.Forms.Padding(15, 0, 30, 0);
            this.abtBtn.Rotation = 0D;
            this.abtBtn.Size = new System.Drawing.Size(176, 57);
            this.abtBtn.TabIndex = 0;
            this.abtBtn.Text = "&Go to About";
            this.abtBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.abtBtn, "About this Application");
            this.abtBtn.UseVisualStyleBackColor = true;
            this.abtBtn.Click += new System.EventHandler(this.abtBtn_Click);
            // 
            // PlanResults
            // 
            this.AcceptButton = this.abtBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.CancelButton = this.iconExtRslt;
            this.ClientSize = new System.Drawing.Size(948, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMealOutput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDormOutput);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PlanResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rooming Plan Total";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconExtRslt;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.RichTextBox totalOutput;
        private System.Windows.Forms.RichTextBox txtDormOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtMealOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton abtBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}