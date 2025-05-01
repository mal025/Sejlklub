using System.Collections.Generic;
using System.Text.Json;
using Lib.Model;

namespace Lib.Repo
{
    public class BlogJSONRepository : IBlogRepo
    {
        protected List<Blog> _blogs = new List<Blog>();

        public BlogJSONRepository()
        {
            LoadFile();
        }

        public void Add(Blog blog)
        {
            _blogs.Add(blog);
            SaveFile();
        }


        //denne metode skal kaldes hver gang vi gerne vil trække data fra vores JSON
        private void LoadFile()
        {
            string path = @"..\..\..\JSON\blogs.json";
            string json = File.ReadAllText(path);

            _blogs = JsonSerializer.Deserialize<List<Blog>>(json);
        }

        //denne metode skal kaldes når vi vil putte data i vores JSON
        private void SaveFile()
        {
            string path = @"..\..\..\JSON\blogs.json";
            File.WriteAllText(path, JsonSerializer.Serialize(_blogs));
        }
    }
}
