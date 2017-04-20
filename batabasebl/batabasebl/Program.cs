using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace batabasebl
{
    class Program
    {
     
        static void Main(string[] args)
        {
            /*
create table hold (hold_id integer primary key, name text, division int, matchAmount int, win int, loss int, draw int, goal int, wonTourn int, );
create table turneringer ( turn_id integer primary key, name text, teamAmount int, startDate text, endDate text, sportType text, tournType int);
create table tmp_hold ( tmp_id integer primary key, name int, matchAmount int , win int , loss int, draw int, point int, goal int, turnid int, FOREIGN KEY(turnid) REFERENCES turneringer(turn_id));

insert into turneringer values (null, "First Tournament", 4, "20/4/2017","20/5/2017","football", 2);
insert into hold values (null,  "hold 3", 1, 0, 0, 0, 0, 0);
insert into tmp_hold values(null, "hold 3", 0,0,0,0,0,0,1);

select * from turneringer;
select * from tmp_hold order by turnid,point,name;
select * from hold order by name;

update hold set matchAmount = 0 where hold_id = 2;
update hold set matchAmount = 1 where name = "hold 2";
update tmp_hold set matchAmount = 1 where name = "hold 2"
*/

            SQLiteConnection dbConn = new SQLiteConnection("Data Source=data.db;Version=3;");

            dbConn.Open();
            string sql = "create table if not exists hold (hold_id integer primary key, name text, division int, matchAmount int, win int, loss int, draw int, goal int, wonTourn int);";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);
            SQLiteDataReader reader = command.ExecuteReader();


            sql = "insert into hold values (null, 'hold 1', 1, 1, 0, 0, 0, 0, 0);";
            command = new SQLiteCommand(sql, dbConn);
            reader = command.ExecuteReader();
            sql = "insert into hold values (null, 'hold 2', 1, 1, 0, 0, 0, 0, 0);";
            command = new SQLiteCommand(sql, dbConn);
            reader = command.ExecuteReader();
            sql = "insert into hold values (null, 'hold 3', 1, 1, 0, 0, 0, 0, 0);";
            command = new SQLiteCommand(sql, dbConn);

            reader = command.ExecuteReader();

            sql = "update hold set win = 1 where name = 'hold 1';";
            command = new SQLiteCommand(sql, dbConn);
            reader = command.ExecuteReader();
             
            sql = "DELETE FROM hold WHERE name in ( SELECT name FROM hold  WHERE name = 'hold 1');";
            command = new SQLiteCommand(sql, dbConn);
            reader = command.ExecuteReader();

            sql = "select * from hold order by name";
            command = new SQLiteCommand(sql, dbConn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("Navn: " + reader["name"] + "\tPoint: " +
                reader["win"] + "\tID: " +
                reader["hold_id"]);
            }

            dbConn.Close();


            Console.ReadKey();
        }
        }
}
