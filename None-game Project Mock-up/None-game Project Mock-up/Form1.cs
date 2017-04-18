using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Data.SQLite;

namespace None_game_Project_Mock_up
{
    public partial class Form1 : Form
    {

        #region Fields
        enum Menu : byte { mainMenu = 1, nyTurnMenu, tidligTurnMenu, holdMenu, nyholdMenu, infoholdMenu }

        Database database = new Database();


        List<Hold> holdList = new List<Hold>();
        bool addHold = false;

        string curItem;
        string textbox9;
        string textbox10;
        string textbox11;
        string textbox12;

        bool holdAdd = false;
        bool holdRead = false;
        #endregion

        Menu CurrentMenu = Menu.mainMenu;

        public Form1()
        {

            InitializeComponent();


            BackColor = Color.Green;
        }


        #region Methods
        private void button1_Click(object sender, EventArgs e)
        {
            CurrentMenu = Menu.holdMenu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrentMenu = Menu.tidligTurnMenu;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrentMenu = Menu.nyTurnMenu;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            curItem = listBox1.SelectedItem.ToString();

            holdRead = true;

            holdMethod();


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

        private void spillerTilbage_Click(object sender, EventArgs e)
        {
            if (CurrentMenu == Menu.tidligTurnMenu)
            {
                CurrentMenu = Menu.mainMenu;
            }

            if (CurrentMenu == Menu.holdMenu)
            {
                CurrentMenu = Menu.mainMenu;
            }

            if (CurrentMenu == Menu.nyTurnMenu)
            {
                CurrentMenu = Menu.mainMenu;
            }
        }

        private void nySpiller_Click(object sender, EventArgs e)
        {


        }

        private void spillerInfo_Click(object sender, EventArgs e)
        {


        }

        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && textBox9.Visible == true)
            {



            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region MainMenu
            if (CurrentMenu == Menu.mainMenu)
            {
                TidligTurn.Visible = true;
                hold.Visible = true;
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

                holdNy.Visible = false; // Done
                holdInfo.Visible = false; // Done
                tilbage.Visible = false; // Done 
                listBox1.Visible = false; //Done

            }
            #endregion

            #region InfoSpillerMenu
            if (CurrentMenu == Menu.infoholdMenu)
            {

            }
            #endregion

            #region NySpillerMenu 
            if (CurrentMenu == Menu.nyholdMenu)
            {

            }
            #endregion

            #region NyTurneringMenu
            if (CurrentMenu == Menu.nyTurnMenu)
            {
                TidligTurn.Visible = false;
                hold.Visible = false;
                NyTurn.Visible = false;
                Exit.Visible = false;
                tilbage.Visible = true;

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
            #endregion

            #region SpillerMenu
            if (CurrentMenu == Menu.holdMenu)
            {
                holdNy.Visible = true;
                holdInfo.Visible = true;
                tilbage.Visible = true;

                TidligTurn.Visible = false;
                hold.Visible = false;
                NyTurn.Visible = false;
                Exit.Visible = false;
            }
            #endregion

            #region TidligereTurneringMenu
            if (CurrentMenu == Menu.tidligTurnMenu)
            {
                TidligTurn.Visible = false;
                hold.Visible = false;
                NyTurn.Visible = false;
                Exit.Visible = false;
                tilbage.Visible = true;

                listBox1.Visible = true;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                lossLabel.Visible = true;
                winLabel.Visible = true;
                antalSpillerLabel.Visible = true;
                holdNavnLabel.Visible = true;

                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
            }
            #endregion
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

            /*
            KeyEventArgs key = new KeyEventArgs(keyData);
            if (key.Control && key.KeyCode == Keys.Enter)
            {
                BackColor = Color.Blue;
            }
            */

        }

        private void AddTeam_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int count = 0;

            addHold = true;
            if (addHold && textBox9.TextLength > 0 && textBox10.TextLength > 0 && textBox11.TextLength > 0 && textBox12.TextLength > 0)
            {


                textbox9 = textBox9.Text;
                textbox10 = textBox10.Text;
                textbox11 = textBox11.Text;
                textbox12 = textBox12.Text;

                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();

                holdAdd = true;
                holdMethod();

                addHold = false;


            }



            foreach (Hold hold in holdList)
            {

                count++;
                if (holdList.Count >= count)
                {
                    listBox1.Items.Add(hold.HoldNavn);

                }

            }
        }
        private void holdMethod()
        {



            if (holdAdd)
            {

                holdList.Add(new Hold(textbox9, "", textbox11, textbox12, "", "", "", "fodbold", textbox10, ""));
        
                holdAdd = false;

            }
            if (holdRead)
            {
                foreach (Hold hold in holdList)
                {
                    if (hold.HoldNavn.Equals(curItem))
                    {
                        label1.Text = (hold.HoldNavn).ToString();
                        label2.Text = (hold.PlayerAmount).ToString();
                        label3.Text = (hold.Win).ToString();
                        label4.Text = (hold.Loss).ToString();
                    }      
                }
                holdRead = false;
            }
        }
    }
}
