﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Car
{
    public Car()
    {

    }

    public string Make {get; set;}

    public string Model { get; set; }

    public int Year { get; set; }

    public void CarDetails() 
    {
        Console.WriteLine($"The car is a {Year} {Make} {Model}");
    
    }


}

