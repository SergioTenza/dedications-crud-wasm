using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminDashboard.Wasm.Models
{
    public class Machine
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string PrivateId { get; set; }
        public string Location { get; set; }
        public User[] user { get; set; }
        public Evento[] Tasks { get; set; }
        public string  status { get; set; }
    }
}
