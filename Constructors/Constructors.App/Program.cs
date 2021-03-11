using People.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors.App
{
    class Program
    {
        static void Main(string[] args)
        {
            IPersonFactory f = new PersonFactory();
        }
    }
}
