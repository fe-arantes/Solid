namespace Application.Interfaces;

public interface IFullTimeWorkerSalary : IBaseWorker
{
    decimal MonthlySalary { get; set; }
    decimal OtherBenefits { get; set; }
    decimal CalculateNetSalary();
}
