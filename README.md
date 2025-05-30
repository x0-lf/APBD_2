# APBD_2 - LINQ Exercises with Unit Testing

## Overview

This project is part of **Cwiczenia5** for the APBD course and demonstrates the use of **LINQ (Language Integrated Query)** in C# to perform data queries over in-memory collections. The goal of this assignment is to implement **20 LINQ queries** across two classes:

* `EmpDeptSalgradeTests`
* `AdvancedEmpDeptTests`

Each query must satisfy the requirements of provided unit tests, and in some cases, custom tests should be implemented to ensure correctness.

## Objectives

* Practice LINQ syntax and various LINQ methods (e.g., `Select`, `Where`, `Join`, `GroupBy`, `Aggregate`, etc.)
* Implement test-driven development using unit tests
* Understand data manipulation patterns commonly used in enterprise applications

## Project Structure

```
APBD_2/
├── EmpDeptSalgradeTests.cs      # Basic LINQ queries
├── AdvancedEmpDeptTests.cs      # More complex LINQ queries
├── Emp.cs, Dept.cs, Salgrade.cs # Sample data models (Employee, Department, Salary Grade)
├── SampleData.cs                # Pre-filled collections for testing
└── Tests/                       # xUnit test files validating LINQ results
```

## How to Run

1. **Clone the repository**

```bash
git clone https://github.com/x0-lf/APBD_2.git
cd APBD_2
```

2. **Open in IDE**

   * Use Visual Studio or JetBrains Rider.
   * Ensure the target framework is .NET 9 or later.

3. **Run Unit Tests**

   * Use built-in test explorer or run via terminal:

```bash
dotnet test
```

## Tips and Resources

* Follow LINQ methods listed at:
  [https://www.tutorialsteacher.com/linq/what-is-linq](https://www.tutorialsteacher.com/linq/what-is-linq)
* Make use of method chaining and query expressions
* Use `Assert` methods to check if your queries return the correct results

## Requirements

* [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
* Basic understanding of C# and LINQ
* xUnit for unit testing

---

Feel free to fork this repository and use the code for educational purposes. Contributions and improvements are welcome!

### Previous Projects

**[APBD_1 - Simple yet Advanced Logistics Manager Example](https://github.com/x0-lf/APBD_1)**

### Next Projects in the Series

**[APBD_3 - REST API Travel Agency](https://github.com/x0-lf/APBD_3)**

**[APBD_4 - Warehouse Management](https://github.com/x0-lf/APBD_4)**

**[APBD_5 - EF (Code First) App that helps to manage prescriptions](https://github.com/x0-lf/APBD_5)**

**[APBD_6 – EF (Database First) Client and Trip Management API](https://github.com/x0-lf/APBD_6)**


