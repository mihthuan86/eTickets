using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Hình ảnh")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Họ Tên")]
        public string FullName{ get; set; }

        [Display(Name = "Giới thiệu")]
        public string Bio { get; set; }

        //relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
