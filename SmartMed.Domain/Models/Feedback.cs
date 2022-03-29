using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SmartMed.Domain.Models
{
    public class Feedback
    {
        /// <summary>
        /// Guid обратной связи
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Id рейтинга обратной связи
        /// </summary>
        public Guid RatingId { get; set; }

        [ForeignKey("RatingId")]
        public virtual Rating Rating { get; set;}

        /// <summary>
        /// Id дополнительного отыва обратной связи
        /// </summary>
        public Guid OptionId { get; set; }

        [ForeignKey("OptionId")]
        [AllowNull]
        public virtual Option Option { get; set; }

        /// <summary>
        /// Дополнительный коментарий обратной связи
        /// </summary>
        [AllowNull]
        public string? Details { get; set; }

        /// <summary>
        /// Коментарий обратной связи
        /// </summary>
        public string? Comment { get; set; }
    }
}
