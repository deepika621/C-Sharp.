using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expressions
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public int TotalMarks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>()
            {
                new Student { Id = 1, Name = "Alice", PhoneNumber = "123-456-7890", Address = "123 Main St", Age = 16 ,TotalMarks = 80 },
                new Student { Id = 2, Name = "Bob", PhoneNumber = "234-567-8901", Address = "456 Oak St", Age = 18 , TotalMarks = 85},
                new Student { Id = 3, Name = "Charlie", PhoneNumber = "345-678-9012", Address = "789 Maple St", Age = 14 , TotalMarks = 70},
                new Student { Id = 4, Name = "David", PhoneNumber = "456-789-0123", Address = "321 Elm St", Age = 21 , TotalMarks = 100},
                new Student { Id = 5, Name = "Eve", PhoneNumber = "567-890-1234", Address = "654 Pine St", Age = 17 ,TotalMarks = 83}
            };

            // Display all student details
            Console.WriteLine("List of Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age},Total Marks: {student.TotalMarks}");
            }

            // Retrieve all record from the list for age between 12 to 18 using linq
            var studentsBetween12And18 = students.Where(s => s.Age >= 12 && s.Age <= 18);
            Console.WriteLine("\nStudents between 12 and 18:");
            foreach (var student in studentsBetween12And18)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
            // Sort students data in descending order based on TotalMarks
            var studentsSortedByTotalMarksDescending = students.OrderByDescending(s => s.TotalMarks);
            Console.WriteLine("\nStudents sorted by total marks (descending):");
            foreach (var student in studentsSortedByTotalMarksDescending)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Total Marks: {student.TotalMarks}");
            }

            // Display all the student records in each address
            Console.WriteLine("\nFetching Student Records in Each Address:");
            var studentsByAddress = students.GroupBy(s => s.Address);
            foreach (var group in studentsByAddress)
            {
                Console.WriteLine($"Address: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"Id: {student.Id}, Name: {student.Name}");
                }
            }

            // Fetch first three students records
            var firstThreeStudents = students.Take(3);
            Console.WriteLine("\nFetching First Three Students:");
            foreach (var student in firstThreeStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Phone Number: {student.PhoneNumber}, Address: {student.Address}, Age: {student.Age},  Total Marks: {student.TotalMarks}");   
            }

            //Search Particular student based on name
            var searchedStudent = students.Find(s => s.Name == "Deepika");
            Console.WriteLine("\nSearching Particular student based on name:");
            if (searchedStudent != null)
            {
                Console.WriteLine($"Student Name:" + searchedStudent.Name);
            }
            else
            {
                Console.WriteLine("No Student Found");
            }
        }
    }
}