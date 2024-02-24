using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGDS.Module
{
    
    public class Department
    {

        [Key]
        [Browsable(false)]
        [Persistent("DepartmentID")]
        public virtual int Id { get; protected set; }
        [RuleRequiredField]
        public virtual String Name { get; protected set; }

        public virtual IList<Empolyee> Employees { get; set; } = new ObservableCollection<Empolyee>();


    }
}
