﻿using AbstractClassesAndInterfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Entities
{
    public abstract class Human :IHuman
    {
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; }
        public long Phone { get; set; }
        public abstract string GetInfo();

        public Human(string fullName, int age, long phone)
        {
            FullName = fullName;
            Age = age;
            Phone = phone;
        }
        public void Greet(string name)
        {
            Console.WriteLine($"Hey there {name}! My name is {FullName}");
        }
    }
}
