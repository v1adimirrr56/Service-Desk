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
        [Required, MinLength(5)]
        public string Title { get; set; }
        [DropDownList(typeof(StateSelector))]
        [DisplayName("State")]
        [Required]
        public long StateId { get; set; }
        [DropDownList(typeof(CitySelector))]
        [Required]
        [DisplayName("City")]
        public long CityId { get; set; }
        [DropDownList(typeof(ImpactSelector))]
        [DisplayName("Impact")]
        [Required]
        public long ImpactId { get; set; }
        [DropDownList(typeof(ManagerSelector))]
        [DisplayName("Manager")]
        public long ManagerId { get; set; }
        [DropDownList(typeof(PrioritySelector))]
        [DisplayName("Priority")]
        [Required]
        public long PriorityId { get; set; }
        [DatePicker]
        [DisplayName("Plan date resolve")]
        [Required]
        public DateTime PlanDateResolve { get; set; }
        [DatePicker]
        [DisplayName("Pass to the vendor")]
        public DateTime? PassVendorDate { get; set; }
        [Required, Range(1, 5)]
        [InputNumber]
        public double Rate { get; set; }
        [Checkbox]
        [DisplayName("Subscribe to notifications")]
        public bool? UseNotification { get; set; }
        [Checkbox]
        [DisplayName("Composite")]
        public bool? IsComposite { get; set; }
        [Radio]
        [Required]
        [DisplayName("Choose the share type")]
        public ShareType ShareType { get; set; }
        [DisplayName("Contact email")]
        [Required, RegularExpression(@"[^@]+@[^\.]+\..+")]
        public string ContactEmail { get; set; }

    }
}

