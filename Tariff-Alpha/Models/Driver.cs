using System;
using System.ComponentModel.DataAnnotations;

namespace Alpha.Models
{
    public class Driver
    {
        public int DriverID { get; set; }
        // password?

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Number { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //relacja
        public virtual Car CarID { get; set; }

        // state - lista 4 wartosci: bussy, available, sickleave, holiday
        public string State { get; set; }
    }

}