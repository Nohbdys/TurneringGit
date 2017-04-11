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
        #region Fields

        enum Menu : byte { mainMenu = 1, nyTurnMenu, tidligTurnMenu, spillerMenu, nySpillerMenu, infoSpillerMenu}

        Database database = new Database();

        #endregion
        Menu CurrentMenu = Menu.mainMenu;

        public Form1()
        {
            
            InitializeComponent();

            #region ButtonVisibility
            TidligTurn.Visible = true;
            Spiller.Visible = true;
            NyTurn.Visible = true;
            Exit.Visible = true;

            turnNavn.Visible = false;
            turnType.Visible = false;
            antalHold.Visible = false;
            sportsgren.Visible = false;
            startDate.Visible = false;
            endDate.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;

            spillerNy.Visible = false; // Done
            spillerInfo.Visible = false; // Done
            spillerTilbage.Visible = false; // Done
            tidligTurnTilbage.Visible = false; // Done
            nyTurnTilbage.Visible = false; // Done  
            listBox1.Visible = false; //Done
            #endregion
            BackColor = Color.Green;
        }


        #region Methods
        private void button1_Click(object sender, EventArgs e)
        {
            //Spiller
            spillerNy.Visible = true;
            spillerInfo.Visible = true;
            spillerTilbage.Visible = true;

            TidligTurn.Visible = false;
            Spiller.Visible = false;
            NyTurn.Visible = false;
            Exit.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Tidligere Turnering
            TidligTurn.Visible = false;
            Spiller.Visible = false;
            NyTurn.Visible = false;
            Exit.Visible = false;

            tidligTurnTilbage.Visible = true;
            listBox1.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkGreen;

            // Ny Turnering
            TidligTurn.Visible = false;
            Spiller.Visible = false;
            NyTurn.Visible = false;
            Exit.Visible = false;

            nyTurnTilbage.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;

            turnNavn.Visible = true;
            turnType.Visible = true;
            antalHold.Visible = true;
            sportsgren.Visible = true;
            startDate.Visible = true;
            endDate.Visible = true;
            label7.Visible = true;
            label8.Visible = true;


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

            nyTurnTilbage.Visible = false;


            TidligTurn.Visible = true;
            Spiller.Visible = true;
            NyTurn.Visible = true;
            Exit.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;

            textBox9.Visible = false; // bleh

            turnNavn.Visible = false;
            turnType.Visible = false;
            antalHold.Visible = false;
            sportsgren.Visible = false;
            startDate.Visible = false;
            endDate.Visible = false;
            label7.Visible = false;
            label8.Visible = false;

        }

        private void tidligTurnTilbage_Click(object sender, EventArgs e)
        {
            tidligTurnTilbage.Visible = false;
            listBox1.Visible = false;

            TidligTurn.Visible = true;
            Spiller.Visible = true;
            NyTurn.Visible = true;
            Exit.Visible = true;

        }

        private void spillerTilbage_Click(object sender, EventArgs e)
        {
            spillerNy.Visible = false;
            spillerInfo.Visible = false;
            spillerTilbage.Visible = false;

            TidligTurn.Visible = true;
            Spiller.Visible = true;
            NyTurn.Visible = true;
            Exit.Visible = true;

        }

        private void nySpiller_Click(object sender, EventArgs e)
        {


        }

        private void spillerInfo_Click(object sender, EventArgs e)
        {


        }

#endregion


        private void whatever()
        {

            //rnd(0, B);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


            private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && textBox9.Visible == true)
            {

                

            }
        }
    
    }
}
