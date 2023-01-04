// See https://aka.ms/new-console-template for more information
Console.WriteLine("Usando el contexto");

using var blogDB = new BlogDBContext();

///Create
System.Console.WriteLine( "Create"  );
blogDB.Add(new Blog{ Title="Blog de noticias", Url="https://maurobernal.com.ar/blog" });
blogDB.SaveChanges();






///Read 
System.Console.WriteLine( "Read"  );
var blog= blogDB.Blogs.First();


//Create Post
blogDB.Add(new Post{ Title="Blog de noticias", BlogId=blog.Id, Content="Contenido" });
blogDB.SaveChanges();




///Update
System.Console.WriteLine( "Update"  );
blog.Title="Blog Actualizado";
blogDB.SaveChanges();

///Delete
System.Console.WriteLine( "Delete"  );

var post= blogDB.Posts.First();
blogDB.Remove(post);
blogDB.SaveChanges();

