using System.ComponentModel.DataAnnotations;

namespace Exam21.Core.Models
{
    public class Portfolio : BaseModel
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
    }
}
