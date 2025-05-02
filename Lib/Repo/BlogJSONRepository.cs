using System.Collections.Generic;
using System.Text.Json;
using Lib.Model;

namespace Lib.Repo
{
    public class BlogJSONRepository : IBlogRepo
    {
        protected List<Blog> _blogs = new List<Blog>();

        public BlogJSONRepository(string path)
        {
            LoadFile(path);
        }

        public List<Blog> GetAll()
        {
            return _blogs;
        }

        public void Add(Blog blog, string path)
        {
            _blogs.Add(blog);
            SaveFile(path);
        }


        //denne metode skal kaldes hver gang vi gerne vil trække data fra vores JSON
        private void LoadFile(string path)
        {

            string json = File.ReadAllText(path + "blogs.json");

            _blogs = JsonSerializer.Deserialize<List<Blog>>(json);
        }

        //denne metode skal kaldes når vi vil putte data i vores JSON
        private void SaveFile(string path)
        {

            File.WriteAllText(path + "blogs.json", JsonSerializer.Serialize(_blogs));
        }
    }
}
