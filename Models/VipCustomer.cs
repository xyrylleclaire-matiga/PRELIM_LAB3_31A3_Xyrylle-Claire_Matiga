namespace PRELIM_LAB3_31A3_Xyrylle_Claire_Matiga.Models
{
    public class VipCustomer : Customer
    {
        public bool IsVip { get; set; }

        public override string GetDescription()
        {
            return $"VIP Customer, {GetFullName()} {GetAge()} {CustomerId}";
        }
    }
}
