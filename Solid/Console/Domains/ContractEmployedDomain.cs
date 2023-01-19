using Application.Interfaces;

namespace Application.Domains;

public class ContractEmployedDomain : IContractWorkerSalary
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public decimal HourlyRate { get; set; }
    public decimal HoursInMonth { get; set; }
    public decimal CalculateWorkedSalary() => HourlyRate * HoursInMonth;
}
