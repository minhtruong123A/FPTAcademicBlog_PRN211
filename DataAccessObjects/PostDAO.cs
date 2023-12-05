using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class PostDAO
    {
        public static List<Post> GetPostList()
        {
            List<Post> UserList = new List<Post>();
            try
            {
                using var db = new FUBlogManagementContext();
                UserList = db.Posts.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return UserList;
        }
        //-----------------------------------------------------------------------------------------------------
        public static void Update(Post post)
        {
            try
            {
                using (var db = new FUBlogManagementContext())
                {
                    db.Entry<Post>(post).State = EntityState.Modified; 
                    db.SaveChanges(); 
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //-----------------------------------------------------------------------------------------------------
        public static void Delete(Post post)
        {
            try
            {
                using var db = new FUBlogManagementContext();
                var post1 = db.Posts.FirstOrDefault(x => x.PostId == post.PostId);
                db.Posts.Remove(post1); 
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //-----------------------------------------------------------------------------------------------------
        public static void Add(Post post)
        {
            try
            {
                using var db = new FUBlogManagementContext();
                db.Posts.Add(post); 
                db.SaveChanges(); 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //-----------------------------------------------------------------------------------------------------
        public static List<Post> GetbyPostAuthor(string Author)
        {
            List<Post> PostList = new List<Post>();
            List<Post> RealPostList = new List<Post>();
            try
            {
                using var db = new FUBlogManagementContext();
                PostList = db.Posts.ToList();

                for (int i = 0; i < PostList.Count; i++)
                {
                    if (PostList[i].PostAuthor.Contains(Author))
                    {
                        RealPostList.Add(PostList[i]);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return RealPostList;
        }
        //-----------------------------------------------------------------------------------------------------
        public static List<Post> GetbyTitle(string Title)
        {
            List<Post> PostList = new List<Post>();
            List<Post> RealPostList = new List<Post>();
            try
            {
                using var db = new FUBlogManagementContext();
                PostList = db.Posts.ToList();//.SingleOrDefault(m => m.CarName.Contains(carName)); 

                for (int i = 0; i < PostList.Count; i++)
                {
                    if (PostList[i].Title.Contains(Title))
                    {
                        RealPostList.Add(PostList[i]);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return RealPostList;
        }
        //-----------------------------------------------------------------------------------------------------
    }
}
