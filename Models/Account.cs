using System.ComponentModel.DataAnnotations;

namespace PersonalFinanceControl.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; //gasto comida
        public double InitialBalance { get; set; } = 0.0; //100
        public double CurrentBalance { get; set; } = 0.0; //50
        public Transaction? Transaction { get; set; }
    }
}
