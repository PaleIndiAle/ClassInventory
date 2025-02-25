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
            string nameRemove = removeInput.Text;

            Player name = players.Find(n => n.name == removeInput.Text);

            if (name != null)
            {
                players.Remove(name);
                label1.Text = $"{nameRemove} is now removed";
            }
            else
            {
                label1.Text = "Couldn't find this player, sorry!";
            }

            //for (int i = 0; i < players.Count; i++)
            //{
            //    if (players[i].name == nameRemove)
            //    {
            //        label1.Text = $"{nameRemove} is now removed";
            //        players.RemoveAt(i);
            //        return;
            //    }
            //}

            //for (int i = 0; i < players.Count; i++)
            //{
            //    label1.Text = $"{players[i].name} - {players[i].age}, {players[i].team}, {players[i].position} \n";
            //}
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // This is to be completed in Part II. You will use 
            // Lambda Expressions. 
            //---------------------------
            string nameSearch = nameSearchInput.Text;

            Player name = players.Find(n => n.name == nameSearchInput.Text);

            if (name != null)
            {
                label1.Text = $"{name.name} - {name.age}, {name.team}, {name.position}";
            }

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
