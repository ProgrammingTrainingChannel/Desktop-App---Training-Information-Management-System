using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLogic;

namespace BusinessLogic
    {
         public class UserManager
         {
             public List<UserEntity> GetAll() 
         { 
             try 
             { 
                 List<UserEntity> UserEntities = new List<UserEntity>(); 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 List<tblUser> Users = entity.tblUsers.ToList(); 

                 foreach (tblUser User in Users) 
                 { 
                     UserEntity user = new UserEntity(); 
                     user.ID = User.ID; 
                     user.Username = User.Username; 
                     user.Password = User.Password; 

                     UserEntities.Add(user); 
                 } 
                 return UserEntities; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public UserEntity GetSingle(int ID) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 

                 tblUser User = entity.tblUsers.Where(x => x.ID == ID).FirstOrDefault(); 
                 UserEntity user = new UserEntity(); 
                 user.ID = User.ID; 
                 user.Username = User.Username; 
                 user.Password = User.Password; 

                 return user; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         }


        public bool LoginUser(string username, string password)
        {
            try
            {
                TIMSDBEntities entity = new TIMSDBEntities();
                
                tblUser User = entity.tblUsers.Where(x => x.Username == username && x.Password == password).FirstOrDefault();
                if(User != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Save(UserEntity user) 
         { 
             try 
             { 
                 tblUser User = new tblUser(); 

                 User.ID = user.ID; 
                 User.Username = user.Username; 
                 User.Password = user.Password; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 entity.tblUsers.Add(User); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Update(UserEntity user) 
         { 
             try 
             { 
                 tblUser newUser = new tblUser(); 

                 newUser.ID = user.ID; 
                 newUser.Username = user.Username; 
                 newUser.Password = user.Password; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblUser oldUser = entity.tblUsers.Where(x => x.ID == user.ID).FirstOrDefault(); 
                 entity.Entry(oldUser).CurrentValues.SetValues(newUser); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Delete(UserEntity user) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblUser User = entity.tblUsers.Where(x => x.ID == user.ID).FirstOrDefault(); 

                 entity.tblUsers.Remove(User); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 

         }
    }
