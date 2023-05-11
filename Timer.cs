using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Timer
    {
        public int value { get; set; }
        public int limit { get; set; }
        public int sec { get; set; }

        public Timer(int limit)
        {
            this.limit = limit;
            this.value = 0;
        }

        public void Advance()
        {
            this.value = this.value + 1;
            if (this.value >= this.limit)
            {
                this.value = 0;
                this.sec++;
            }

        }

        public override string ToString()
        {
            if (this.value < 10)
            {
                return this.sec + ":" + "0" + this.value;
            }

            return this.sec + ":" + this.value;
        }

    }
}
