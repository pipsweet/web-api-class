namespace EmployeesApi.Models;

public record DepartmentHiringRequestResponse
{
    public int Id { get; set }
    public string CandidateId { get; set; } = string.Empty;
    public decimal? StartingSalary { get; set; }
    public HiringRequestStatus Status { get; set; } = HiringRequestStatus.Hired;
}
public enum HiringRequestStatus { Hired }