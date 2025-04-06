using Tutorial3.Models;

public static class Database
{
    public static List<Dept> GetDepts() => new List<Dept>
    {
        new Dept { DeptNo = 10, DName = "ACCOUNTING", Loc = "NEW YORK" },
        new Dept { DeptNo = 20, DName = "RESEARCH", Loc = "DALLAS" },
        new Dept { DeptNo = 30, DName = "SALES", Loc = "CHICAGO" },
        new Dept { DeptNo = 40, DName = "OPERATIONS", Loc = "BOSTON" }
    };

    public static List<Emp> GetEmps() => new List<Emp>
    {
        new Emp { EmpNo = 7369, EName = "SMITH", Job = "CLERK", Mgr = 7902, HireDate = new DateTime(1980, 12, 17), Sal = 800, Comm = null, DeptNo = 20 },
        new Emp { EmpNo = 7499, EName = "ALLEN", Job = "SALESMAN", Mgr = 7698, HireDate = new DateTime(1981, 2, 20), Sal = 1600, Comm = 300, DeptNo = 30 },
        new Emp { EmpNo = 7521, EName = "WARD", Job = "SALESMAN", Mgr = 7698, HireDate = new DateTime(1981, 2, 22), Sal = 1250, Comm = 500, DeptNo = 30 },
        new Emp { EmpNo = 7839, EName = "KING", Job = "PRESIDENT", Mgr = null, HireDate = new DateTime(1981, 11, 17), Sal = 5000, Comm = null, DeptNo = 10 },
        new Emp { EmpNo = 7902, EName = "FORD", Job = "CLERK", Mgr = 7839, HireDate = new DateTime(1981, 11, 17), Sal = 5000, Comm = null, DeptNo = 10 }
    };

    public static List<Salgrade> GetSalgrades() => new List<Salgrade>
    {
        new Salgrade { Grade = 1, Losal = 700, Hisal = 1200 },
        new Salgrade { Grade = 2, Losal = 1201, Hisal = 1400 },
        new Salgrade { Grade = 3, Losal = 1401, Hisal = 2000 },
        new Salgrade { Grade = 4, Losal = 2001, Hisal = 3000 },
        new Salgrade { Grade = 5, Losal = 3001, Hisal = 9999 }
    };
}