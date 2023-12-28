﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceManagementSystem.Entities
{
    public class Employee
    {
        public Guid IdentityId { get; set; }
        public string? FullName { get; set; }
        public string? Position { get; set; }
        public string? CardNo { get; set; }
        public IList<Log>? Logs { get; set; }

        //constructor
        public Employee()
        {

        }
        public Employee(string FullName, string Position, string CardNo)
        {
            this.IdentityId = Guid.NewGuid();
            this.FullName = FullName.Trim();
            this.Position = Position.Trim();
            this.CardNo = CardNo.Trim();
            this.Logs = new List<Log>();
        }
        
    }
}
