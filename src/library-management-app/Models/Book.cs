using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace library_management_app.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string DescriptionHtml { get; set; }
        public Author[] Author { get; set; }
        public bool Favorite { get; set; }

       public string CoverImage
        {
            get
            {
                return Title.Replace(" ", "_") + ".jpg";
            }
        }
    }
}