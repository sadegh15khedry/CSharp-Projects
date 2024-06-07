using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary;

public class PersonProcessor
{
    public static string GetFullName(string name , string lastName)
    {
        return (name + "  " + lastName);
    }
}
