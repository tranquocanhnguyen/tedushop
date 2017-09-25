﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Model
{
   [Table("Products")]
   public class Product :IAuditable,ISeoable,ISwitchable
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int ID { set; get; }

       [Required]
       [MaxLength(256)]
       public string Name { set; get; }

       [Required]
       [MaxLength(256)]
       public string Alias { set; get; }

       [Required]
       public int CategoryID { set; get; }

       [MaxLength(256)]
       public string Image { set; get; }

       public XElement MoreImages { set; get; }

       public Decimal Price { set; get; }
       public decimal? PromotionPrice { set; get; }
       public int? Warrantly { set; get; }

       [MaxLength(500)]
       public string Description { set; get; }
       public string Content { set; get; }
       public bool? HomeFlag { set; get; }
       public bool? HotFlag { set; get; }
       public int? ViewCount { set; get; }
       [ForeignKey("CategoryID")]
       public virtual ProductCategory ProductCategory { set; get; }

    }
}
