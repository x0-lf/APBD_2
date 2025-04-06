namespace Tutorial3.Models;

public class Emp
{
    public int EmpNo { get; set; }
    public string EName { get; set; }
    public string Job { get; set; }
    public int? Mgr { get; set; }
    public DateTime HireDate { get; set; }
    public decimal Sal { get; set; }
    public decimal? Comm { get; set; }
    public int DeptNo { get; set; }
}
