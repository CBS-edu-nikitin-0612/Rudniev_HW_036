using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aditionalTask
{
    class Employee
    {

    }

    [AccessLevel(AccessLevel.average)]
    class Manager : Employee
    {

    }
    [AccessLevel(AccessLevel.low)]
    class Programmer : Employee
    {

    }
    [AccessLevel(AccessLevel.high)]
    class Director : Employee
    {

    }
}
