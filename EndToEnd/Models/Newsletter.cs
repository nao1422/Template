using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EndToEnd.Models
{
    [Table("Newsletter")]
    public class Newsletter
    {
        //Newsletter User ID
        [Key]
        public int Id { get; set; }

        //Newsletter User Email
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}