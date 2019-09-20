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
        public string Title { get; set; }
        public string StatusName { get; set; }
        public string PhaseName { get; set; }
        [DropDownList(typeof(StateSelector))]
        public string StateName { get; set; }
        public long StateId { get; set; }
        [DropDownList(typeof(CitySelector))]
        public string CityName { get; set; }
        public long CityId { get; set; }
        [DropDownList(typeof(ImpactSelector))]
        public string ImpactName { get; set; }
        public long ImpactId { get; set; }
        [DropDownList(typeof(ManagerSelector))]
        public string ManagerFirstName { get; set; }
        public long ManagerId { get; set; }
        [DropDownList(typeof(PrioritySelector))]
        public string PriorityPriorityType { get; set; }
        public long PriorityId { get; set; }
        [DatePicker]
        [DisplayName("Plan date resolve")]
        public DateTime PlanDateResolve { get; set; }
        [Required, Range(0, 5)]
        public double Rate { get; set; }
        [Checkbox]
        [DisplayName("Notification type")]
        public NotificationType NotificationType { get; set; }
        [Radio]
        public ShareType ShareType { get; set; }
        [DisplayName("Contact email")]
        public string ContactEmail { get; set; }
        [DisplayName("Contact phone")]
        public string ContactPhone { get; set; }

    }
}

