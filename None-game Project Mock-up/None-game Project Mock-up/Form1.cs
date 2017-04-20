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
        enum MenuState : byte { mainMenu = 1, nyTurnMenu, tidligTurnMenu, holdMenu, nyholdMenu, infoholdMenu }

        Database database = new Database();
        SQLiteConnection dbConn = new SQLiteConnection("Data Source=data.db;Version=3;");

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

        MenuState CurrentMenu = MenuState.mainMenu;

        public Form1()
        {

            InitializeComponent();


            BackColor = Color.Green;
        }


        #region Methods
        private void button1_Click(object sender, EventArgs e)
        {
            CurrentMenu = MenuState.holdMenu;

            dbConn.Open();
            string sql = "select * from hold order by name,hold_id";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);
            SQLiteDataReader reader = command.ExecuteReader();
            //  reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader["name"]);
            }
            dbConn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrentMenu = MenuState.tidligTurnMenu;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CurrentMenu = MenuState.nyTurnMenu;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            if (listBox1.SelectedItem != null)
            {
                curItem = listBox1.SelectedItem.ToString();

            }

            holdRead = true;

            holdMethod();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Opret tabeller / databasser
            
            database.databaseSetup();
            dbConn.Open();
            //string sql = "drop table hold";
            string sql = "Select * from hold order by name";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                holdList.Add(new Hold(""+ reader["name"]+"", "" + reader["goal"] + "", "" + reader["win"] + "", "" + reader["loss"] + "", "" + reader["draw"] + "", "" + reader["matchAmount"] + "", "" + reader["wonTourn"] + "", "" + reader["playerAmount"] + "", "" + reader["division"] + ""));
            }
            dbConn.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            //Exit 
            Environment.Exit(0);
        }

        private void spillerTilbage_Click(object sender, EventArgs e)
        {
            if (CurrentMenu == MenuState.tidligTurnMenu)
            {
                CurrentMenu = MenuState.mainMenu;
            }

            if (CurrentMenu == MenuState.holdMenu)
            {
                CurrentMenu = MenuState.mainMenu;
            }
            if (CurrentMenu == MenuState.nyholdMenu)
            {
                CurrentMenu = MenuState.holdMenu;
            }

            if (CurrentMenu == MenuState.nyTurnMenu)
            {
                CurrentMenu = MenuState.mainMenu;
            }
            if (CurrentMenu == MenuState.infoholdMenu)
            {
                CurrentMenu = MenuState.holdMenu;
            }

        }

        private void nySpiller_Click(object sender, EventArgs e)
        {
            CurrentMenu = MenuState.nyholdMenu;

        }

        private void spillerInfo_Click(object sender, EventArgs e)
        {
            CurrentMenu = MenuState.infoholdMenu;

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
            if (CurrentMenu == MenuState.mainMenu)
            {
                TidligTurn.Visible = true;
                hold.Visible = true;
                NyTurn.Visible = true;
                Exit.Visible = true;

                chart1.Visible = false;
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
                listBox2.Visible = false;

                holdNy.Visible = false; // Done
                holdInfo.Visible = false; // Done
                tilbage.Visible = false; // Done 
                listBox1.Visible = false; //Done

            }
            #endregion

            #region InfoHoldMenu
            if (CurrentMenu == MenuState.infoholdMenu)
            {

                TidligTurn.Visible = false;
                hold.Visible = false;
                NyTurn.Visible = false;
                holdNy.Visible = false;
                holdInfo.Visible = false;
                tilbage.Visible = true;

                listBox1.Visible = true;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;

                chart1.Visible = true;

            }
            #endregion

            #region NyHoldMenu 
            if (CurrentMenu == MenuState.nyholdMenu)
            {
                lossLabel.Visible = true;
                winLabel.Visible = true;
                antalSpillerLabel.Visible = true;
                holdNavnLabel.Visible = true;

                holdNy.Visible = false;
                holdInfo.Visible = false;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                AddTeam.Visible = true;
                listBox1.Visible = true;
            }
            #endregion

            #region NyTurneringMenu
            if (CurrentMenu == MenuState.nyTurnMenu)
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
                listBox2.Visible = true;
            }
            #endregion

            #region HoldMenu
            if (CurrentMenu == MenuState.holdMenu)
            {
                holdNy.Visible = true;
                holdInfo.Visible = true;
                tilbage.Visible = true;

                chart1.Visible = false;
                TidligTurn.Visible = false;
                hold.Visible = false;
                NyTurn.Visible = false;
                Exit.Visible = false;

                lossLabel.Visible = false;
                winLabel.Visible = false;
                antalSpillerLabel.Visible = false;
                holdNavnLabel.Visible = false;

                textBox9.Visible = false;
                textBox10.Visible = false;
                textBox11.Visible = false;
                textBox12.Visible = false;
                AddTeam.Visible = false;
                listBox1.Visible = false;

                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;


            }
            #endregion

            #region TidligereTurneringMenu
            if (CurrentMenu == MenuState.tidligTurnMenu)
            {
                TidligTurn.Visible = false;
                hold.Visible = false;
                NyTurn.Visible = false;
                Exit.Visible = false;
                tilbage.Visible = true;

                listBox2.Visible = true;


            }
            #endregion
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddTeam_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int count = 0;

            addHold = true;
            if (addHold && textBox9.TextLength > 0 && textBox10.TextLength > 0 && textBox11.TextLength > 0 && textBox12.TextLength > 0)
            {
                
                //textBox1 = textBox1.Text;
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

                
                if (holdList.Count > count)
                {

                    dbConn.Open();
                    string sql = "select * from hold order by name,hold_id";
                    SQLiteCommand command = new SQLiteCommand(sql, dbConn);
                    SQLiteDataReader reader = command.ExecuteReader();
                    //  reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        count++;
                        listBox1.Items.Add(reader["name"]);
                    }

                    dbConn.Close();


                }

            }
        }
        private void holdMethod()
        {

            if (holdAdd)
            {


                dbConn.Open();
                string sql = "insert into hold values (null, '" + textbox9 + "'," + textbox10 + ", 1, 1, " + textbox11 + "," + textbox12 + ", 0, 0, 0);";
                SQLiteCommand command = new SQLiteCommand(sql, dbConn);
                SQLiteDataReader reader = command.ExecuteReader();
                dbConn.Close();

                holdList.Add(new Hold(textbox9, "", textbox11, textbox12, "", "", "", textbox10, ""));


                holdAdd = false;

            }
            if (holdRead)
            {
                foreach (Hold hold in holdList)
                {
                    if (hold.HoldNavn.Equals(curItem))
                    {

                        dbConn.Open();
                        string sql = "select * from hold where name ='"+curItem+"' order by name";
                        SQLiteCommand command = new SQLiteCommand(sql, dbConn);
                        SQLiteDataReader reader = command.ExecuteReader();
                      //  reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            label1.Text = (reader["name"]).ToString();
                            label2.Text = (reader["playerAmount"]).ToString();
                            label3.Text = (reader["win"]).ToString();
                            label4.Text = (reader["loss"]).ToString();
                        }

                        dbConn.Close();
                    }
                }
                holdRead = false;
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
