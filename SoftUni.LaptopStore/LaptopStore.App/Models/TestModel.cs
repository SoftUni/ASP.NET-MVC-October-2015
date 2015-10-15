using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LaptopStore.App.Models
{
    public class TestModel
    {
        [DisplayName("Date created")]
        public DateTime Date { get; set; }

        [HiddenInput]
        public Address Address { get; set; }
    }
}