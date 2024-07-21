using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Angular.NetCore.Server.Models.Domain
{
    public class Contact
    {
        public Guid ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string? Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [DefaultValue(0)]
        public bool favorite { get; set; }
    }
}
