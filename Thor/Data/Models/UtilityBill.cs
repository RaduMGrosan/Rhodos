using Thor.Data.Enums;
using Thor.Data.Models;

namespace Thor.Data
{
    public class UtilityBill: BaseModel
    {

        public BillTypeEnum Type { get; set; }

        public string? CompanyName { get; set; }

        public int? Year { get; set; }

        public string? Month { get; set; }

        public decimal? Payed { get; set; }

        public UtilityBill(string? companyName, int? year, string? month, decimal? payed) {
            this.CompanyName = companyName;
            this.Year = year;
            this.Month = month;
            this.Payed = payed;
        }

        public virtual string GetTitle() {
            return $"The company {this.CompanyName} provides {GetBillType(this.Type)} for clients.";
        }

        public string GetBillType(BillTypeEnum type) {
            return type switch
            {
                BillTypeEnum.Electricity => "Electricity",
                BillTypeEnum.CableNet => "CableNet",
                BillTypeEnum.Heat => "Heat",
                BillTypeEnum.Maintenance => "Maintenance",
                BillTypeEnum.Water => "Water",
                BillTypeEnum.Garbage => "Garbage",
                _ => "No bill type introduced.",
            };
        }
    }
}