using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EndToEnd.Models
{
    [Table("Content")]
    public class Content
    {
        //Content ID
        [Key]
        public int Id { get; set; }

        //Content Description
        [StringLength(200)]
        public string Description { get; set; }

        //Content Image
        public byte[] Image { get; set; }
    }
}