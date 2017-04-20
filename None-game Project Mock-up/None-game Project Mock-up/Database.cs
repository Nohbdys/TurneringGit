using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace None_game_Project_Mock_up
{
    class Database
    {
        SQLiteConnection dbConn = new SQLiteConnection("Data Source=data.db;Version=3;");

        public void databaseSetup()
        {//insert into hold values (null,  'hold 1', 1, 1, 0, 0, 0, 0, 0);

            dbConn.Open();
            //string sql = "drop table hold";
            string sql = "create table if not exists hold (hold_id integer primary key, name text, division int, matchAmount int, playerAmount int, win int, loss int, draw int, goal int, wonTourn int);create table if not exists turneringer ( turn_id integer primary key, name text, teamAmount int, startDate text, endDate text, sportType text, tournType int); create table if not exists tmp_hold ( tmp_id integer primary key, name int, matchAmount int , win int , loss int, draw int, point int, goal int, turnid int, FOREIGN KEY(turnid) REFERENCES turneringer(turn_id))";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);
            SQLiteDataReader reader = command.ExecuteReader();


            dbConn.Close();
        }
        public void databaseTurnSave()
        {
            dbConn.Open();


            dbConn.Close();
        }
    }
}
