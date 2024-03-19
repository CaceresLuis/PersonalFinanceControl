using System.ComponentModel.DataAnnotations;

namespace PersonalFinanceControl.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; } //18-03-2024
        public string Description { get; set; } = string.Empty; //gasto en comida
        public double Amount { get; set; } = 0.0; //3.85
        public string Type { get; set; } = string.Empty; //egreso
        public IEnumerable<Account>? Accounts { get; set; }
        public IEnumerable<Goal>? Goals { get; set; }
    }
}
