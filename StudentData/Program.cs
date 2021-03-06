﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace StudentData
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("C:\\Users\\brown\\source\\repos\\StudentData\\StudentData\\studentData.txt");

            List<Student> students = new List<Student>();

            string line;

            while ((line = file.ReadLine()) != null)
            {
                string[] items = line.Split(" ");
                Student s = new Student(items[0]);

                for (int i = 1; i < items.Length; i++)
                {
                    s.AddScore(Int32.Parse(items[i]));
                }

                students.Add(s);
                
            }
            foreach (Student item in students)
            {
                if (item.SixOrGreater())
                Console.WriteLine(item.Name);
              
            }
            Console.ReadLine();
        }
    }
}
