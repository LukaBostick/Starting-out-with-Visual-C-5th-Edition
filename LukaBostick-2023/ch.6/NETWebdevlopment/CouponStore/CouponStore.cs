using NETWebdevlopment.modles;

namespace NETWebdevlopment.CouponStore
{
    public class CouponStore
    {
        public static List<Coupon> couponList = new List<Coupon>
        {
            new Coupon{Id=1, Name="10FF", Percent=10,IsActive=true},
            new Coupon{Id=1, Name="10FF", Percent=20,IsActive=true}
        };
    }
}
