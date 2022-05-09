using Homework4.Entity.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4.Entity.Models
{
    public class Request : EntityBase
    {
        [Key]
        public int RequestId { get; set; }
        //public int RequestDepartment { get; set; }
        public string RequestPriorityStatus { get; set; }
        public string RequestSubject { get; set; }
        public DateTime? RequestStartDate { get; set; }
        public DateTime? RequestEndDate { get; set; }
        public string RequestContent { get; set; }
        //public int RequestRequisitioner { get; set; }
        public bool RequestStatus { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

        public int? EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
