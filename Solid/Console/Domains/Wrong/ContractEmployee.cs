using Application.Interfaces;

namespace Application.Domains.Wrong;

public class ContractEmployee : IWorker
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public decimal MonthlySalary { get; set; }
    public decimal OtherBenefits { get; set; }
    public decimal HourlyRate { get; set; }
    public decimal HoursInMonth { get; set; }
    public decimal CalculateNetSalary() => throw new NotImplementedException();
    public decimal CalculateWorkedSalary() => HourlyRate * HoursInMonth;
}
