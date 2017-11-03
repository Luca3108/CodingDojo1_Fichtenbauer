using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class TestPerson
    {

        public int Age { get; set; }

        public string Name { get; set; }

        public TestPerson(int age,string name)
        {
            this.Age = age;
            this.Name = name;
        }


        public override string ToString()
        {


            return String.Format("{0} with Age {1}", Name, Age);
        }
    }
}
