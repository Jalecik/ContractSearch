using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractSearchApp
{
    class Controller
    {
        private string _selectQuery = "SELECT  [Sxs_Ad],[Sxs_Soyad],[Pass_SexsiKod],[Elq_Tel],[Elq_Mail],[Elq_Unvan1],[PayedStatus],[PayedMoney], [Payed_Date], [Oracle_ID],[Pass_Nomre],[Pass_SexsiKod] FROM [EimzaRegisters].[dbo].[Users] where [{0}]='{1}'";
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.EimzaRegisterConnectionString);
        SqlDataReader reader;
        public void Connect()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }
        public List<EimzaUsers> GetDataByContractNumber(int contractNumber)
        {
            return GetDataBySearchElement(string.Format(_selectQuery, "Oracle_ID", contractNumber)); 
        }

        public List<EimzaUsers> GetDataByFIN(string fin)
        {
            return GetDataBySearchElement(string.Format(_selectQuery,"Pass_SexsiKod", fin));
        }

        public List<EimzaUsers> GetDataByDateTime(DateTime firstDate, DateTime endDate)
        {
            return GetDataBySearchElement(string.Format("SELECT  [Sxs_Ad],[Sxs_Soyad],[Pass_SexsiKod],[Elq_Tel],[Elq_Mail],[Elq_Unvan1],[PayedStatus],[PayedMoney], [Payed_Date], [Oracle_ID],[Pass_Nomre],[Pass_SexsiKod],[Add_Date] FROM [EimzaRegisters].[dbo].[Users] where [Add_Date] Between '{0}' And '{1}'", firstDate, endDate));
        }

        public List<EimzaUsers> GetDataBySearchElement(string query)
        {
            try
            {
                Connect();
                var UsersData = new List<EimzaUsers>();
                SqlCommand cmd = new SqlCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EimzaUsers user = new EimzaUsers();
                    user.OracleID = (int.Parse(reader["Oracle_ID"].ToString()));
                    user.Name = reader["Sxs_Ad"].ToString();
                    user.Surname = reader["Sxs_Soyad"].ToString();
                    user.PİN = reader["Pass_SexsiKod"].ToString();
                    user.Phone = reader["Elq_Tel"].ToString();
                    user.Mail = reader["Elq_Mail"].ToString();
                    user.Adress = reader["Elq_Unvan1"].ToString();
                    user.PayedMoney = double.Parse(reader["PayedMoney"].ToString());
                    user.PayedStatus = (int.Parse(reader["PayedStatus"].ToString()));
                    user.ContractNumber = (int.Parse(reader["Pass_Nomre"].ToString()));
                    var test = reader["Payed_Date"];
                    string dt = user.PayedDate != null ? reader["Payed_Date"].ToString() : "--";
                    UsersData.Add(user);
                }
                return UsersData;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                reader.Close();
                conn.Close();
            }
            return null;
        }
    }
}


