using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace None_game_Project_Mock_up
{
    public partial class Form1 : Form
    {
        Database database = new Database();
        public Form1()
        {
            InitializeComponent();
            TidligTurn.Visible = true;
            Spiller.Visible = false;
            NyTurn.Visible = false;
            Exit.Visible = true;
            nySpiller.Visible = false;
            spillerInfo.Visible = false;
            spillerTilbage.Visible = false;
            tidligTurnTilbage.Visible = false;
            nyTurnTilbage.Visible = true;
            listBox1.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Spiller
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Tidligere Turnering
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Ny Turnering
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Opret tabeller / databasser
            database.databaseRun();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //Exit 
            Environment.Exit(0);
        }

        private void nyTurnTilbage_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;
        }

        private void tidligTurnTilbage_Click(object sender, EventArgs e)
        {

        }

        private void spillerTilbage_Click(object sender, EventArgs e)
        {

        }

        private void nySpiller_Click(object sender, EventArgs e)
        {

        }

        private void spillerInfo_Click(object sender, EventArgs e)
        {

        }
        private void whatever()
        {
            //rnd(0, B);
        }
    }
}
