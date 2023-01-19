using Application.Interfaces;

namespace Application.Domains;

public class FullTimeEmployedDomain : IFullTimeWorkerSalary
{
    public string Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public decimal MonthlySalary { get; set; }
    public decimal OtherBenefits { get; set; }
    public decimal CalculateNetSalary() => MonthlySalary + OtherBenefits;
}
