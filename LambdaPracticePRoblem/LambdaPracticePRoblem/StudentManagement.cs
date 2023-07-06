using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPracticePRoblem
{
    public class StudentManagement
    {
        List<Student> studentList = new List<Student>()
            {
                new Student { Id = 1, Name = "John Doe", PhoneNumber = "1234567890", Address = "123 Main St", Age = 20 },
                new Student { Id = 2, Name = "Jane Smith", PhoneNumber = "9876543210", Address = "456 Elm St", Age = 19 },
                new Student { Id = 3, Name = "Bob Johnson", PhoneNumber = "5555555555", Address = "789 Oak St", Age = 21 },
                new Student { Id = 4, Name = "Doel", PhoneNumber = "4566333333", Address = "mumbi", Age = 17 },
                new Student { Id = 5, Name = "Anee", PhoneNumber = "433333222", Address = "Delhi", Age = 18 },
                new Student { Id = 6, Name = "Bob", PhoneNumber = "888822222", Address = "Nagpur", Age = 20 },
                new Student { Id = 7, Name = "Johnson", PhoneNumber = "4444444444", Address = "hjgh", Age = 21 },
                new Student { Id = 8, Name = "john", PhoneNumber = "55888888", Address = "Oak St", Age = 25 },
                new Student { Id = 9, Name = "gdha", PhoneNumber = "999995555", Address = "789 St", Age = 30 }
            };
        // Display all student details using lambda expression
        public void Display()
        {
            studentList.ForEach(student => Console.WriteLine($"ID: {student.Id}, " +
                    $"Name: {student.Name}, Phone: {student.PhoneNumber}, " +
                    $"Address: {student.Address}, " +
                    $"Age: {student.Age}"));
        }
        public void RetriveRecords()
        {
            foreach (Student student in studentList.FindAll(x => x.Age >= 12 && x.Age <= 18))
            {
                Console.WriteLine($"Student with ID is: {student.Id} ,Name: {student.Name} ,PhoneNumber: {student.PhoneNumber} ,Address: {student.Address} ,Age: {student.Age}");
            }
        }
    }
}
