using System.ComponentModel.DataAnnotations;

namespace Hotell.Models
{

    //OBJECT RELATIONAL MAPPER
    //NUGET - package manager
    public class Room
    {
        [Key]
        public int Id { get; set; }
        public int RoomNo { get; set; }
        public string Code { get; set; }

        public string Type { get; set; }
        public double Price { get; set; }
    }
}
