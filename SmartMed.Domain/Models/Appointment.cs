using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartMed.Domain.Models
{
    public class Appointment
    {
        /// <summary>
        /// Guid приема
        /// </summary>
        [Key]
        public Guid Id { get; set; }

        /// <summary>
        /// Id пациента
        /// </summary>
        public Guid PatientId { get; set; }

        [ForeignKey("PatientId")]
        public virtual User Patient { get; set; }

        /// <summary>
        /// Id доктора
        /// </summary>
        public Guid DoctorId { get; set; }

        [ForeignKey("DoctorId")]
        public virtual User Doctor { get; set; }

        /// <summary>
        /// Id обратной связи
        /// </summary>
        public Guid FeedbackId { get; set; }

        [ForeignKey("FeedbackId")]
        public virtual Feedback Feedback { get; set; }

        /// <summary>
        /// Id статуса приема
        /// </summary>
        public Guid StatusId { get; set; }

        [ForeignKey("StatusId")]
        public virtual Status Status { get; set; }

        /// <summary>
        /// Дата приема
        /// </summary>
        public DateTime Date { get; set; }

    }
}
