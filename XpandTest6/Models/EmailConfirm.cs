using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace XpandTest6.Models
{
    public class EmailConfirm
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

    }
}
