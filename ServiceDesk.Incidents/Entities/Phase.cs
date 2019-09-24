﻿using ServiceDesk.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Incidents.Entities
{
    public class Phase : IHasId
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
