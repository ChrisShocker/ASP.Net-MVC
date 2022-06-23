using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }

        /*
         * Data Annoations
         * - allow us to add data validation to types
         * - MVC automatically enforces and displays proper messages to clients
         * 
         * https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/mvc-music-store/mvc-music-store-part-6
         */

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MemberShipTypeId { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
