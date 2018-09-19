using System.ComponentModel.DataAnnotations;

namespace Application.Core
{
    public class HouseDTO
    {
        public int HouseID { get; set; }
        [Required]//NOT NULL IN TABLE
        public int Number { get; set; }
        [Required, StringLength(300)]
        public string Street { get; set; }
        public int NumRooms { get; set; }
        public int NumBathrooms { get; set; }
        public int Floors { get; set; }
        public decimal SquareMeters { get; set; }
    }
}
