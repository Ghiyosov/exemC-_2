using System.ComponentModel;

namespace Task_8;

public class Post
{
    public string Title { get; set; }
    public string Description { get; set; }
    public List<string> Comments = new List<string>();
    public int LikeCount {get; set;}
    public bool IsPublished { get; set; }


    public void Pulish()
    {
        System.Console.WriteLine("The post is published.");
        IsPublished = true;
    }
    public void Like()
    {
        LikeCount++;
    }
    public void Coment(string cometar)
    {
        Comments.Add(cometar);
    }
}
