namespace Project.Models
{
    public class Document
    {
        public int DocumentId { get; set; } // Код документа
        public string? DocumentNumber { get; set; } // Номер документа
        public DateTime RegistrationDate { get; set; } // Дата регистрации
        public string? Summary { get; set; } // Краткое содержание документа
        public string? DocumentType { get; set; } // Тип документа
        public int RecipientOrganizationId { get; set; } // Код организации-отправителя
        public int SenderId { get; set; } // Код отправителя

        public Sender? Sender { get; set; } // Связь с отправителем
        public RecipientOrganization? RecipientOrganization { get; set; } // Связь с организацией-отправителем
    }
}
