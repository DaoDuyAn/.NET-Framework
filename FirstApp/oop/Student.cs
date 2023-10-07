using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp.oop
{
    public class Student { 
       public string Name { get; set; }
       public EGENDER Gender { get; set; }
       public DateTime DOB { get; set; }

        public override string ToString()
        {
            return $"Name: {Name, 5} - Gender: {Gender, 6} - DOB: {DOB: dd/MM/yyyy}";
        }
        public static List<Student> GetStudents()
       {
            var students = new List<Student>();
            students.Add(new Student {DOB = new DateTime(2002, 8, 10), Name = "Dung", Gender = EGENDER.Male });
            students.Add(new Student {DOB = new DateTime(2002, 9, 10), Name = "Long", Gender = EGENDER.Male });
            students.Add(new Student {DOB = new DateTime(2002, 10, 25), Name = "Le", Gender = EGENDER.Male });
            students.Add(new Student {DOB = new DateTime(2002, 8, 10), Name = "Hung", Gender = EGENDER.Other });
            students.Add(new Student {DOB = new DateTime(2002, 10, 4), Name = "Viet", Gender = EGENDER.Female });
            students.Add(new Student {DOB = new DateTime(2002, 6, 10), Name = "Hieu", Gender = EGENDER.Female });
            return students;
       }
       public enum EGENDER
       {
            Male, Female, Other
       }
    }
}
