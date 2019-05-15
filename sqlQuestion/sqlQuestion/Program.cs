using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqlQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            using (CSGEntities entities = new CSGEntities())
            {

                entities.Students.ToList().ForEach(m => Console.WriteLine(m));
                Console.WriteLine();
                entities.Courses.ToList().ForEach(m => Console.WriteLine(m));
                Console.WriteLine();
                entities.Grades.ToList().ForEach(m => Console.WriteLine(m));
                var same_courses = (from x in entities.Grades where x.COURSE_ID == x.Cours.ID group x by x.COURSE_ID).ToList();
                same_courses.ForEach(m => Console.WriteLine(m));
                //same_courses.ForEach(m => entities.Courses.Take(1).FirstOrDefault().NUM_OF_STUDENTS = m.Count());
                
                entities.SaveChanges();
              

            }
            
        }
    }
}
