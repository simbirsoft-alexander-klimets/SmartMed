using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SmartMed.Domain.Models
{
    public class Rating
    {
        /// <summary>
        /// Guid рейтинга
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Значение рейтинга
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Варианты отзывов для рейтинга
        /// </summary>
        [AllowNull]
        public virtual ICollection<Option> Options { get; set; }

    }
}
