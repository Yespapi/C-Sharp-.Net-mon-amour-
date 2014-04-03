﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Binder.Models
{
    public class Person
    {
        public readonly string _lastName; 
        public readonly string _firstName; 

        public Person(string FirstName, string LastName)
        {
            _lastName = LastName;
            _firstName = FirstName;
        }

        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
        {
            get { return _lastName; }
        }
    }
}