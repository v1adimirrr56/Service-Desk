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
        [DatePicker]
        public DateTime CreateDate { get; set; }
        [DropDownList(typeof(BranchSelector))]
        [Required, MaxLength(5), MinLength(1)]
        public Branch Branch { get; set; }
        [Required, Range(0, 5)]
        public int Count { get; set; }
        [Checkbox]
        public NotificationType NotificationType { get; set; }
        [Radio(typeof(BranchSelector))]
        public ShareType ShareType { get; set; }
        public string ContactEmail { get; set; }
        public Priority Priority { get; set; }
        public string ContactPhone { get; set; }

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

