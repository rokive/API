﻿using System;

namespace API.VModel
{
    public class RegistrationVModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DOF { get; set; }
    }
}
