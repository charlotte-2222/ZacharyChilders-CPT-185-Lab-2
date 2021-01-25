//Zachary Childers 
//CPT-185-A01S
//Lab-2

using System;
using System.Windows.Forms;

namespace ZacharyChilders_CPT_185_Lab_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picBack1_Click(object sender, EventArgs e)
        {
            picFace1.Visible = true;
            picBack1.Visible = false;
            btnFn.Text = "Your card is the 8 of Diamonds";
        }

        private void ext_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for playing, come back any time!");
            Close();
        }

        private void picBack2_Click(object sender, EventArgs e)
        {
            picFace2.Visible = true;
            picBack2.Visible = false;
            btnFn.Text = "Your card is the 2 of Clubs";
        }

        private void picBack3_Click(object sender, EventArgs e)
        {
            picFace3.Visible = true;
            picBack3.Visible = false;
            btnFn.Text = "Your card is the King of Clubs";
        }

        private void picBack4_Click(object sender, EventArgs e)
        {
            picFace4.Visible = true;
            picBack4.Visible = false;
            btnFn.Text = "Your card is the Ace of Spades";
        }

        private void picBack5_Click(object sender, EventArgs e)
        {
            picFace5.Visible = true;
            picBack5.Visible = false;
            btnFn.Text = "Your card is the Joker";
        }

        private void clr_Click(object sender, EventArgs e)
        {
            btnFn.Text = " ";
            picBack1.Visible = true;
            picBack2.Visible = true;
            picBack3.Visible = true;
            picBack4.Visible = true;
            picBack5.Visible = true;


        }

        private void picFace1_Click(object sender, EventArgs e)
        {
            btnFn.Text = " ";
            picBack1.Visible = true;
            picFace1.Visible = false;
            //flip over card

        }

        private void picFace2_Click(object sender, EventArgs e)
        {
            btnFn.Text = " ";
            picBack2.Visible = true;
            picFace2.Visible = false;
            //flip over card
        }

        private void picFace3_Click(object sender, EventArgs e)
        {
            btnFn.Text = " ";
            picBack3.Visible = true;
            picFace3.Visible = false;
            //flip over card
        }

        private void picFace4_Click(object sender, EventArgs e)
        {
            btnFn.Text = " ";
            picBack4.Visible = true;
            picFace4.Visible = false;
            //flip over card
        }

        private void picFace5_Click(object sender, EventArgs e)
        {
            btnFn.Text = " ";
            picBack5.Visible = true;
            picFace5.Visible = false;
            //flip over card
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void abt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a C# Learning Project, as part of Spartanburg Community College's Programming Course. Thank you for being part of my learning process!");
        }

       
    }
}
