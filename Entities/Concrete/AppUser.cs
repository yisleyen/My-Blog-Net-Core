using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string NameSurname { get; set; }
        public virtual ICollection<Message2> Sender { get; set; }
        public virtual ICollection<Message2> Receiver { get; set; }
    }
}
