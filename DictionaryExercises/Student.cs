using System;
using System.Collections.Generic;
using System.Text;

namespace DictionaryExercises
{
    class Student
    {
        public static void GetStudent()
        {
            Dictionary<double, string> students = new Dictionary<double, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");

            do
            {
                Console.WriteLine("Student: ");
                string input = Console.ReadLine();
                newStudent = input;

                if (!Equals(newStudent, ""))
                {
                    Console.WriteLine("Student ID: ");
                    input = Console.ReadLine();
                    double newID = double.Parse(input);
                    students.Add(newID, newStudent);

                    Console.ReadLine();
                }

            } while (!Equals(newStudent, ""));

            Console.WriteLine("\nClass roster:");

            foreach (KeyValuePair<double, string> student in students)
            {
                Console.WriteLine(student.Value + " has a Student ID of: " + student.Key);
            }
        }
    }
}
