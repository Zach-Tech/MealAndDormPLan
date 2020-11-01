namespace Zachary_Childers_CPT_185_Lab_9
{
    partial class PlanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlanForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAbt = new FontAwesome.Sharp.IconButton();
            this.btnPath = new FontAwesome.Sharp.IconButton();
            this.iconExpand = new FontAwesome.Sharp.IconPictureBox();
            this.iconMin = new FontAwesome.Sharp.IconPictureBox();
            this.iconExit = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.logoBtn = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblTitleChild = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pnlDsk = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBtn)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.pnlDsk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAbt
            // 
            this.btnAbt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAbt.FlatAppearance.BorderSize = 0;
            this.btnAbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbt.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAbt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbt.ForeColor = System.Drawing.Color.White;
            this.btnAbt.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnAbt.IconColor = System.Drawing.Color.White;
            this.btnAbt.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAbt.IconSize = 45;
            this.btnAbt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbt.Location = new System.Drawing.Point(0, 190);
            this.btnAbt.Name = "btnAbt";
            this.btnAbt.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAbt.Rotation = 0D;
            this.btnAbt.Size = new System.Drawing.Size(220, 50);
            this.btnAbt.TabIndex = 1;
            this.btnAbt.TabStop = false;
            this.btnAbt.Text = "About";
            this.btnAbt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnAbt, "About this Application");
            this.btnAbt.UseVisualStyleBackColor = true;
            this.btnAbt.Click += new System.EventHandler(this.btnAbt_Click);
            // 
            // btnPath
            // 
            this.btnPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPath.FlatAppearance.BorderSize = 0;
            this.btnPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPath.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPath.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.ForeColor = System.Drawing.Color.White;
            this.btnPath.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.btnPath.IconColor = System.Drawing.Color.White;
            this.btnPath.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPath.IconSize = 45;
            this.btnPath.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPath.Location = new System.Drawing.Point(0, 140);
            this.btnPath.Name = "btnPath";
            this.btnPath.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPath.Rotation = 0D;
            this.btnPath.Size = new System.Drawing.Size(220, 50);
            this.btnPath.TabIndex = 0;
            this.btnPath.TabStop = false;
            this.btnPath.Text = "Dorm / Meal Plan";
            this.btnPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnPath, "Calculate your Dorm and Meal plan for the year");
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // iconExpand
            // 
            this.iconExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.iconExpand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.iconExpand.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.iconExpand.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.iconExpand.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExpand.Location = new System.Drawing.Point(891, 3);
            this.iconExpand.Name = "iconExpand";
            this.iconExpand.Size = new System.Drawing.Size(34, 32);
            this.iconExpand.TabIndex = 7;
            this.iconExpand.TabStop = false;
            this.toolTip1.SetToolTip(this.iconExpand, "Maximize Window");
            this.iconExpand.Click += new System.EventHandler(this.iconExpand_Click);
            // 
            // iconMin
            // 
            this.iconMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.iconMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.iconMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconMin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.iconMin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconMin.Location = new System.Drawing.Point(851, 3);
            this.iconMin.Name = "iconMin";
            this.iconMin.Size = new System.Drawing.Size(34, 32);
            this.iconMin.TabIndex = 6;
            this.iconMin.TabStop = false;
            this.toolTip1.SetToolTip(this.iconMin, "Minimize to TaskBar");
            this.iconMin.Click += new System.EventHandler(this.iconMin_Click);
            // 
            // iconExit
            // 
            this.iconExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.iconExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.iconExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.iconExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.iconExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconExit.Location = new System.Drawing.Point(929, 3);
            this.iconExit.Name = "iconExit";
            this.iconExit.Size = new System.Drawing.Size(34, 32);
            this.iconExit.TabIndex = 5;
            this.iconExit.TabStop = false;
            this.toolTip1.SetToolTip(this.iconExit, "Exit Application");
            this.iconExit.Click += new System.EventHandler(this.iconExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 348);
            this.panel1.TabIndex = 8;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 35;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(20, 27);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(42, 35);
            this.iconCurrentChildForm.TabIndex = 2;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // logoBtn
            // 
            this.logoBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoBtn.Image")));
            this.logoBtn.Location = new System.Drawing.Point(30, 12);
            this.logoBtn.Name = "logoBtn";
            this.logoBtn.Size = new System.Drawing.Size(153, 122);
            this.logoBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBtn.TabIndex = 0;
            this.logoBtn.TabStop = false;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.logoBtn);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // lblTitleChild
            // 
            this.lblTitleChild.AutoSize = true;
            this.lblTitleChild.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChild.ForeColor = System.Drawing.Color.White;
            this.lblTitleChild.Location = new System.Drawing.Point(66, 35);
            this.lblTitleChild.Name = "lblTitleChild";
            this.lblTitleChild.Size = new System.Drawing.Size(50, 20);
            this.lblTitleChild.TabIndex = 1;
            this.lblTitleChild.Text = "Home";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 9);
            this.panel2.TabIndex = 3;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panelTitleBar.Controls.Add(this.iconExpand);
            this.panelTitleBar.Controls.Add(this.iconMin);
            this.panelTitleBar.Controls.Add(this.iconExit);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitleChild);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(964, 75);
            this.panelTitleBar.TabIndex = 0;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // pnlDsk
            // 
            this.pnlDsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(34)))));
            this.pnlDsk.Controls.Add(this.panel2);
            this.pnlDsk.Controls.Add(this.panelTitleBar);
            this.pnlDsk.Controls.Add(this.pictureBox1);
            this.pnlDsk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDsk.Location = new System.Drawing.Point(220, 0);
            this.pnlDsk.Name = "pnlDsk";
            this.pnlDsk.Size = new System.Drawing.Size(964, 631);
            this.pnlDsk.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 326);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.panelMenu.Controls.Add(this.btnAbt);
            this.panelMenu.Controls.Add(this.btnPath);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 631);
            this.panelMenu.TabIndex = 12;
            // 
            // PlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 631);
            this.Controls.Add(this.pnlDsk);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PlanForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.iconExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBtn)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.pnlDsk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private FontAwesome.Sharp.IconButton btnAbt;
        private FontAwesome.Sharp.IconButton btnPath;
        private FontAwesome.Sharp.IconPictureBox iconExpand;
        private FontAwesome.Sharp.IconPictureBox iconMin;
        private FontAwesome.Sharp.IconPictureBox iconExit;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.PictureBox logoBtn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblTitleChild;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel pnlDsk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMenu;
    }
}

