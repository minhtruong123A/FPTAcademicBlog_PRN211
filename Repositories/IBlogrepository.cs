using BusinessObjects;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IBlogrepository
    {
        TblUser CheckLogin(string email, string password);
        TblUser GetUserByEmail(string email);
        void Register(TblUser c);
        void UpdateUser(TblUser c);
        public void DeleteUser(TblUser c);
        public List<TblUser> GetTblUserList();
        public TblUser GetbyUserName(string user);
        public TblUser GetbyUserID(string id);
        public List<TblUser> GetListUserByName(string userName);

        //---------------------------------------------------------------------
        public List<Comment> GetCommentList();
        public void UpdateComment(Comment comment);
        public void DeleteComment(Comment comment);
        public void Add(Comment add);
        public List<Comment> GetbyCommentAuthor(string Author);

        //---------------------------------------------------------------------
        public List<Post> GetPostList();
        public void UpdatePost(Post post);
        public void DeletePost(Post post);
        public void AddPost(Post post);
        public List<Post> GetbyPostAuthor(string Author);
        public List<Post> GetbyTitle(string Title);
    }
}

