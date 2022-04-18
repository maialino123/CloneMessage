using CloneMessage.Model;
using CloneMessage.Services.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloneMessage.Services
{
    public class CouponService : IDataService<CouponModel>
    {
        public List<CouponModel> GetAll()
        {
            return new List<CouponModel>
            {
                new CouponModel()
                {
                    Status = "used",
                    ImageUrl = "usedCoupon.png"
                },
                new CouponModel()
                {
                    Status = "target",
                    ImageUrl = "target_coupon.png"
                },
                new CouponModel()
                {
                    Status = "future",
                    ImageUrl = "future_coupon.png"
                },
                new CouponModel()
                {
                    Status = "expired",
                    ImageUrl = "Expired_Coupon.png"
                },
                new CouponModel()
                {
                    Status = "expired",
                    ImageUrl = "Expired_Coupon.png"
                },
                new CouponModel()
                {
                    Status = "expired",
                    ImageUrl = "Expired_Coupon.png"
                },
                new CouponModel()
                {
                    Status = "expired",
                    ImageUrl = "Expired_Coupon.png"
                },
                new CouponModel()
                {
                    Status = "expired",
                    ImageUrl = "Expired_Coupon.png"
                },
                new CouponModel()
                {
                    Status = "expired",
                    ImageUrl = "Expired_Coupon.png"
                }
            };
        }
    }
}
