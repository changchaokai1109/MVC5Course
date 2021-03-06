namespace MVC5Course.Models
{
   using System;
   using System.Collections.Generic;
   using System.ComponentModel;
   using System.ComponentModel.DataAnnotations;

   [MetadataType(typeof(ProductMetaData))]
   public partial class Product
   {
      public int 訂單數量 {
         get {
            return this.OrderLine.Count;
         }
      }
   }

   public partial class ProductMetaData
   {
      [Required]
      public int ProductId { get; set; }


      [Required(ErrorMessage = "請輸入商品名稱")]

      //[MinLength(3), MaxLength(30)]
      //[RegularExpression("(.+)-(.+)", ErrorMessage = "商品名稱格式錯誤")]
      [DisplayName("商品名稱")]
      [ValidationAttributes.商品名稱必須包含Will字串(ErrorMessage = "商品名稱必須包含Will字串")]
      public string ProductName { get; set; }
      [Required]
      [Range(0, 9999, ErrorMessage = "請設定正確的商品價格範圍")]
      [DisplayFormat(DataFormatString = "{0:0}", ApplyFormatInEditMode = true)]
      [DisplayName("商品價格")]
      public Nullable<decimal> Price { get; set; }
      [Required]
      [DisplayName("是否上架")]
      public Nullable<bool> Active { get; set; }
      [Required]
      [Range(0, 100, ErrorMessage = "請設定正確的商品庫存數量")]
      [DisplayName("商品庫存")]
      public Nullable<decimal> Stock { get; set; }

      public virtual ICollection<OrderLine> OrderLine { get; set; }
   }
}
