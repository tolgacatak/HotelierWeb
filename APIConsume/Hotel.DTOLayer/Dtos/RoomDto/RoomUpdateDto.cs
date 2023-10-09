using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.DTOLayer.Dtos.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Please enter a room number!")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Please enter a room cover image")]

        public string RoomCoverimage { get; set; }

        [Required(ErrorMessage = "Please enter a price Information")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Please enter the room title information")]
        [StringLength(100,ErrorMessage ="Please enter max 100 character")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter bed number")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Please enter bath count")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }

        [Required(ErrorMessage = "Please enter a description")]
        public string Description { get; set; }
    }
}
