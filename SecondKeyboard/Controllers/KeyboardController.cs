using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace SecondKeyboard.Controllers
{
    public class KeyboardController : ApiController
    {
        public static IKeySender KeySender;
        public KeyboardController()
        {
        }
        
        // GET api/Me
        public string Post(KeyModel key)
        {
            Console.WriteLine(key);

            KeySender.Send(key.Value, key.Ctrl, key.Shift, key.Alt);

            return "Hometown";
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