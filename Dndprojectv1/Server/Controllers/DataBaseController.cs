﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dndprojectv1.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataBaseController : ControllerBase
    {
        [HttpGet("[action]")]
        public async Task GetCharacter()
        { 
            
        }
        
    }
}