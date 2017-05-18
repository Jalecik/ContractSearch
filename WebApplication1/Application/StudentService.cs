using Application.Common;
using Application.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class StudentService
    {
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
        public static DeleteStudentOutput DeleteStudent(int id)
        {
            int rowDelete = 0;
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P4R0E9R\SQLEXPRESS;Initial Catalog=University;Integrated Security=True"))
            {
                try
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
                        if(rowDelete == 0)

                            return new DeleteStudentOutput
                            {
                                ErrorCode = (int)Enums.Errors.NOT_FOUND,
                                ErrorMessage = "Silinmedi"
                            };
                        return new DeleteStudentOutput
                        {
                            Id = rowDelete,
                            ErrorCode = (int)Enums.Errors.SUCCESS
                        };
                    }
                }
                catch (Exception ex)
                {
                    return new DeleteStudentOutput
                    {
                        ErrorCode = (int)Enums.Errors.GENERAL_ERROR,
                        ErrorMessage = ex.Message
                    };
                }
            }
        }
        public static int UpdateStudentTable(int id, string name, string surname, string email)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-P4R0E9R\SQLEXPRESS;Initial Catalog=University;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("spUpdateStudents", conn))
                {
                    int UpdateRecord = 0;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@name", SqlDbType.VarChar,100).Value = name;
                    cmd.Parameters.Add("@surname", SqlDbType.VarChar,100).Value = surname;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar,100).Value = email;
                    if (conn.State != ConnectionState.Open)
                    {
                        conn.Open();
                    }
                    UpdateRecord = cmd.ExecuteNonQuery();
                    return UpdateRecord;
                }     
        }

        }
        public static Student GetStudentById(int Id)
        {
            try
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
                        var studentList = ds.Tables[0].AsEnumerable().Select(r => new Student
                        {
                            id = r.Field<int>("id"),
                            Name = r.Field<string>("Name"),
                            Surname = r.Field<string>("Surname"),
                            Gender = r.Field<string>("Gender"),
                            Birthdate = r.Field<DateTime>("Birthdate"),
                            Email = r.Field<string>("Email"),
                            Phone = r.Field<int>("Phone"),
                            Country = r.Field<string>("Country"),
                            City = r.Field<string>("City"),
                            EnteringYear = r.Field<DateTime>("Entering Year"),
                            GraduationYear = r.Field<DateTime>("Graduation Year"),
                            group = r.Field<string>("Group"),
                            Status = r.Field<string>("Status"),
                        });
                        if (studentList.ToList().Count() != 0)
                        {
                            return studentList.ToList()[0];
                        }
                        else
                        {
                            throw new Exception("student with id" + Id + "not found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
              
            }
            return null;
        }
        public static List<Student> GetallStudents()
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
                        var studentList = ds.Tables[0].AsEnumerable().Select(r => new Student
                        {
                            id = r.Field<int>("id"),
                            Name = r.Field<string>("Name"),
                            Surname = r.Field<string>("Surname"),
                            Gender = r.Field<string>("Gender"),
                            Birthdate = r.Field<DateTime>("Birthdate"),
                            Email = r.Field<string>("Email"),
                            Phone = r.Field<int>("Phone"),
                            Country = r.Field<string>("Country"),
                            City = r.Field<string>("City"),
                            EnteringYear = r.Field<DateTime>("Entering Year"),
                            GraduationYear = r.Field<DateTime>("Graduation Year"),
                            group = r.Field<string>("Group"),
                            // Averagemark = r.Field<int>("Average Mark"),
                            // FacultyId = r.Field<int>("FacultyId"),
                            Status = r.Field<string>("Status"),
                        });
                        return studentList.ToList();
                    }
                }
            }
        }
    }
}

