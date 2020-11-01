//Zachary Childers
//CPT-185-A01S
//Spartanburg Community College
//Lab 9 (10-6)
using System;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;

namespace Zachary_Childers_CPT_185_Lab_9
{
    public partial class PlanForm : Form
    {
        
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public PlanForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //borderless form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private struct RGBColors //Setting variables for my determined RGBs
        {
            public static Color colorA = Color.FromArgb(172, 126, 241);
            public static Color colorB = Color.FromArgb(249, 118, 176);
            public static Color colorC = Color.FromArgb(253, 138, 114);
            public static Color colorD = Color.FromArgb(95, 77, 221);
            public static Color colorE = Color.FromArgb(249, 88, 155);
            public static Color colorF = Color.FromArgb(24, 161, 251);
            public static Color colorG = Color.FromArgb(26, 250, 197);
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(32, 34, 37);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(43, 45, 49);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }


        private void btnPath_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorB);
            OpenChildForm(new PlanSelect());
            lblTitleChild.Text = "Welcome to All Incoming Students!";

        }

        private void btnAbt_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.colorF);
            OpenChildForm(new PlanMiniAbout());
            lblTitleChild.Text = "About This Application: ";
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDsk.Controls.Add(childForm);
            pnlDsk.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChild.Text = childForm.Text;
        }
        //Having to hand code
        //this stuff is hard, very time
        //consuming
        //but very rewarding
        //->
        //I've managed to pull together
        //Something I'm mostly satisfied with.
        private void logoBtn_Click_1(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            { currentChildForm.Close(); }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblTitleChild.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        //imports for draggable panel
        //due to my removal of the title bar,
        //need a work-around
        //that is why in part this is so difficult
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconExpand_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }

    }
}
