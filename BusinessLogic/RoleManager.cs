using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLogic;

namespace BusinessLogic
    {
         public class RoleManager
         {
             public List<RoleEntity> GetAll() 
         { 
             try 
             { 
                 List<RoleEntity> RoleEntities = new List<RoleEntity>(); 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 List<tblRole> Roles = entity.tblRoles.ToList(); 

                 foreach (tblRole Role in Roles) 
                 { 
                     RoleEntity role = new RoleEntity(); 
                     role.ID = Role.ID; 
                     role.Name = Role.Name; 

                     RoleEntities.Add(role); 
                 } 
                 return RoleEntities; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public RoleEntity GetSingle(int ID) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 

                 tblRole Role = entity.tblRoles.Where(x => x.ID == ID).FirstOrDefault(); 
                 RoleEntity role = new RoleEntity(); 
                 role.ID = Role.ID; 
                 role.Name = Role.Name; 

                 return role; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         }

        public bool Save(RoleEntity role) 
         { 
             try 
             { 
                 tblRole Role = new tblRole(); 

                 Role.ID = role.ID; 
                 Role.Name = role.Name; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 entity.tblRoles.Add(Role); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Update(RoleEntity role) 
         { 
             try 
             { 
                 tblRole newRole = new tblRole(); 

                 newRole.ID = role.ID; 
                 newRole.Name = role.Name; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblRole oldRole = entity.tblRoles.Where(x => x.ID == role.ID).FirstOrDefault(); 
                 entity.Entry(oldRole).CurrentValues.SetValues(newRole); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Delete(RoleEntity role) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblRole Role = entity.tblRoles.Where(x => x.ID == role.ID).FirstOrDefault(); 

                 entity.tblRoles.Remove(Role); 
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
