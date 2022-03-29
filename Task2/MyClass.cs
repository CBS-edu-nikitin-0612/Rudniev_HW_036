using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class MyClass
    {
        [Obsolete("This method is obsolete. Call NewMethod1 instead.", false)]
        public string OldMethod1()
        {
            return "Old Method 1";
        }
        public string NewMethod1()
        {
            return "New Method 1";
        }
        [Obsolete("This method is obsolete. Call NewMethod2 instead.", true)]
        public string OldMethod2()
        {
            return "Old Method 2";
        }
        public string NewMethod2()
        {
            return"New Method 2";
        }
    }
}
