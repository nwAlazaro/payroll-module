
using Microsoft.AspNetCore.Mvc;
using PayrollModule.Models;
using PayrollModule.Services;

namespace PayrollModule.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PayrollController : ControllerBase
    {
        private readonly IPayrollService _payrollService;

        public PayrollController(IPayrollService payrollService)
        {
            _payrollService = payrollService;
        }

        [HttpPost("calculate")]
        public IActionResult CalculatePayroll([FromBody] Employee employee)
        {
            var result = _payrollService.CalculatePayroll(employee);
            return Ok(result);
        }
    }
}
