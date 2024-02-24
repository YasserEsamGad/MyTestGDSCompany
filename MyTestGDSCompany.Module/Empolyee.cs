using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGDS.Module
{
    
    public class Empolyee
    {

        [Key]
        [Browsable(false)]
        [Persistent("EmployeeID")]
        public virtual int Id { get; protected set; }

        [RuleRequiredField("Employee_FirstName_Required", DefaultContexts.Save)]
        public virtual string FirstName { get; set; }

        [RuleRequiredField("Employee_LastName_Required", DefaultContexts.Save)]
        public virtual string LastName { get; set; }

        [RuleRequiredField("Employee_DateOfBirth_Required", DefaultContexts.Save)]
        public virtual DateTime DateOfBirth { get; set; }

        [RuleRequiredField("Employee_Email_Required", DefaultContexts.Save)]
        
        public virtual string Email { get; set; }

        public virtual string Position { get; set; }

        [ForeignKey("Department")]
        public virtual int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public virtual decimal Salary { get; set; }
    }
}
