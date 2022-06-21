namespace Vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignupFee { get; set; }
        public byte DuationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}
