using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;
using Lib.Repo;

namespace Lib.Services
{
    public class BlogService
    {
        private IBlogRepo _blogRepo;
        public BlogService(IBlogRepo blogRepo)
        {
            _blogRepo = blogRepo;
        }

        public void Add(Blog blog)
        {
            _blogRepo.Add(blog);
        }

    }
}
