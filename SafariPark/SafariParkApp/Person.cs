using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafariParkApp
{
    public class Person
    {
        public string _firstName;
        public string _lastName;
        public int Age { get; set; }
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public string GetFullName()
        {
            return $"Full name: {_firstName} {_lastName}";
        }
        public string GetAge()
        {
            return $"Age: {Age}";
        }
        public string FullNameProperty => $"{_firstName} {_lastName}";//this is a property
        public string GetNickname() => $"{_firstName.First()}-dog {_lastName}-ino";//this is a method
    }
}