using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLogic;

namespace BusinessLogic
    {
         public class TraineeCourseManager
         {
             public List<TraineeCourseEntity> GetAll() 
         { 
             try 
             { 
                 List<TraineeCourseEntity> TraineeCourseEntities = new List<TraineeCourseEntity>(); 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 List<tblTraineeCourse> TraineeCourses = entity.tblTraineeCourses.ToList(); 

                 foreach (tblTraineeCourse TraineeCourse in TraineeCourses) 
                 { 
                     TraineeCourseEntity traineeCourse = new TraineeCourseEntity(); 
                     traineeCourse.ID = TraineeCourse.ID; 
                     traineeCourse.TraineeEntity = new TraineeEntity(TraineeCourse.tblTrainee); 
                     traineeCourse.CourseEntity = new CourseEntity(TraineeCourse.tblCourse); 
                     traineeCourse.RegistrationDate = TraineeCourse.RegistrationDate; 
                     traineeCourse.Duration = TraineeCourse.Duration; 
                     traineeCourse.Cost = TraineeCourse.Cost; 
                     traineeCourse.CreatedBy = TraineeCourse.CreatedBy; 
                     traineeCourse.CreatedDate = TraineeCourse.CreatedDate; 
                     traineeCourse.UpdatedBy = TraineeCourse.UpdatedBy; 
                     traineeCourse.UpdatedDate = (DateTime)TraineeCourse.UpdatedDate; 

                     TraineeCourseEntities.Add(traineeCourse); 
                 } 
                 return TraineeCourseEntities; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 

             public List<TraineeCourseCostEntity> GetAllTraineeCourseCost() 
         { 
             try 
             { 
                 List<TraineeCourseCostEntity> TraineeCourseCostEntities = new List<TraineeCourseCostEntity>(); 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 List<View_TraineeCourseCost> TraineeCourses = entity.View_TraineeCourseCost.ToList(); 

                 foreach (View_TraineeCourseCost TraineeCourse in TraineeCourses) 
                 {
                    TraineeCourseCostEntity traineeCourseCost = new TraineeCourseCostEntity();
                    traineeCourseCost.ID = TraineeCourse.ID;
                    traineeCourseCost.TraineeCourseDetail = TraineeCourse.TraineeCourseDetail; 

                    TraineeCourseCostEntities.Add(traineeCourseCost); 
                 } 
                 return TraineeCourseCostEntities; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public TraineeCourseEntity GetSingle(int ID) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 

                 tblTraineeCourse TraineeCourse = entity.tblTraineeCourses.Where(x => x.ID == ID).FirstOrDefault(); 
                 TraineeCourseEntity traineeCourse = new TraineeCourseEntity(); 
                 traineeCourse.ID = TraineeCourse.ID; 
                 traineeCourse.TraineeEntity = new TraineeEntity(TraineeCourse.tblTrainee); 
                 traineeCourse.CourseEntity = new CourseEntity(TraineeCourse.tblCourse); 
                 traineeCourse.RegistrationDate = TraineeCourse.RegistrationDate; 
                 traineeCourse.Duration = TraineeCourse.Duration; 
                 traineeCourse.Cost = TraineeCourse.Cost; 
                 traineeCourse.CreatedBy = TraineeCourse.CreatedBy; 
                 traineeCourse.CreatedDate = TraineeCourse.CreatedDate; 
                 traineeCourse.UpdatedBy = TraineeCourse.UpdatedBy; 
                 traineeCourse.UpdatedDate = (DateTime)TraineeCourse.UpdatedDate; 

                 return traineeCourse; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public int Save(TraineeCourseEntity traineeCourse) 
         { 
             try 
             { 
                 tblTraineeCourse TraineeCourse = new tblTraineeCourse(); 

                 TraineeCourse.ID = traineeCourse.ID; 
                 TraineeCourse.TraineeID = traineeCourse.TraineeEntity.ID; 
                 TraineeCourse.CourseID = traineeCourse.CourseEntity.ID; 
                 TraineeCourse.RegistrationDate = traineeCourse.RegistrationDate; 
                 TraineeCourse.Duration = traineeCourse.Duration; 
                 TraineeCourse.Cost = traineeCourse.Cost; 
                 TraineeCourse.CreatedBy = traineeCourse.CreatedBy; 
                 TraineeCourse.CreatedDate = traineeCourse.CreatedDate; 
                 TraineeCourse.UpdatedBy = traineeCourse.UpdatedBy; 
                 TraineeCourse.UpdatedDate = traineeCourse.UpdatedDate; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 entity.tblTraineeCourses.Add(TraineeCourse); 
                 entity.SaveChanges(); 

                 return TraineeCourse.ID; //return currently created record ID
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Update(TraineeCourseEntity traineeCourse) 
         { 
             try 
             { 
                 tblTraineeCourse newTraineeCourse = new tblTraineeCourse(); 

                 newTraineeCourse.ID = traineeCourse.ID; 
                 newTraineeCourse.TraineeID = traineeCourse.TraineeEntity.ID; 
                 newTraineeCourse.CourseID = traineeCourse.CourseEntity.ID; 
                 newTraineeCourse.RegistrationDate = traineeCourse.RegistrationDate; 
                 newTraineeCourse.Duration = traineeCourse.Duration; 
                 newTraineeCourse.Cost = traineeCourse.Cost; 
                 newTraineeCourse.CreatedBy = traineeCourse.CreatedBy; 
                 newTraineeCourse.CreatedDate = traineeCourse.CreatedDate; 
                 newTraineeCourse.UpdatedBy = traineeCourse.UpdatedBy; 
                 newTraineeCourse.UpdatedDate = traineeCourse.UpdatedDate; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblTraineeCourse oldTraineeCourse = entity.tblTraineeCourses.Where(x => x.ID == traineeCourse.ID).FirstOrDefault(); 
                 entity.Entry(oldTraineeCourse).CurrentValues.SetValues(newTraineeCourse); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Delete(TraineeCourseEntity traineeCourse) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblTraineeCourse TraineeCourse = entity.tblTraineeCourses.Where(x => x.ID == traineeCourse.ID).FirstOrDefault(); 

                 entity.tblTraineeCourses.Remove(TraineeCourse); 
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
