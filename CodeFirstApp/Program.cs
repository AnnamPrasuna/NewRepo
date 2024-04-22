using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeFirstApp
{
     class Program
    {
        static void Main(string[] args)
        {
            appdbcontext db = new appdbcontext();
            //insertion
            /* db.Students.Add(new Student { Name= "prasuna", Group="bsc" });
             db.SaveChanges();
            Console.WriteLine("record added successfully.....");*/


            //reading
            /* Student std1 = db.Students.Find(4);
             Console.WriteLine("Name is :"+std1.Name);
             Console.WriteLine("Group is :" + std1.Group);
             Console.WriteLine("record readed successfully.....");*/

            //updation
            /*Student std1 = db.Students.Find(4);
            std1.Name = "pavi";
            db.Entry(std1).State=EntityState.Modified;
            db.SaveChanges();
            Console.WriteLine("data updated successfully...!");
                                                                  */

            //deleting
              Student std = db.Students.Find(5);
              db.Students.Remove(std);
              db.SaveChanges();
              Console.WriteLine("record deleted successfully........");
              Console.ReadLine();
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
    }
    class appdbcontext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}
