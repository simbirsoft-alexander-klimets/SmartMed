using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SmartMed.Domain.Models
{
    public class User : IdentityUser<Guid>, IUser<Guid>
    {
        /// <summary>
        /// Guid пользователя
        /// </summary>
        [Key]
        new public Guid Id { get; set; }

        /// <summary>
        /// Имя пользователя
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Фамилия пользователя
        /// </summary>
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// Отчество пользователя
        /// </summary>
        [AllowNull]
        public string? Patronymic { get; set; }
    }
}
