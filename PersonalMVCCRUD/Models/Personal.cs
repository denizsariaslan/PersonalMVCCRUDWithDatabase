
namespace PersonalMVCCRUD.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Personal
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Department Name is required")]
       
        [Display(Name = "Department Name")]
        public Nullable<int> DepartmentId { get; set; }
        [Required(ErrorMessage = "First name is required")]
        [StringLength(15, ErrorMessage = "Name can be no larger than 15 characters")]
        [Display(Name = "First Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(15, ErrorMessage = "Name can be no larger than 15 characters")]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }
        [Required(ErrorMessage = "Age is required")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Age can be numeric")]
        [StringLength(2, ErrorMessage = "Age can be no larger than 2 characters")]
        [Display(Name = "Age")]
        public string Age { get; set; }
        public string Salary { get; set; }
      

        [Display(Name = "Date Of Birth")]
        public Nullable<System.DateTime> DateOfBrith { get; set; }
        public string Gender { get; set; }
        public string Marriage { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
