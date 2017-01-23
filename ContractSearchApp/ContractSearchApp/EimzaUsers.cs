using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractSearchApp
{
    class EimzaUsers
    {
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ContractNumber { get; set; }
        public string FIN { get; set; }
        public int OracleID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PİN { get; set; }
        public string Phone { get; set; }
        public string Mail { get; set; }
        public string Adress { get; set; }
        public int PayedStatus { get; set; }
        public double PayedMoney { get; set; }
        public DateTime PayedDate { get; set; }
        public EimzaUsers()
        {

        }
        public EimzaUsers(DateTime begindate, DateTime endDate ,  int contractNumber,string fin,int oracleID,string name,string surname,string pin,string phone, string mail, string adress, int payedStatus, double payedMoney, DateTime payedDate )
        {
            BeginDate = begindate;
            EndDate = endDate;
            FIN = fin;
            ContractNumber = contractNumber;
            OracleID = oracleID;
            Name = name;
            Surname = surname;
            PİN = pin;
            Phone = phone;
            Mail = mail;
            Adress = adress;
            PayedStatus = payedStatus;
            PayedMoney = payedMoney;
            PayedDate = PayedDate;
        }
    }

}
