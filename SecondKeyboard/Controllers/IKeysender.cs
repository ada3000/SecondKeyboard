using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SecondKeyboard.Controllers
{
    public interface IKeySender
    {
        void Send(string value, bool ctrl = false, bool shift = false, bool alt = false);
    }
}