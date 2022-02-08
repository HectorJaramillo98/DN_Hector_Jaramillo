using GymManager.Core.AttendanceReport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManager.DataAccess
{
    public class ProcedureReport
    {
        const string mysqlConnectionString = "server=localhost;port=3306;database=gymmanagerbeta;user=root;password=dulce664;CharSet=utf8;SslMode=none;Pooling=false;AllowPublicKeyRetrieval=true";
           public List<CheckSQL> MostCheckMembers = new List<CheckSQL>();

        public List<WeekChecks> LastWeekMemberCheck = new List<WeekChecks>();
        public List<CheckSQL> MemberChecks()
        {
            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);
            connection.Open();
            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("MostAsistence", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                var reader = command.ExecuteReader();


                while (reader.Read())
                {
                    Int64 tempChecks = ((Int64)reader["ChecksAsistence"]);
                    var tempChecks2 = (int)tempChecks;

                    
                    CheckSQL memberChecks = new CheckSQL
                    {
                        MemberName = reader["Name"] as string,
                        MemberLastName = reader["LastName"] as string,
                        Checks = tempChecks2

                    };

                    MostCheckMembers.Add(memberChecks);
                }
            }
            finally
            {
                connection.Close();
            }

            return MostCheckMembers;
        }

        public List<WeekChecks> LastWeekChecks()
        {
            MySqlConnector.MySqlConnection connection = new MySqlConnector.MySqlConnection(mysqlConnectionString);
            connection.Open();
            try
            {
                MySqlConnector.MySqlCommand command = new MySqlConnector.MySqlCommand("LastWeekCheck", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                var reader = command.ExecuteReader();


                while (reader.Read())
                {
                    Int64 tempChecks = ((Int64)reader["Count"]);
                    var tempChecks2 = (int)tempChecks;


                    WeekChecks week = new WeekChecks
                    {
                        DateDay = reader["Date"] as string,
                        CountChecks = tempChecks2

                    };

                    LastWeekMemberCheck.Add(week);
                }
            }
            finally
            {
                connection.Close();
            }

            return LastWeekMemberCheck;
        }
    }
}

