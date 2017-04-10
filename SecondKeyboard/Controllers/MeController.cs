using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Owin;
using SecondKeyboard.Models;

namespace SecondKeyboard.Controllers
{
    public class MeController : ApiController
    {
        public MeController()
        {
        }
        
        // GET api/Me
        public GetViewModel Get()
        {
            return new GetViewModel() { Hometown = "Hometown" };
        }
    }
}