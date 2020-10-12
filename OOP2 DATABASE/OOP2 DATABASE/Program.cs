using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OOP2_DATABASE
{
   

    

    class Program
    {
        static void Main(string[] args)
        {

            string connectionstring = "" +
                "Data Source=CARDBOARDPC;" +
                "Database=StudentDB;" +
                "Integrated Security=True;";

            SqlConnection con = new SqlConnection(connectionstring);

            con.Open();

            SqlCommand studentSQL = new SqlCommand("select * from Student");

            SqlDataAdapter adapter = new SqlDataAdapter();

            studentSQL.Connection = con;

            adapter.SelectCommand = studentSQL;

            DataTable dt = new DataTable();

            adapter.Fill(dt);
            List<Student> studentsList = new List<Student>();

            foreach (DataRow row in dt.Rows) 
            {
                double grade = double.Parse(row["Grade"].ToString());
                Student x = new Student(row["StudentName"].ToString() , grade);
                studentsList.Add(x);
                Console.WriteLine(x.getName() +" "+ x.getGrade());
                

            }

            //study entity framework

            Console.ReadKey();
        }
    }
}
