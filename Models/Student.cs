using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models;

public class Student
{
    public string Roll { get; set; }
    public string Name { get; set; }
    public bool IsPresent { get; set; } = false;
    public string ImagePath { get; set; } = "person_image";

    public Student(string roll, string name)
    {
        this.Roll = roll;
        this.Name = name;
    }
}