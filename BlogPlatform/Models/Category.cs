using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blog_template_practice.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Content> Content { get; set; }


        public Category()
        {

        }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }



    }




    
}
