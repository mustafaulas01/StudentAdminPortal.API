﻿using System;

namespace StudentAdminPortal.API.DataModels
{
    public class Adress
    {
        public Guid Id { get; set; }
        public string PhysicalAdress { get; set; }
        public string PostalAdress { get; set; }
        public Guid StudentId { get; set; }
    }
}
