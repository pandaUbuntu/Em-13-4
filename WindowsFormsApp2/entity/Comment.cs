using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.entity
{
    class Comment
    {
        public int Id { get; set; }
        public int Rating { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; }

        public Comment(int id, int rating, string text, DateTime createdAt)
        {
            Id = id;
            Rating = rating;
            Text = text;
            CreatedAt = createdAt;
        }
    }
}
