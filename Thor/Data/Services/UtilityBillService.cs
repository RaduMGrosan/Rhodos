using System.Reflection.Metadata.Ecma335;
using Thor.Data.Enums;
using Thor.Data.Models;
using Thor.Data.Services.Interfaces;

namespace Thor.Data
{
    public class UtilityBillService: IUtilityBillService
    {
        private static readonly UtilityBill[] Bills = new[]
        {
        new HeatBill ("Eon", 2023, "June", 50),
        new ElectricityBill("Hidroelectrica", 2023, "June", 150),
        new CableNetBill("Digi", 2023, "June", 70),
        new MaintenanceBill("Bloc", 2023, "June", 200),
        new HeatBill("Eon", 2023, "July", 20),
        new ElectricityBill("Hidroelectrica", 2023, "July", 250),
        new CableNetBill("Digi", 2023, "July", 70),
        new MaintenanceBill("Bloc", 2023, "July", 210),
        new HeatBill("Eon", 2023, "August", 10),
        new ElectricityBill("Hidroelectrica", 2023, "August", 270),
        new CableNetBill("Digi", 2023, "August", 70),
        new MaintenanceBill("Bloc", 2023, "August", 200),
        new UtilityBill(null, null, null, null)
        };

        public Task<UtilityBill[]> GetBillsAsync()
        {
            return Task.FromResult(Bills);
        }

        public Task<UtilityBill[]> GetBillsByType(string? type) {
            var bills = type == BillTypeEnum.All.ToString() ? Bills : Bills.Where(x => x.BillType?.Value.ToString() == type).ToArray();
            return Task.FromResult(bills);
        }

        public Task<UtilityBill[]> GetBillsByCompany(string? companyName)
        {
            var bills = companyName == "All" ? Bills : Bills.Where(x => x.CompanyName == companyName).ToArray();
            return Task.FromResult(bills);
        }

        public Task<List<string?>> GetCompanyList() {
            var companyList = Bills.Select(x => x.CompanyName).Distinct().ToList();
            return Task.FromResult(companyList);
        }
    }
}