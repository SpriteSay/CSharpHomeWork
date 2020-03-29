using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    [Serializable]
    public class Client
    {
        public string Id { get;  }

        public Client() { }
        public Client(string id)
        {
            Id = id;
        }

        public override string ToString()
        {
            return Id;
        }
    }
}
