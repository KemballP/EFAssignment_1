// See https://aka.ms/new-console-template for more information
using DataEntities.Entities;
using EFAssignment1;


var context = new DataContext();

/* I did this first, I made 4 users not 3. (It was worded as 1+3)
for (int i = 0; i < 4; i++)
{
    var user1 = new User();
    user1.Name = $"Philip Kemball{i}";
    user1.EmailAddress = $"{i}{i}{i}@abc.com";
    user1.PhoneNumber = $"{i}{i}{i}{i}{i}{i}{i}{i}{i}";
    context.Add(user1);
}
context.SaveChanges();
*/

/* Then I did this
var blog = new Blog() { IsPublic = true, Url = "clickbait.com"};
blog.BlogType = new BlogType() { Name = "OkayBlog", Description = "meh", Status = "mediocre"};


var post = new Post();
post.Title = "Post1";
post.Content = "Something in Latin";
post.User = context.Users.First();
post.PostType = new PostType() 
{ 
Name = "anger management", 
Status = "yawning", 
Description = "the effects of caffeine withdrawal"
};
post.Blog = blog;

context.Add(post);
context.SaveChanges();
*/

// To test DB.
Console.WriteLine(context.Posts.First().Title);
Console.WriteLine(context.Blogs.First().Url);
Console.WriteLine(context.PostTypes.First().Name);
Console.WriteLine(context.BlogTypes.First().Name);
Console.WriteLine(context.Users.First().Name);


  

   

