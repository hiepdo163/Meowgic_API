﻿using Meowgic.Shares;
using Meowgic.Shares.Enum;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Meowgic.Repositories.Models.Request.Account
{
    public class Register
    {
        [Required(ErrorMessage = "Name is required"), MinLength(2), MaxLength(30)]
        public required string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please input a right email address")]
        public required string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^{8,}$", ErrorMessage = "Password must have minimum 8 characters")]
        public required string Password { get; set; }

        [JsonConverter(typeof(DateOnlyJsonConverter))]
        public required DateOnly? Dob { get; set; }

        [EnumDataType(typeof(Gender), ErrorMessage = "Invalid gender")]
        public string Gender { get; set; } = "Other";

        public string? Phone { get; set; }

        public IFormFile? Images { get; set; }
    }
}
