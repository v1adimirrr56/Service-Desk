using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Context.Infrastructure;
using ServiceDesk.Incidents.Models;
using ServiceDesk.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ServiceDesk.Incidents.Entities
{
    public class Incident : IHasId, IValidatableObject
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
        public DateTime? PassVendorDate { get; set; }
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
        public string CreatorName { get; set; }
        [Required]
        public double Rate { get; set; }
        public bool? UseNotification { get; set; }
        public bool? IsComposite { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var context = (IIncidentsQueryableProvider)validationContext.GetService(typeof(IIncidentsQueryableProvider));

            if (PassVendorDate < DateTime.UtcNow)
                yield return new ValidationResult("Date needs to be more than current", new[] { nameof(PassVendorDate) });
            if (PlanDateResolve < DateTime.UtcNow)
                yield return new ValidationResult("Date needs to be more than current", new[] { nameof(PlanDateResolve) });

            var checkStateCity = context
                .Context
                .Set<StateCityRelation>()
                .Where(x => x.StateId == StateId && x.CityId == CityId)
                .FirstOrDefault();
            if (checkStateCity == null)
                yield return new ValidationResult("There is no city for current state", new[] { nameof(CityId), nameof(StateId) });

        }
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
