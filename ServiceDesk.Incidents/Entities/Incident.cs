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
        [Required, MinLength(5)]
        public string Title { get; set; }
        public virtual State State { get; set; }
        [Required]
        public long StateId { get; set; }
        public virtual Phase Phase { get; set; }
        public virtual long PhaseId { get; set; }
        public virtual Status Status { get; set; }
        public long StatusId { get; set; }
        public virtual Impact Impact { get; set; }
        [Required]
        public long ImpactId { get; set; }
        public virtual Manager Manager { get; set; }
        public long ManagerId { get; set; }
        [Required]
        public DateTime PlanDateResolve { get; set; }
        public DateTime PassVendorDate { get; set; }
        public DateTime CreateDate { get; set; }
        [Required]
        public ShareType ShareType { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        [Required, RegularExpression(@"[^@]+@[^\.]+\..+")]
        public string ContactEmail { get; set; }
        public virtual Priority Priority { get; set; }
        [Required]
        public long PriorityId { get; set; }
        public virtual City City { get; set; }
        [Required]
        public long CityId { get; set; }
        public string ContactPhone { get; set; }
        public string CreatorName { get; set; }
        [Required]
        public double Rate { get; set; }
        public bool UseNotification { get; set; }
        public bool IsComposite { get; set; }
    }
    [Flags]
    public enum NotificationType
    {
        Email = 1,
        Sms = 2,
        InApp = 4
    }

    public enum ShareType
    {
        Internal,
        External
    }
}
