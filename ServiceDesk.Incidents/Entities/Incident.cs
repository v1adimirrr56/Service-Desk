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
        public string Title { get; set; }
        public DateTime CreateDate { get; set; }
        public virtual Branch Branch { get; set; }
        public int Count { get; set; }
        public ShareType ShareType { get; set; }
        public virtual ICollection<Job> Incidents { get; set; }
        public string ContactEmail { get; set; }
        public virtual Priority Priority { get; set; }
        public string ContactPhone { get; set; }

    }
}
