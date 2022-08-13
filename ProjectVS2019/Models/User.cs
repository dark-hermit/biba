
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectVS2019.Models
{
    public class User : Entity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public DateTime Birth { get; set; }
        public string PassSeria { get; set; }
        public string PassNumber { get; set; }
        public string Address { get; set; }
        public string INN { get; set; }
        public string PhoneNumber { get; set; }
    }
}
