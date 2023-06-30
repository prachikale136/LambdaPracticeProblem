using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaProblem
{
    internal class Management
    {
        public void AddStudentData()
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student(1, "Ram", "9999900000", "Delhi", 25));
            studentList.Add(new Student(2, "Rohit", "9638527410", "Mangalore", 15));
            studentList.Add(new Student(3, "Ajay", "8527419630", "Kanpur", 11));
            studentList.Add(new Student(4, "Sam", "8525643212", "Delhi", 12));
            studentList.Add(new Student(5, "Rahul", "8000000000", "Shimla", 18));
            studentList.Add(new Student(6, "Rae", "8574195218", "Lucknow", 15));
            studentList.Add(new Student(7, "Jack", "8741741741", "Kochi", 20));
            Console.WriteLine("Records Added");

            foreach (Student student in studentList)
            {
                Console.WriteLine($"Student with ID is: {student.Id} ,Name: {student.Name} ,PhoneNumber: {student.PhoneNumber} ,Address: {student.Address} ,Age: {student.Age}");
            }
        }
        
            
           
        
    }
}
