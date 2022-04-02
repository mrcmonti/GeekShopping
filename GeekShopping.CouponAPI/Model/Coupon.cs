using GeekShopping.CouponAPI.Model.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeekShopping.CouponAPI.Model
{
    [Table("coupon")]
    public class Coupon : BaseEntity
    {
        [Column("name")]
        [Required]
        [StringLength(30)]
        public string CouponCode { get; set; }
        
        [Column("discount_amount", TypeName = "decimal(12,2)")]
        [Required]
        public decimal DiscountAmount { get; set; }



    }
}
