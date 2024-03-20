using System;
using System.Linq;
using System.Data.Entity;
using System.Collections;
using System.Collections.Generic;

namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new SchoolContext())
            {

                var student = new Student() { StudentName = "Sam Jones" };

                context.Students.Add(student);
                context.SaveChanges();
                
                Console.Write("Student saved successfully!");
               
            }
        }
    }
}
