using System;
using System.Collections.Generic;
using System.Text;

namespace ListExample.Models
{
  public class Employee
    {
        public string Name { get; set; }
        public string Occupation { get; set; }
        public int Age { get; set; }
        public Employee()
        {
            Age = 24;
        }
    }
}
