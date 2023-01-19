namespace Application.Interfaces;

public interface IWorker
{
    string Id { get; set; }
    string Name { get; set; }
    string Email { get; set; }
    decimal MonthlySalary { get; set; }
    decimal OtherBenefits { get; set; }
    decimal HourlyRate { get; set; }
    decimal HoursInMonth { get; set; }
    decimal CalculateNetSalary();
    decimal CalculateWorkedSalary();
}
