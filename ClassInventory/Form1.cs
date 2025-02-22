using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // Global Variabales go here
        List<Player> players = new List<Player>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text;
            int age = Convert.ToInt32(ageInput.Text);
            string team = teamInput.Text;
            string position = positionInput.Text;

            Player newPlayer = new Player(name, age, team, position);
            players.Add(newPlayer);

            nameInput.Text = ageInput.Text = teamInput.Text = positionInput.Text = "";
            nameInput.Focus();

            label1.Text = "";

            for (int i = 0; i < players.Count; i++)
            {
                label1.Text += $"{players[i].name} - {players[i].age}, {players[i].team}, {players[i].position} \n";
            }
        }
            
        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions. 
            //---------------------------

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            for (int i = 0; i < players.Count; i++)
            {
                label1.Text += $"{players[i].name} - {players[i].age}, {players[i].team}, {players[i].position} \n";
            }
        }
    }
}
