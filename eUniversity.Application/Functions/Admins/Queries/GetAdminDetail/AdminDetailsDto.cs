﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eUniversity.Application.Functions.Admins.Queries.GetAdminDetail
{
    public class AdminDetailsDto
    {
        public string AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
