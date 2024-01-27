



using System.Security.Cryptography;
using Task_8;

var post1 = new Post(){};
post1.Title = "Title_1";
post1.Description = "Description_1";
post1.LikeCount = 0;
post1.Like();
post1.Coment("Coment_1");
post1.Pulish(); 
post1.Coment("Coment_2");
post1.Coment("Coment_2");
post1.Coment("Coment_8");

System.Console.WriteLine(post1.Title);
System.Console.WriteLine(post1.Description);
System.Console.WriteLine(post1.LikeCount);
foreach (var i in post1.Comments)
{
    System.Console.WriteLine(i);
    
}

System.Console.WriteLine("-------------------------------------------------");

var post2 = new Post(){};
post2.Title = "Title_2";
post2.Description = "Description_2";
post2.LikeCount = 1;
post2.Like();
post2.Like();
post2.Like();
post2.Coment("Coment_32");
post2.Pulish(); 
post2.Coment("Coment_2");
post2.Coment("Coment_2");
post2.Coment("Coment_8");

System.Console.WriteLine(post2.Title);
System.Console.WriteLine(post2.Description);
System.Console.WriteLine(post2.LikeCount);
foreach (var j in post2.Comments)
{
    System.Console.WriteLine(j);
    
}

System.Console.WriteLine("-------------------------------------------------");

var post3 = new Post(){};
post3.Title = "Title_3";
post3.Description = "Description_3";
post3.LikeCount = 1;
post3.Like();
post3.Like();
post3.Like();
post3.Coment("Coment_32");
post3.Pulish(); 
post3.Coment("Coment_ddddddddddddddddddddddddddd2");
post3.Coment("Coment_2");
post3.Coment("Coment_8");

System.Console.WriteLine(post3.Title);
System.Console.WriteLine(post3.Description);
System.Console.WriteLine(post3.LikeCount);
foreach (var b in post2.Comments)
{
    System.Console.WriteLine(b);
    
}

System.Console.WriteLine("-------------------------------------------------");

var post4 = new Post(){};
post4.Title = "Title_4";
post4.Description = "Description_4";
post4.LikeCount = 1;
post4.Like();
post4.Like();
post4.Like();
post4.Coment("Coment_32");
post4.Pulish(); 
post4.Coment("Coment_2");
post4.Coment("Coment_2");
post4.Coment("Coment_8");

System.Console.WriteLine(post4.Title);
System.Console.WriteLine(post4.Description);
System.Console.WriteLine(post4.LikeCount);
foreach (var v in post4.Comments)
{
    System.Console.WriteLine(v);
    
}

System.Console.WriteLine("-------------------------------------------------");

var post5 = new Post(){};
post5.Title = "Title_5";
post5.Description = "Description_5";
post5.LikeCount = 1;
post5.Like();
post5.Like();
post5.Like();
post5.Coment("Coment_32");
post5.Pulish(); 
post5.Coment("Coment_2");
post5.Coment($"Coment_2 {post5.Title}");
post5.Coment("Coment_8");

System.Console.WriteLine(post5.Title);
System.Console.WriteLine(post5.Description);
System.Console.WriteLine(post5.LikeCount);
foreach (var g in post2.Comments)
{
    System.Console.WriteLine(g);
    
}

System.Console.WriteLine("-------------------------------------------------");

var post6 = new Post(){};
if (post6.IsPublished == false)
{
    System.Console.WriteLine("The post is't published.");
}
else System.Console.WriteLine("The post is published.");

System.Console.WriteLine("********************************************************");

post6.Pulish();
if (post6.IsPublished == false)
{
    System.Console.WriteLine("The post is't published.");
}
else System.Console.WriteLine("The post is published.");
