using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace blog_template_practice.Models
{
    public class Content
    {
        public int Id {get; set;}
        public string Title { get; set; }
        public string Body { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        






        public Content()
        {

        }

        public Content(int id, string title, string body, string author, DateTime publishDate)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
            PublishDate = publishDate;
        }










    }

    
}
