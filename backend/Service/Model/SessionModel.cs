﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Models
{
    public class SessionModel
    {
        public Guid SessionId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}