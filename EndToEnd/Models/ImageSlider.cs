using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EndToEnd.Models
{
    [Table("ImageSlider")]
    public class ImageSlider
    {
        [Key]
        public int Id { get; set; }
        public string ImagePath { get; set; }
    }
}