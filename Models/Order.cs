using System.ComponentModel.DataAnnotations;
//Так как это тестовое задание, модель была упрощена до одного представления.
//В идеале, нужно разбить ее на несколько сущностей
//и связать между собой для большей гибкости и удобства.

namespace WebApplication3.Models
{
    public class Order
    {
        public int Id { get; set; } // Автоматически генерируемый номер заказа

        [Required(ErrorMessage = "Город отправителя обязателен")] // Указывает, что это поле обязательно для заполнения
        public string SenderCity { get; set; }

        [Required(ErrorMessage = "Адрес отправителя обязателен")]
        public string SenderAddress { get; set; }

        [Required(ErrorMessage = "Город получателя обязателен")]
        public string RecipientCity { get; set; }

        [Required(ErrorMessage = "Адрес получателя обязателен")]
        public string RecipientAddress { get; set; }

        [Required(ErrorMessage = "Вес груза обязателен")]
        [Range(1, 10000, ErrorMessage = "Вес груза должен быть между 1 и 10000 кг")] // Ограничение на вес груза от 1 до 10000 кг
        public double Weight { get; set; }

        [Required(ErrorMessage = "Дата забора груза обязательна")]
        [DataType(DataType.Date)]// Указывает, что поле представляет собой дату
        public DateTime PickupDate { get; set; }
    }
}