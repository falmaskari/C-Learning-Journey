using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Day_s_Problem
{
    internal class Person
    {
        private string fName;
        private string lName;
        private int age;
        private double salary;
        private string relationShipState;
    public void Setfname(string fname)
    {
        this.fName = fname;
    }
    public string Getfname(string Fname)
    {
        return fName;
    }
    public void Setlname(string Lname)
    {
        this.lName = Lname;
    }
    public void SetAge(int Age)
    {
        this.age = Age;
    }
    public int GetAge(int Age)
    {
        return age;
    }
    public void SetSalary(double Salary)
    {
        this.salary = Salary;
    }
    public double SetSalary(string Salary)
    {
        return salary;
    }
    public void SetRel(string Rel)
    {
        this.relationShipState = Rel;
    }
    public string GetRel(string Rel)
    {
        return relationShipState;
    }

    public string printInfo()
    {
         return $"First Name: {fName}, Last Name: {lName}, Age: {age}, Salary: {salary}, Relationship State: {relationShipState}";
    }

    }
}
