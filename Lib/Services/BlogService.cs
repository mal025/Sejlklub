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

        public List<Blog> GetAll()
        {
            return _blogRepo.GetAll();
        }

        public void Add(Blog blog, string path)
        {
            _blogRepo.Add(blog, path);
        }

    }
}
