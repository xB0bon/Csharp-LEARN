﻿namespace Klasy1;

internal class Customer
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }


    // ctor
    public Customer()
    {
        Name = "None";
        Address = "None";
        ContactNumber = "None";
    }
    // ctor
    public Customer(string name, string address, string contactNumber)
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    // ctor
    public Customer(string name)
    {
        Name = name;
    }

    public void SetDetails(string name, string address, string contactNumber)
    {
        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }
}