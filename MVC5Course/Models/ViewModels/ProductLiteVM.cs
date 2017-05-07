using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models.ViewModels
{  /// <summary>
/// 這是一個精簡版的product用來建置product用
/// </summary>
   public class ProductLiteVM
   {
      public int ProductId { get; set;}
      [Required]
      [MinLength(5)]
      public string ProductName { get; set;}
      [Required]
      public Nullable<decimal> Price { get; set;}
      [Required]
      public Nullable<decimal> Stock { get; set;}
   }
}