﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingTeamCity.Models
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }
}