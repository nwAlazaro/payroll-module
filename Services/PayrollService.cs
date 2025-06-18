
using PayrollModule.Models;

namespace PayrollModule.Services
{
    public interface IPayrollService
    {
        decimal CalculatePayroll(Employee employee);
    }

    public class PayrollService : IPayrollService
    {
        public decimal CalculatePayroll(Employee employee)
        {
            decimal gross = employee.BaseSalary + employee.Bonus;
            decimal net = gross - (gross * employee.TaxRate);
            return net;
        }
    }
}
