using System.Reflection.Metadata;

namespace Project.Models
{
    public class Sender
    {
        public int SenderId { get; set; } // Код отправителя
        public string? LastName { get; set; } // Фамилия
        public string? FirstName { get; set; } // Имя
        public string? MiddleName { get; set; } // Отчество
        public string? Position { get; set; } // Должность
        public DateTime HireDate { get; set; } // Дата приема на работу   
    }
}
