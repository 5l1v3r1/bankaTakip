using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bankaTakip.Models
{
    public class ProjectCategory
    {
        [Key]
        public int No { get; set; }
        //[Key, Column(Order = 0)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KategoriNo { get; set; }
        //[Key, Column(Order = 1)]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProjeNo { get; set; }

        [ForeignKey("KategoriNo")]
        public virtual ProjectForCategory ProjectForCategory { get; set; }
        [ForeignKey("ProjeNo")]
        public virtual Project Project { get; set; }
    }
}