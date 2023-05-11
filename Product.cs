using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Product
    {
        private string name;
        private string location;
        private int weight;

        public Product(string name) {
            this.name = name;
            this.location = "";
            this.weight = 1;
        }
        public Product(string name, string location)
        {
            this.name = name;
            this.location = location;
            this.weight = 1;

        }
        public Product(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
            this.location = "";

        }
        public override string ToString()
        {


            return this.name+ " " + this.weight + " " +this.location;
        }

    }
}
