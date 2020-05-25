using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLogic;

namespace BusinessLogic
    {
         public class GenderManager
         {
             public List<GenderEntity> GetAll() 
         { 
             try 
             { 
                 List<GenderEntity> GenderEntities = new List<GenderEntity>(); 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 List<tblGender> Genders = entity.tblGenders.ToList(); 

                 foreach (tblGender Gender in Genders) 
                 { 
                     GenderEntity gender = new GenderEntity(); 
                     gender.ID = Gender.ID; 
                     gender.Title = Gender.Title; 

                     GenderEntities.Add(gender); 
                 } 
                 return GenderEntities; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public GenderEntity GetSingle(int ID) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 

                 tblGender Gender = entity.tblGenders.Where(x => x.ID == ID).FirstOrDefault(); 
                 GenderEntity gender = new GenderEntity(); 
                 gender.ID = Gender.ID; 
                 gender.Title = Gender.Title; 

                 return gender; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public bool Save(GenderEntity gender) 
         { 
             try 
             { 
                 tblGender Gender = new tblGender(); 

                 Gender.ID = gender.ID; 
                 Gender.Title = gender.Title; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 entity.tblGenders.Add(Gender); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Update(GenderEntity gender) 
         { 
             try 
             { 
                 tblGender newGender = new tblGender(); 

                 newGender.ID = gender.ID; 
                 newGender.Title = gender.Title; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblGender oldGender = entity.tblGenders.Where(x => x.ID == gender.ID).FirstOrDefault(); 
                 entity.Entry(oldGender).CurrentValues.SetValues(newGender); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Delete(GenderEntity gender) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblGender Gender = entity.tblGenders.Where(x => x.ID == gender.ID).FirstOrDefault(); 

                 entity.tblGenders.Remove(Gender); 
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
