using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Modelos.Legacy
{
    public class Developer
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private string LastName { get; set; }

        public string GetCompleteName()
        {
            return $"Mis datos son {Name} {LastName}";
        }

        public int GetId()
        {
            return Id;
        }
    }
}
