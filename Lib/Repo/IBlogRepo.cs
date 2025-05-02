using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Model;

namespace Lib.Repo
{
    public interface IBlogRepo
    {
        public List<Blog> GetAll();
        public void Add(Blog blog, string path);
    }
}
