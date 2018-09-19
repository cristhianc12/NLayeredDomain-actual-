using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain.Core
{
    public class House
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
