namespace SmartMed.Domain.Models
{
    public class Response
    {
        /// <summary>
        /// Статус ответа
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Тело ответа
        /// </summary>
        public string Message { get; set; }
    }
}
