using ServiceDesk.Incidents.Selector;
using ServiceDesk.SmartUI.FormAttribute;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ServiceDesk.Incidents.Models
{
    public class IncidentDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        [DateTimePicker]
        public DateTime CreateDate { get; set; }
        [Checkbox]
        public bool Archive { get; set; }
        [DropDownList(typeof(BranchSelector))]
        [Required]
        public string Branch { get; set; }
        [Radio(typeof(BranchSelector))]
        public ShareType ShareType { get; set; }
    }

    public enum ShareType
    {
        Internal,
        External
    }

}

