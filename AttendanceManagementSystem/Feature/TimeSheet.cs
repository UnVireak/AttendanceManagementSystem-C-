using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using AttendanceManagementSystem.Entities;
namespace AttendanceManagementSystem.Feature
{
    public class TimeSheet
    {
        public List<Employee>? Employees { get; set; } // array list. ជាProperty របស់ class TimeSheet
        public TimeSheet() // class constructor
        {
            Employees = new List<Employee>();
        }
        public void AddEmployee(Employee emp) {
            if (string.IsNullOrEmpty(emp.FullName) || string.IsNullOrEmpty(emp.Position) || string.IsNullOrEmpty(emp.CardNo))
            {
                throw new ArgumentException("Please provide all employee data!");
                
            }
            else
            {
                Employees?.Add(emp);
            }
        }
        public void UpdateEmployee(string IdentityId, string FullName, string Position)
        {
            if(string.IsNullOrEmpty(FullName) || string.IsNullOrEmpty(Position))
            {
                throw new ArgumentException("Please provide all employee data!");
            }
            int foundIndex = Employees!.FindIndex(em => em.IdentityId == new Guid(IdentityId));
            Employees[foundIndex].FullName = FullName;
            Employees[foundIndex].Position = Position;
        }
        public void LogEmployee(string CardNo, Log logInfo) {
            if(string.IsNullOrEmpty(CardNo))
            {
                //Check for Empty card
                throw new ArgumentException("Card No is empty!");
            }
            
            int foundIndex = Employees!.FindIndex(emp => emp.CardNo == CardNo.Trim());
            if(foundIndex < 0)
            {
                throw new ArgumentException($"Card No {CardNo} not found in employee list.");
            }
            Employees[foundIndex].Logs!.Add(logInfo);
        }
        public List<EmployeeView> GetAllEmployee()// return type arr របស់ Employee
        {
            // using LINQ to selete data without log property

            return Employees!.Select(emp => new EmployeeView()
            {
                IdentityId = emp.IdentityId,
                FullName = emp.FullName,
                Position = emp.Position,
                CardNo = emp.CardNo
            }).ToList();
        }
        public void RemoveRow(Guid IdentityID)
        {
            int foundIndex = Employees!.FindIndex(em => em.IdentityId == IdentityID);
            Employees.RemoveAt(foundIndex);
        }

        public void FindDublicateCardID(string cardNO)
        {
           
                int foundIndex = Employees!.FindIndex(em => em.CardNo == cardNO );
            
           
        }
        public List<Employee> GetAllEmployee(bool isSimpleversion) 
        {
            return Employees!;
        }
    }
}
