using System.Collections.Generic;
using System.Text.Json;
using Lib.Model;

namespace Lib.Repo
{
    //public class BlogJSONRepository : BlogCollectionRepo
    //{
    //    public BlogJSONRepository()
    //    {
    //        LoadFile();
    //    }

    //    //denne metode skal kaldes hver gang vi gerne vil trække data fra vores JSON
    //    private void LoadFile()
    //    {
    //        string path = "blogs.json";
    //        string json = File.ReadAllText(path);
            
    //        _blogs = JsonSerializer.Deserialize<List<Blog>>(json);
    //    }

    //    public override void Add(Blog blog)
    //    {
    //        base.Add(blog);
    //        SaveFile();
    //    }

    //    //denne metode skal kaldes når vi vil putte data i vores JSON
    //    private void SaveFile()
    //    {
    //        string path = "blogs.json";
    //        File.WriteAllText(path, JsonSerializer.Serialize(_blogs));
    //    }
    //}
}
