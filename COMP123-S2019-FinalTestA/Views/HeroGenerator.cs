using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

/*
 * STUDENT NAME: shiwangi jaura
 * STUDENT ID: 301044130
 * DESCRIPTION: This is the Here Generator Form
 */

namespace COMP123_S2019_FinalTestA.Views
{
    public partial class HeroGenerator : COMP123_S2019_FinalTestA.Views.MasterForm
    {
        public HeroGenerator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is the event handler for the BackButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            if (MainTabControl.SelectedIndex != 0)
            {
                MainTabControl.SelectedIndex--;
            }
        }

        /// <summary>
        /// This is the event handler for the NextButton Click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextButton_Click(object sender, EventArgs e)
        {
            if(MainTabControl.SelectedIndex < MainTabControl.TabPages.Count - 1)
            {
                MainTabControl.SelectedIndex++;
            }
        }

        

        private void GenerateAbilitiesButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            FightingDataLabel.Text = (rand.Next(1, 15)).ToString();
            AgilityDataLabel.Text = (rand.Next(1, 15)).ToString();
            StrengthDataLabel.Text = (rand.Next(1, 15)).ToString();
            EnduranceDataLabel.Text = (rand.Next(1, 15)).ToString();
            ReasonDataLabel.Text = (rand.Next(1, 15)).ToString();
            IntuitionDataLabel.Text = (rand.Next(1, 15)).ToString();
            PsycheDataLabel.Text = (rand.Next(1, 15)).ToString();
            PopularityDataLabel.Text = (rand.Next(1, 15)).ToString();
        }

        private void GenerateNameButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void HeroGenerator_Load(object sender, EventArgs e)
        {

        }
        public void loadNames()
        {
            //creates firstname list
            var firstName = File.ReadAllLines("firstNames.txt");
            var firstNameList = new List<string>(firstName);

            //creates lastname list
            var lastName = File.ReadAllLines("lastNames.txt");
            var lasttNameList = new List<string>(lastName);
        }

        public void loadPowers()
        {
            //creates powers list
            var power = File.ReadAllLines("powers.txt");
            var PowersList = new List<string>(power);
        }

        public void GenerateNames()
        {

            var firstName = File.ReadAllLines("firstNames.txt");
            var firstNameList = new List<string>(firstName);
            Random rand = new Random();
            int index = rand.Next(firstNameList.Count);
            FirstNameDataLabel.Text = firstNameList[index];

            var lastName = File.ReadAllLines("lasttNames.txt");
            var lastNameList = new List<string>(lastName);
            Random random = new Random();
            int indexs = random.Next(lastNameList.Count);
            LastNameDataLabel.Text = lastNameList[indexs];
        }

        private void GeneratePowerButton_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            DataLabel2.Text = (rand.Next(1, 15)).ToString();
            DataLabel2.Text = (rand.Next(1, 15)).ToString();
            DataLabel3.Text = (rand.Next(1, 15)).ToString();
            DataLabel4.Text = (rand.Next(1, 15)).ToString();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
