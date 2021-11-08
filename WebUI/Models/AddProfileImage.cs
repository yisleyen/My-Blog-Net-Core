using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models
{
    public class AddProfileImage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        public IFormFile Image { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}
