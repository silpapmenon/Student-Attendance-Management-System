//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Attendances = new HashSet<Attendance>();
            this.Complaints = new HashSet<Complaint>();
            this.Leaves = new HashSet<Leave>();
        }
    
        public int StudentID { get; set; }
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public string DivisionName { get; set; }
        public string StudentEmail { get; set; }
        public string StudentMobile { get; set; }
        public System.DateTime DOB { get; set; }
        public string Image { get; set; }
        public string StudentAddress { get; set; }
        public string StudentCity { get; set; }
        public int StudentPincode { get; set; }
        public string StudentUsername { get; set; }
        public string StudentPassword { get; set; }
        public int StandardID { get; set; }
        public int Gender { get; set; }
        public int RoleID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendances { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Complaint> Complaints { get; set; }
        public virtual Gender Gender1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Leave> Leaves { get; set; }
        public virtual Role Role { get; set; }
        public virtual Standard Standard { get; set; }
    }
}
