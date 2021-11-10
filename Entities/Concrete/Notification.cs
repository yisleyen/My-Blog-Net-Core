﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Notification
    {
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
        public string TypeSymbol { get; set; }
        public string TypeStatus { get; set; }
        public string Detail { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
