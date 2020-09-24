using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pcms.Models
{
    public class Employee
    {
        [Key]
        [Column(TypeName = "bigint")]
        public int sk { get; set; }
        public string emr { get; set; }
        public string yr_mon { get; set; }
        public int emr_cnt { get; set; }
        public string add_user { get; set; }
        public DateTime? add_time { get; set; }
        public string chg_user { get; set; }
        public DateTime? chg_time { get; set; }
    }
}