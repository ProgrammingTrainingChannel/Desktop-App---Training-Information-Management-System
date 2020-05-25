using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLogic;

namespace BusinessLogic
    {
         public class AcademicLevelManager
         {
             public List<AcademicLevelEntity> GetAll() 
         { 
             try 
             { 
                 List<AcademicLevelEntity> AcademicLevelEntities = new List<AcademicLevelEntity>(); 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 List<tblAcademicLevel> AcademicLevels = entity.tblAcademicLevels.ToList(); 

                 foreach (tblAcademicLevel AcademicLevel in AcademicLevels) 
                 { 
                     AcademicLevelEntity academicLevel = new AcademicLevelEntity(); 
                     academicLevel.ID = AcademicLevel.ID; 
                     academicLevel.Title = AcademicLevel.Title; 

                     AcademicLevelEntities.Add(academicLevel); 
                 } 
                 return AcademicLevelEntities; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public AcademicLevelEntity GetSingle(int ID) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 

                 tblAcademicLevel AcademicLevel = entity.tblAcademicLevels.Where(x => x.ID == ID).FirstOrDefault(); 
                 AcademicLevelEntity academicLevel = new AcademicLevelEntity(); 
                 academicLevel.ID = AcademicLevel.ID; 
                 academicLevel.Title = AcademicLevel.Title; 

                 return academicLevel; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public bool Save(AcademicLevelEntity academicLevel) 
         { 
             try 
             { 
                 tblAcademicLevel AcademicLevel = new tblAcademicLevel(); 

                 AcademicLevel.ID = academicLevel.ID; 
                 AcademicLevel.Title = academicLevel.Title; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 entity.tblAcademicLevels.Add(AcademicLevel); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Update(AcademicLevelEntity academicLevel) 
         { 
             try 
             { 
                 tblAcademicLevel newAcademicLevel = new tblAcademicLevel(); 

                 newAcademicLevel.ID = academicLevel.ID; 
                 newAcademicLevel.Title = academicLevel.Title; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblAcademicLevel oldAcademicLevel = entity.tblAcademicLevels.Where(x => x.ID == academicLevel.ID).FirstOrDefault(); 
                 entity.Entry(oldAcademicLevel).CurrentValues.SetValues(newAcademicLevel); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Delete(AcademicLevelEntity academicLevel) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblAcademicLevel AcademicLevel = entity.tblAcademicLevels.Where(x => x.ID == academicLevel.ID).FirstOrDefault(); 

                 entity.tblAcademicLevels.Remove(AcademicLevel); 
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
