using System.ComponentModel.DataAnnotations;

namespace MyPortfolioUdemy.DAL.Entities
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        public string Title { get; set; }
        public string SubDescriptiontle { get; set; }
        public string Deatils { get; set; }

    }
}
