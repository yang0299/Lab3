using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Models
{
    public class Person
    {
        
        public string FirstName
        {
            get;
            set; 
        }
       
        public string LastName
        {
            get;
            set;
        }
       
        public int Age
        {
            get;
            set;
        }

        [Required]
        [StringLength(255)]
        [EmailAddress]
        public string EmailAddress
        {
            get;
            set;
        }

        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> DOB
        {
            get;
            set;
        } 

        [Required]
        [StringLength(20)]
        [BindProperty(Name = "pass")]
        public string Password
        {
            get;
            set;
        }
        [Required]
        [BindProperty(Name = "descrip")]
        public string Description
        {
            get;
            set;
        }
    }
}
