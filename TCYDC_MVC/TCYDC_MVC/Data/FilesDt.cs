using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TCYDC_MVC.Models
{
    public class FilesDt
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }
        public byte[] DataFiles { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
