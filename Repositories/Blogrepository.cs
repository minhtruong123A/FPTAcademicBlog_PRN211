using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class Blogrepository : IBlogrepository
    {
        //User
        public TblUser CheckLogin(string email, string password) => tblUserDAO.CheckLogin(email, password);

        public TblUser GetUserByEmail(string email) => tblUserDAO.GetUserByEmail(email);

        public void Register(TblUser c) => tblUserDAO.Register(c);

        public void UpdateUser(TblUser c) => tblUserDAO.Update(c);

        public void DeleteUser(TblUser c) => tblUserDAO.Delete(c);
        public  List<TblUser> GetTblUserList() => tblUserDAO.GetTblUserList();
        public TblUser GetbyUserName(string user) => tblUserDAO.GetbyUserName(user);
        public TblUser GetbyUserID(string id) => tblUserDAO.GetbyUserID(id);
        public List<TblUser> GetListUserByName(string userName) => tblUserDAO.GetListUserByName(userName);


        //Comment
        public List<Comment> GetCommentList() => CommentDAO.GetCommentList();
        public void UpdateComment(Comment comment) => CommentDAO.Update(comment);
        public void DeleteComment(Comment comment) => CommentDAO.Delete(comment);
        public void Add(Comment comment) => CommentDAO.Add(comment);
        public List<Comment> GetbyCommentAuthor(string Author) => CommentDAO.GetbyCommentAuthor(Author);


        //Post
        public List<Post> GetPostList() => PostDAO.GetPostList();
        public void UpdatePost(Post post) => PostDAO.Update(post);
        public void DeletePost(Post post) => PostDAO.Delete(post);
        public void AddPost(Post post) => PostDAO.Add(post);
        public List<Post> GetbyPostAuthor(string Author) => PostDAO.GetbyPostAuthor(Author);
        public List<Post> GetbyTitle(string Title) => PostDAO.GetbyTitle(Title);

    }
}
