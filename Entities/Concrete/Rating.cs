using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Rating
    {
        [Key]
        public int Id { get; set; }
        public int BlogId { get; set; }
        public int Score { get; set; }
        public int RatingCount { get; set; }
    }
}
