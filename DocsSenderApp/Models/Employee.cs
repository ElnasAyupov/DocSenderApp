using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DocsSenderApp.Models
{
    public class Employee
    {
        public Employee()
        {
            this.EmployeeId = Guid.NewGuid().ToString();
            Files = new List<File>();
        }
        public string EmployeeId { get; set; }
        public string AccountId { get; set; }
        public string RankId { get; set; }
        public string FIO { get; set; }
        public byte[] Avatar { get; set; }

        public List<File> Files { get; set; }
    }
}
