namespace Project.Models
{
    public class RecipientOrganization
    {
        public int RecipientOrganizationId { get; set; } // Код организации-получателя
        public string? ShortName { get; set; } // Сокращенное название
        public string? FullName { get; set; } // Полное название
        public string? LegalAddress { get; set; } // Юридический адрес
        public string? Phone { get; set; } // Телефон
        public string? DirectorFullName { get; set; } // ФИО руководителя
    }
}
