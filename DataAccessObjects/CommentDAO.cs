using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class CommentDAO
    {
        public static List<Comment> GetCommentList()
        {
            List<Comment> UserList = new List<Comment>();
            try
            {
                using var db = new FUBlogManagementContext();
                UserList = db.Comments.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return UserList;
        }
        //-----------------------------------------------------------------------------------------------------
        public static void Update(Comment comment)
        {
            try
            {
                using (var db = new FUBlogManagementContext())
                {
                    db.Entry<Comment>(comment).State = EntityState.Modified; //gán trạng thái
                    db.SaveChanges(); // cập nhật CSDL
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //-----------------------------------------------------------------------------------------------------
        public static void Delete(Comment comment)
        {
            try
            {
                using var db = new FUBlogManagementContext();
                var delete = db.Comments.SingleOrDefault(m => m.CommentId == comment.CommentId);
                db.Comments.Remove(delete); // remove ra khỏi DbSet
                db.SaveChanges(); // cập nhật CSDL
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //-----------------------------------------------------------------------------------------------------
        public static void Add(Comment comment)
        {
            try
            {
                using var db = new FUBlogManagementContext();
                db.Comments.Add(comment); // thêm p vào trong DbSet
                db.SaveChanges(); // cập dữ liệu vào CSDL
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //-----------------------------------------------------------------------------------------------------
        public static List<Comment> GetbyCommentAuthor(string Author)
        {
            List<Comment> CommentList = new List<Comment>();
            List<Comment> RealCommentList = new List<Comment>();
            try
            {
                using var db = new FUBlogManagementContext();
                CommentList = db.Comments.ToList();//.SingleOrDefault(m => m.CarName.Contains(carName)); 

                for (int i = 0; i < CommentList.Count; i++)
                {
                    if (CommentList[i].Author.Contains(Author))
                    {
                        RealCommentList.Add(CommentList[i]);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return RealCommentList;
        }
    }
}
