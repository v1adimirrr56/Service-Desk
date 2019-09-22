using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Incidents.Selector;
using ServiceDesk.SmartUI;
using ServiceDesk.SmartUI.FormFieldAttributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServiceDesk.Incidents.Models
{
    [Form]
    public class IncidentDto
    {
        public long Id { get; set; }
        [Required, MinLength(5)]
        public string Title { get; set; }
        [DropDownList(typeof(StateSelector))]
        [DisplayName("State")]
        public string StateName { get; set; }
        public long StateId { get; set; }
        [DropDownList(typeof(CitySelector))]
        [DisplayName("City")]
        public string CityName { get; set; }
        public long CityId { get; set; }
        [DropDownList(typeof(ImpactSelector))]
        [DisplayName("Impact")]
        public string ImpactName { get; set; }
        public long ImpactId { get; set; }
        [DropDownList(typeof(ManagerSelector))]
        [DisplayName("Manager")]
        public string Manager { get; set; }
        public long ManagerId { get; set; }
        [DropDownList(typeof(PrioritySelector))]
        [DisplayName("Priority")]
        public string PriorityPriorityType { get; set; }
        public long PriorityId { get; set; }
        [DatePicker]
        [DisplayName("Plan date resolve")]
        public DateTime PlanDateResolve { get; set; }
        [DatePicker]
        [DisplayName("Pass to the vendor")]
        public DateTime PassVendorDate { get; set; }
        [Range(0, 5)]
        public double Rate { get; set; }
        [Checkbox]
        [DisplayName("Subscribe to notifications")]
        [Required]
        public bool UseNotification { get; set; }
        [Checkbox]
        [DisplayName("Composite")]
        public bool IsComposite { get; set; }
        [Radio]
        [Required]
        [DisplayName("Choose the share type")]
        public ShareType ShareType { get; set; }
        [DisplayName("Contact email")]
        [RegularExpression(@"[^@]+@[^\.]+\..+")]
        public string ContactEmail { get; set; }
        [DisplayName("Contact phone")]
        public string ContactPhone { get; set; }

    }
}

