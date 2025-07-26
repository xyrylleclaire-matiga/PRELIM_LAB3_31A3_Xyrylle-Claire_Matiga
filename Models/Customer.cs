namespace PRELIM_LAB3_31A3_Xyrylle_Claire_Matiga.Models
{
    public class Customer : BaseEntity{
        public int CustomerId { get; set; }

        public override string GetDescription(){
            return $"Regular Customer, {GetFullName()} {GetAge()} {CustomerId}";}
    }
}
