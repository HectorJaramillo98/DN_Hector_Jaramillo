using Linq.Examples.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Examples
{   
    internal class Program
    {
       static IList<Student> studentList = new List<Student>() {

        new Student(){StudentID=1,StudentName="John",Age=18,StandardID=1},
        new Student(){StudentID=2,StudentName="Steve",Age=21,StandardID=1},
        new Student(){StudentID=3,StudentName="Bill",Age=19,StandardID=2},
        new Student(){StudentID=4,StudentName="Ram",Age=20,StandardID=3},
        new Student(){StudentID=5,StudentName="Rem",Age=20},
        new Student(){StudentID=6,StudentName="Liz",Age=14}

    };
        static IList<Standard> standardList = new List<Standard>() { 
        new Standard(){StandardID=1,StandardName="Standard 1"},
        new Standard(){StandardID=2,StandardName="Standard 2"},
        new Standard(){StandardID=3,StandardName="Standard 3"}
        };

        static void Main(string[] args)
        {
            var test = studentList.Where(x => (x.Age >= 18 && x.StandardID > 0) )
                .Select(x => x.StudentName);

            var teenStudentsName = from s in studentList
                                   where s.Age > 12 && s.Age < 20
                                   select new { Name2 = s.StudentName };

            var studentsGrouppByStandard = from s in studentList
                                           where s.Age > 12 && s.Age < 20
                                           group s by s.StandardID into sg
                                           orderby sg.Key
                                           select new
                                           {
                                               StandardID = sg.Key,
                                               Items = sg
                                           };
            var studentWithStandard = from s in studentList
                                      join stad in standardList
                                      on s.StandardID equals stad.StandardID
                                      select new
                                      {
                                          StudentName = s.StudentName,
                                          StandardName = stad.StandardName
                                      };
                                         






            foreach (var item in studentWithStandard)
            {
                Console.WriteLine($"Student: {item.StudentName} is in {item.StandardName}");
            }




            Console.ReadKey(true);
        }
    }
}
