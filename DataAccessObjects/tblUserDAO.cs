using BusinessObjects;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class tblUserDAO
    {
        public static TblUser CheckLogin(string email, string password)
        {
            using var db = new FUBlogManagementContext();
            return db.TblUsers.SingleOrDefault<TblUser>(m => m.UserName.Equals(email) && m.Password.Equals(password));
        }
        //-----------------------------------------------------------------------------------------------------
        public static TblUser GetUserByEmail(string email)
        {
            TblUser User = new TblUser();
            try
            {
                using var db = new FUBlogManagementContext();
                User = db.TblUsers.SingleOrDefault(m => m.UserName == email); 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return User;
        }
        //-----------------------------------------------------------------------------------------------------
        public static List<TblUser> GetTblUserList()
        {
            List<TblUser> UserList = new List<TblUser>();
            try
            {
                using var db = new FUBlogManagementContext();
                UserList = db.TblUsers.ToList();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return UserList;
        }
        //-----------------------------------------------------------------------------------------------------
        public static void Update(TblUser user)
        {
            try
            {
                using (var db = new FUBlogManagementContext())
                {
                    db.Entry<TblUser>(user).State = EntityState.Modified;
                    db.SaveChanges(); 
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //-----------------------------------------------------------------------------------------------------
        public static void Delete(TblUser user)
        {
            try
            {
                using var db = new FUBlogManagementContext();
                var delete = db.TblUsers.SingleOrDefault(m => m.UserId == user.UserId);
                db.TblUsers.Remove(delete); 
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //-----------------------------------------------------------------------------------------------------
        public static void Register(TblUser user)
        {
            try
            {
                using var db = new FUBlogManagementContext();
                db.TblUsers.Add(user); 
                db.SaveChanges(); 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //-----------------------------------------------------------------------------------------------------
        //view profile
        public static TblUser GetbyUserName(string user)
        {
            TblUser product = new TblUser();
            try
            {
                using var db = new FUBlogManagementContext();
                product = db.TblUsers.SingleOrDefault(m => m.UserName.Contains(user)); 
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }
        //-----------------------------------------------------------------------------------------------------
        //search user by id
        public static TblUser GetbyUserID(string id)
        {
            TblUser user = new TblUser();
            try
            {
                using var db = new FUBlogManagementContext();
                user = db.TblUsers.SingleOrDefault(m => m.UserId == id); 
        
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return user;
        }
        //-----------------------------------------------------------------------------------------------------
        public static List<TblUser> GetListUserByName(string userName)
        {
            List<TblUser> UserList = new List<TblUser>();
            List<TblUser> RealUserList = new List<TblUser>();
            try
            {
                using var db = new FUBlogManagementContext();
                UserList = db.TblUsers.ToList();

                for (int i = 0; i < UserList.Count; i++)
                {
                    if (UserList[i].UserName.Contains(userName))
                    {
                        RealUserList.Add(UserList[i]);
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return RealUserList;
        }

    }
}
