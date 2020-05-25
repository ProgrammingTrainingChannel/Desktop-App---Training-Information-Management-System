//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLogic
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblTrainee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblTrainee()
        {
            this.tblTraineeCourses = new HashSet<tblTraineeCourse>();
            this.tblTraineeMessages = new HashSet<tblTraineeMessage>();
        }
    
        public int ID { get; set; }
        public string Fullname { get; set; }
        public System.DateTime BirthDate { get; set; }
        public int GenderID { get; set; }
        public int AcademicLevelID { get; set; }
        public int BranchID { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] Photo { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual tblAcademicLevel tblAcademicLevel { get; set; }
        public virtual tblBranch tblBranch { get; set; }
        public virtual tblGender tblGender { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTraineeCourse> tblTraineeCourses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTraineeMessage> tblTraineeMessages { get; set; }
    }
}
