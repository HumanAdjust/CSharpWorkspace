using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameCard = new {
                Name = "박상현",
                Age = 17
            };

            Console.WriteLine("이름: {0}, 나이: {1}", nameCard.Name, nameCard.Age);

            var complex = new
            {
                Real = 12,
                Imaginary = 15
            };

            Console.WriteLine("complex: {0} + {1}i",
                complex.Real, complex.Imaginary);
        }
    }
}
