using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement
{
    [Serializable]
    public class Client
    {
        [Key]
        public string Id { get; set; }

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
