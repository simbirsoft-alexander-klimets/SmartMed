using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace SmartMed.Domain.Models
{
    public class Role : IdentityRole<Guid>
    {
        /// <summary>
        /// Guid роли пользователя
        /// </summary>
        [Key]
        new public Guid Id { get; set; }
    }
}
