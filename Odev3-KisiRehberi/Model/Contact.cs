using System;
using System.Collections.Generic;

namespace Odev3_KisiRehberi.Model
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
