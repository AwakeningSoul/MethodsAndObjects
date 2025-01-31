﻿using System;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inside of the Main method, instantiate and initialize an Employee object with
            //the first name of “Sample” and a last name of “Student”.
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Call the superclass method SayName() on the Employee object.
            sam.SayName();
            Console.ReadLine();
        }
    }
}
