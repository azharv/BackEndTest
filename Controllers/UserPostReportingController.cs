using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndTest.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserPostReportingController : ControllerBase
    {
        private readonly IUserPostReporting reporting;
        public UserPostReportingController(IUserPostReporting reporting)
        {
            this.reporting = reporting;
        }

        [HttpGet]
        [Route("GetUserPostReporting")]
        public List<UserPostReporting> GetUserPostReporting()
        {

            List<UserPostReporting> UserPostReporting = reporting.GetUserPostReportingList().ToList();
            return UserPostReporting;
        }
    }
}
