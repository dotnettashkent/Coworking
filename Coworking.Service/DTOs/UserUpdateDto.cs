﻿namespace Coworking.Service.DTOs
{
    public class UserUpdateDto
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string GroupName { get; set; }
    }
}
