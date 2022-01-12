using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FileUpload.Models
{
    public class Image
    {
        [Key]
        public int ImageId { get; set; }

        public string ImageName { get; set; }

        [NotMapped]
        public IFormFile ImagePath { get; set; }
    }
}
