using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleAuthSystem.Model
{
    public class SignInRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    public class SignInResponse
    {
        public int UserId { get; set; }
        public bool IsSuccess { get; set; }
        public string Message { get; set; }

        public bool IsActive { get; set; }
        public ObjectResult ObR { get; set; }
    }
    
}
