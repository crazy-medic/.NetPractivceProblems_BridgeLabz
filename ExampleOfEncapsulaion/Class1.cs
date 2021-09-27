using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOfEncapsulaion
{
    class Class1
    {
        private string Name;

        public string NameOfPerson
        {
            get { return Name; }
            set { Name = value; }
        }

    }
}
