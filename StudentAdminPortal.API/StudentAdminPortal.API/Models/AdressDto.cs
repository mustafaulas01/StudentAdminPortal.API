using System;

namespace StudentAdminPortal.API.Models
{
    public class AdressDto
    {
        public Guid Id { get; set; }
        public string PhysicalAdress { get; set; }
        public string PostalAdress { get; set; }
        public Guid StudentId { get; set; }
    }
}
