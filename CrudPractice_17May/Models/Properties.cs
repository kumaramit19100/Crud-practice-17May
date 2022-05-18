using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CrudPractice_17May.Models
{
    public class Properties
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public int Action { get; set; }
        public int Id { get; set; }
        public DataTable data { get; set; }
    }
}