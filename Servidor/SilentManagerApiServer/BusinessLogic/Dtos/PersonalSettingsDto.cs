﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SilentManagerApiServer.BusinessLogic.Dtos
{
    public class PersonalSettingsDto
    {
        public int? SilentMode { get; set; }
        public int UserId { get; set; }
        public string PhoneNumber { get; set; }
    }
}
