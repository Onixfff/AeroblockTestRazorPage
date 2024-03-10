using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aeroblock.DataAccess.Rail.Models
{
    public class OrderRzdEntity
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Costumer { get; set; }

        public string Material { get; set; }

        public string Weight { get; set; }

        public int Col { get; set; }

        public int SumWeight { get; set; }

        public int Fact { get; set; }

        public bool Order { get; set; }

        public string Old { get; set; }

        public string Comment { get; set; }

        public DateTime DateOrder { get; set; }
    }
}