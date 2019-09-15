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
        [Required]
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public bool Archive { get; set; }

        public string Branch { get; set; }
        [Range(0, 1)]
        public int Count { get; set; }
        [Required]
        public ShareType ShareType { get; set; }
    }
}
