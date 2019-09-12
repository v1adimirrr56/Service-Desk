using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Incidents.Models;
using ServiceDesk.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServiceDesk.Incidents.Entities
{
    public class Incident : IHasId
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        [Required]
        public bool Archive { get; set; }
        public string Branch { get; set; }
        public ShareType ShareType { get; set; }
    }
}
