using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController] //USE IT... VERY POWERFUL
    [Route("api/[controller]")] // GET /api/users

    public class BaseApiController : ControllerBase
    {

    }
}
     