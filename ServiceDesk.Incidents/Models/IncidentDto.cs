using Microsoft.AspNetCore.Mvc;
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
        public string Name { get; set; }
        [DatePicker]
        public DateTime CreateDate { get; set; }
        [Radio(typeof(BranchSelector))]
        public bool Archive { get; set; }
        [DropDownList(typeof(BranchSelector))]
        [Required, MaxLength(5), MinLength(1)]
        public string Branch { get; set; }
        [Required, Range(0, 5)]
        public int Count { get; set; }
        [Radio(typeof(BranchSelector))]
        public ShareType ShareType { get; set; }
    }

    public enum ShareType
    {
        Internal,
        External
    }

}

