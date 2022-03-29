using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SmartMed.Domain.Models
{
    public class Option
    {
        /// <summary>
        /// Guid варианта отзыва
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Описание варианта отзыва 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Рейтинги, для которых доступен варинат отзыва
        /// </summary>
        [AllowNull]
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
