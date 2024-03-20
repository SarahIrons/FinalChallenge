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

            var context = new SchoolContext();
            {

                var student = new Student() { StudentName = "Sam Jones" };

                context.Students.Add(student);
                context.SaveChanges();
            }
        }
    }
}
