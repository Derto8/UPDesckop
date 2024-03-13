using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPDesctop.Core.Entities
{
    public class Requests
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public DateTime Date { get; set; }
        public string ProblemType { get; set; }
        public string ProblemDescription { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public string State { get; set; }
    }
}
