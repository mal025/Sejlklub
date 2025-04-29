using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Model
{
    internal class Blog
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public Member Author { get; set; }

        public Blog(string title, string text, DateTime date, Member member)
        {
            Title = title;
            Text = text;
            Date = date;
            Author = member;
        }

            




    }
}
