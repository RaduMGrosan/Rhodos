namespace Thor.Data.Models
{
    public class ElectricityBill : UtilityBill
    {
        public double Index { get; set; }

        public ElectricityBill(string? companyName, int year, string? month, decimal payed) : base (companyName, year, month, payed) {
        }

        public override string GetTitle()
        {
            return base.GetTitle() + $"The index for the year {this.Year}, month of {this.Month} was {this.Index}";
        }
    }
}
