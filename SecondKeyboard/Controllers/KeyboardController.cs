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
using Microsoft.VisualBasic.Devices;

namespace SecondKeyboard.Controllers
{
    public class KeyboardController : ApiController
    {
        public static IKeySender KeySender;
        public KeyboardController()
        {
        }
        
        // GET api/Me
        public GetViewModel Post(KeyModel key)
        {
            Console.WriteLine(key);

            KeySender.Send(key.Value, key.Ctrl, key.Shift, key.Alt);

            return new GetViewModel() { Hometown = "Hometown" };
        }

        public class KeyModel
        {
            public bool Shift;
            public bool Ctrl;
            public bool Alt;
            public string Value;

            public override string ToString()
            {
                return $"Shift:{Shift}, Ctrl:{Ctrl}, Alt:{Alt}, Value:{Value}";
            }
        }
    }
}