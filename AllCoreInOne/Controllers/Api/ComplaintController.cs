using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AllCoreInOne.Services.Complaint;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AllCoreInOne.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComplaintController : ControllerBase
    {
        private IComplaintService ComplaintService { get; }
        public ComplaintController(IComplaintService complaintService)
        {
            ComplaintService = complaintService;
        }

        [HttpGet]
        public async Task<IActionResult> FetchComplaint(CancellationToken ct)
        {
            var employees = await ComplaintService.FetchComplaint(ct);
            return Ok(employees);
        }

        [HttpPost]
        public async Task<IActionResult> LogComplain([FromBody] Models.Complaint complaint)
        {
            if (ModelState.IsValid)
            {
                return Ok(await ComplaintService.CreateComplaint(complaint));
            }
            return BadRequest();
        }

    }
}