using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NestedConfig_dotnet.SettingModels;

namespace NestedConfig_dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SettingController : ControllerBase
    {
        private readonly SettingTest setting;

        public SettingController(SettingTest setting)
        {
            this.setting = setting;
        }

        [HttpGet]
        public IActionResult getAppSetting()
        {
            return Ok(setting);
        }
    }
}