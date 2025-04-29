using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;

namespace Lib.Repo
{
    public class BlogCollectionRepo : IBlogRepo
    {
        protected List<Blog> _blogs = new List<Blog>();
        public virtual void Add(Blog blog)
        {
            _blogs.Add(blog);
        }
    }
}
