﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MESSADIIS.Services
{
    public interface IMailService
    {
        bool SendMail(string from, string to, string subject, string body);
    }
}
