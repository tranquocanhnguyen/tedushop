﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TeduShop.Model.Abstract
{
   public abstract class Auditable : IAuditable
    {
     public   DateTime? CreatedDate { set; get; }

       [MaxLength(256)]
     public string CreatedBy { set; get; }
     public DateTime? UpdatedDate { set; get; }
       [MaxLength(256)]

     public string UpdatedBy { set; get; }

    }
}
