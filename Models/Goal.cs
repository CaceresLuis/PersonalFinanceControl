using System.ComponentModel.DataAnnotations;

namespace PersonalFinanceControl.Models
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; //comprar ssd
        public double TargetAmount { get; set; } = 0.0; //100
        public double CurrentBalance { get; set; } = 0.0; //50
        public DateTime EndDate { get; set; } //25-06-2024
        public Transaction? Transaction { get; set; }
    }
}
