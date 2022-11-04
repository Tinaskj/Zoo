using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_Project
{
    internal class Zoo
    {
        public List<Employees> Employee { get; set; }
        public List<Zookepers> Zookeeper { get; set; }

        private List<Animals> Animal { get; set; }

        private List<Enclosures> Enclosure { get; set; }

        public Zoo(List<Employees> employee, List<Zookepers> zookeeper, List<Animals> animal, List<Enclosures> enclosure)
        {
            Employee = employee;
            Zookeeper = zookeeper;
            Animal = animal;
            Enclosure = enclosure;
        }
    }
}
