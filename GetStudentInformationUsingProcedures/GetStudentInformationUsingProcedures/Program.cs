using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetStudentInformationUsingProcedures
{
    class Program
    {
        static void Main(string[] args)
        {
            //InsertNewStudent("jujujujjjjjj", "cahan", "ddfd", new DateTime(2013, 1, 23), "ghdshgggdgfsh", 2324234, "hsdjbshds", "gdshdg", new DateTime(2014,06,06), new DateTime(2014, 06, 06), "gf", 87, 2, "asdasdasd");
            //DeleteStudent(26);
            // UpdateStudentTable(28, 123242423, new DateTime(2010, 1, 23), new DateTime(2014, 1, 23), "tkkjghjhghkkk-0888", 89);
          //  GetStudentById(3);
            //var a=GetStudentsCountById(1);
       
        }


        public static int InsertNewStudent(string name, string surname, string gender, DateTime birthdate, string email, int phone, string country, string city, DateTime enteredYear, DateTime graduationYear, string group, int averageMark, int facultyId, string status)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P4R0E9R\SQLEXPRESS;Initial Catalog=University;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("spSaveNewStudents", conn))
                {
                    int saveRecord;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = name;
                    cmd.Parameters.Add("@surname", SqlDbType.VarChar, 100).Value = surname;
                    cmd.Parameters.Add("@gender", SqlDbType.VarChar, 100).Value = gender;
                    cmd.Parameters.Add("@Birthdate", SqlDbType.Date).Value = birthdate;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = email;
                    cmd.Parameters.Add("@Phone", SqlDbType.VarChar, 100).Value = phone;
                    cmd.Parameters.Add("@Country", SqlDbType.VarChar, 100).Value = country;
                    cmd.Parameters.Add("@City", SqlDbType.VarChar, 100).Value = city;
                    cmd.Parameters.Add("@EnteringYear", SqlDbType.Date).Value = enteredYear;
                    cmd.Parameters.Add("@GraduationYear", SqlDbType.Date).Value = graduationYear;
                    cmd.Parameters.Add("@Group", SqlDbType.VarChar, 100).Value = group;
                    cmd.Parameters.Add("@AverageMark", SqlDbType.Int).Value = averageMark;
                    cmd.Parameters.Add("@FacultyId", SqlDbType.Int).Value = facultyId;
                    cmd.Parameters.Add("@Status", SqlDbType.VarChar).Value = status;

                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    saveRecord = cmd.ExecuteNonQuery();
                    return saveRecord;
                }

            }

        }
        public static int DeleteStudent(int id)
        {
            int rowDelete = 0;
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P4R0E9R\SQLEXPRESS;Initial Catalog=University;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("spDeleteStudents", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    rowDelete = cmd.ExecuteNonQuery();
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                    return rowDelete;
                }
            }
        }
        public static int UpdateStudentTable(int id, int phone, DateTime enteredYear, DateTime graduationYear, string group, int averageMark)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P4R0E9R\SQLEXPRESS;Initial Catalog=University;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateStudents", conn))
                {
                    int UpdateRecord = 0;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@phone", SqlDbType.Int).Value = phone;
                    cmd.Parameters.Add("@EnteringYear", SqlDbType.Date).Value = enteredYear;
                    cmd.Parameters.Add("@GraduationYear", SqlDbType.Date).Value = graduationYear;
                    cmd.Parameters.Add("@Group", SqlDbType.VarChar, 100).Value = group;
                    cmd.Parameters.Add("@AverageMark", SqlDbType.Int).Value = averageMark;
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    UpdateRecord = cmd.ExecuteNonQuery();
                    return UpdateRecord;
                }

            }

        }
        public static DataSet GetStudentById(int Id)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P4R0E9R\SQLEXPRESS;Initial Catalog=University;Integrated Security=True"))
            {
                DataSet ds = new DataSet();
                using (SqlCommand cmd = new SqlCommand("[dbo].[spStudentInformationByID]", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = Id;
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    SqlDataAdapter adp = new SqlDataAdapter();
                    adp.SelectCommand = cmd;
                    adp.Fill(ds);
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();

                    }
                    return ds;
                }
            }
        }

        public static int GetStudentsCountById(int id)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P4R0E9R\SQLEXPRESS;Initial Catalog=University;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("[dbo].[spGetStudentsCountById]", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    var getStudentsCountById = cmd.Parameters.Add("@count", SqlDbType.Int);
                    getStudentsCountById.Direction = ParameterDirection.ReturnValue;
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    cmd.ExecuteNonQuery();
                    return (int)getStudentsCountById.Value;
                }

            }
        }
        public void getallStudents()
        {
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P4R0E9R\SQLEXPRESS;Initial Catalog=University;Integrated Security=True"))
                {
                    DataSet ds = new DataSet();
                    using (SqlCommand cmd = new SqlCommand("[dbo].[spStudentInformation]", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (conn.State != ConnectionState.Open)
                        {
                            conn.Open();
                        }
                        SqlDataAdapter adp = new SqlDataAdapter();
                        adp.SelectCommand = cmd;
                        adp.Fill(ds);
                        if (conn.State == ConnectionState.Open)
                        {
                            conn.Close();

                        }
                    }
                }
            }
        }
    }
}







