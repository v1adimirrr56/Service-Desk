using Microsoft.AspNetCore.Mvc;
using ServiceDesk.Incidents.Entities;
using ServiceDesk.Incidents.Selector;
using ServiceDesk.SmartUI.Forms;
using ServiceDesk.SmartUI.Forms.FormFieldAttributes;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServiceDesk.Incidents.Models
{
    [Form]
    public class IncidentDto
    {
        [HiddenInput]
        public long Id { get; set; }
        [MinLength(5)]
        public string Title { get; set; }
        [DropDownList(typeof(StateSelector))]
        [DisplayName("State")]
        public long StateId { get; set; }
        [DropDownList(typeof(CitySelector))]
        [Required]
        [DisplayName("City")]
        public long CityId { get; set; }
        [DropDownList(typeof(ImpactSelector))]
        [DisplayName("Impact")]
        public long ImpactId { get; set; }
        [DropDownList(typeof(ManagerSelector))]
        [DisplayName("Manager")]
        public long ManagerId { get; set; }
        [DropDownList(typeof(PrioritySelector))]
        [DisplayName("Priority")]
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

