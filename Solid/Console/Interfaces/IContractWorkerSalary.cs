namespace Application.Interfaces;

public interface IContractWorkerSalary : IBaseWorker
{
    decimal HourlyRate { get; set; }
    decimal HoursInMonth { get; set; }
    decimal CalculateWorkedSalary();
}
