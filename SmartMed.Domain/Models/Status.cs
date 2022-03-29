using System;
using System.ComponentModel.DataAnnotations;

namespace SmartMed.Domain.Models
{
    public class Status
    {
        /// <summary>
        /// Guid статуса отзыва
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Описание статуса
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Блокирует ли статус возможность оценить прием
        /// </summary>
        public bool IsBlocked { get; set; }
    }
}
