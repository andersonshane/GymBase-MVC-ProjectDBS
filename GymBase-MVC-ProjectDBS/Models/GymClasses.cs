using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GymBase_MVC_ProjectDBS.Models
{
    [Table("GymClasses")]
    public class GymClasses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // since you set the IDs in code
        public int GymIDModels { get; set; }
        public string GymClassTime { get; set; }
        public string GymClassName { get; set; }
    }
}