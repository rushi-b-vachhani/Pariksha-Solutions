using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parikshav1.pojo
{
    class Exam
    {
        private int id;
        private String name;
        private String code;
        private String description;
        private int isActive;
        private DateTime createdtime;
        private User userid;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public string Description { get => description; set => description = value; }
        public int IsActive { get => isActive; set => isActive = value; }
        public DateTime Createdtime { get => createdtime; set => createdtime = value; }
        internal User Userid { get => userid; set => userid = value; }

        public static List<Exam> getExams()
        {
            db db = new db();
            db.openConnection();
            
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `exam`", db.getConnection());
            adapter.SelectCommand = command;
            Console.WriteLine("Its working in exam1");
            if (adapter.Fill(table) > 0)
            {
                List<Exam> vExamList = new List<Exam>();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Console.WriteLine("Its working in exam2");
                    Exam exam = new Exam();
                    exam.Id = Convert.ToInt32(table.Rows[i]["id"]);
                    exam.Name = table.Rows[i]["name"].ToString();
                    exam.Code = table.Rows[i]["code"].ToString();
                    exam.Description = table.Rows[i]["description"].ToString();

                    exam.IsActive = Int32.Parse(table.Rows[i]["isActive"].ToString());
                    exam.Createdtime = DateTime.Parse(table.Rows[i]["createdtime"].ToString());

                    exam.Userid = User.getUser(Int32.Parse(table.Rows[i]["userid"].ToString()));
                    vExamList.Add(exam);
                }
                Console.WriteLine("Its working in exam4");
                return vExamList;
            }
            return null;
        }
    }
}
