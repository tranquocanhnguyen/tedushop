﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Model
{
    [Table("Pages")]
  public  class Page:IAuditable, ISeoable, ISwitchable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }


        [Required]
        [MaxLength(256)]
        public string Name { set; get; }


        [Column(TypeName="varchar")]
        [Required]
        [MaxLength(256)]
        public string Alias { set; get; }
        public string Content{set;get;}
    }
}
