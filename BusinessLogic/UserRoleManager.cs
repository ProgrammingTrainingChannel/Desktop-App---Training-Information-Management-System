using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLogic;

namespace BusinessLogic
    {
         public class UserRoleManager
         {
             public List<UserRoleEntity> GetAll() 
         { 
             try 
             { 
                 List<UserRoleEntity> UserRoleEntities = new List<UserRoleEntity>(); 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 List<tblUserRole> UserRoles = entity.tblUserRoles.ToList(); 

                 foreach (tblUserRole UserRole in UserRoles) 
                 { 
                     UserRoleEntity userRole = new UserRoleEntity(); 
                     userRole.ID = UserRole.ID; 
                     userRole.Role = new RoleEntity(UserRole.tblRole); 
                     userRole.User = new UserEntity(UserRole.tblUser); 

                     UserRoleEntities.Add(userRole); 
                 } 
                 return UserRoleEntities; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public UserRoleEntity GetSingle(int ID) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 

                 tblUserRole UserRole = entity.tblUserRoles.Where(x => x.ID == ID).FirstOrDefault(); 
                 UserRoleEntity userRole = new UserRoleEntity(); 
                 userRole.ID = UserRole.ID;
                userRole.Role = new RoleEntity(UserRole.tblRole);
                userRole.User = new UserEntity(UserRole.tblUser);

                return userRole; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         }

        public bool Save(UserRoleEntity userRole) 
         { 
             try 
             { 
                 tblUserRole UserRole = new tblUserRole(); 

                 UserRole.ID = userRole.ID; 
                 UserRole.RoleID = userRole.Role.ID; 
                 UserRole.UserID = userRole.User.ID; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 entity.tblUserRoles.Add(UserRole); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Update(UserRoleEntity userRole) 
         { 
             try 
             { 
                 tblUserRole newUserRole = new tblUserRole(); 

                 newUserRole.ID = userRole.ID; 
                 newUserRole.RoleID = userRole.Role.ID; 
                 newUserRole.UserID = userRole.User.ID; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblUserRole oldUserRole = entity.tblUserRoles.Where(x => x.ID == userRole.ID).FirstOrDefault(); 
                 entity.Entry(oldUserRole).CurrentValues.SetValues(newUserRole); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Delete(UserRoleEntity userRole) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblUserRole UserRole = entity.tblUserRoles.Where(x => x.ID == userRole.ID).FirstOrDefault(); 

                 entity.tblUserRoles.Remove(UserRole); 
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
