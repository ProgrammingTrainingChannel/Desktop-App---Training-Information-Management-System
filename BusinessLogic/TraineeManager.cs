using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLogic;

namespace BusinessLogic
    {
         public class TraineeManager
         {
             public List<TraineeEntity> GetAll() 
         { 
             try 
             { 
                 List<TraineeEntity> TraineeEntities = new List<TraineeEntity>(); 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 List<tblTrainee> Trainees = entity.tblTrainees.ToList(); 

                 foreach (tblTrainee Trainee in Trainees) 
                 { 
                     TraineeEntity trainee = new TraineeEntity(); 
                     trainee.ID = Trainee.ID; 
                     trainee.Fullname = Trainee.Fullname; 
                     trainee.BirthDate = Trainee.BirthDate; 
                     trainee.GenderEntity = new GenderEntity(Trainee.tblGender);
                    trainee.AcademicLevelEntity = new AcademicLevelEntity(Trainee.tblAcademicLevel);
                    trainee.BranchEntity = new BranchEntity(Trainee.tblBranch);
                    trainee.Address = Trainee.Address; 
                     trainee.PhoneNumber = Trainee.PhoneNumber; 
                     trainee.Photo = Trainee.Photo; 
                     trainee.CreatedBy = Trainee.CreatedBy; 
                     trainee.CreatedDate = Trainee.CreatedDate; 
                     trainee.UpdatedBy = Trainee.UpdatedBy; 
                     trainee.UpdatedDate = (DateTime)Trainee.UpdatedDate; 

                     TraineeEntities.Add(trainee); 
                 } 
                 return TraineeEntities; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public TraineeEntity GetSingle(int ID) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 

                 tblTrainee Trainee = entity.tblTrainees.Where(x => x.ID == ID).FirstOrDefault(); 
                 TraineeEntity trainee = new TraineeEntity(); 
                 trainee.ID = Trainee.ID; 
                 trainee.Fullname = Trainee.Fullname; 
                 trainee.BirthDate = Trainee.BirthDate; 
                 trainee.GenderEntity = new GenderEntity(Trainee.tblGender);
                trainee.AcademicLevelEntity = new AcademicLevelEntity(Trainee.tblAcademicLevel);
                trainee.BranchEntity = new BranchEntity(Trainee.tblBranch);
                trainee.Address = Trainee.Address; 
                 trainee.PhoneNumber = Trainee.PhoneNumber; 
                 trainee.Photo = Trainee.Photo; 
                 trainee.CreatedBy = Trainee.CreatedBy; 
                 trainee.CreatedDate = Trainee.CreatedDate; 
                 trainee.UpdatedBy = Trainee.UpdatedBy; 
                 trainee.UpdatedDate = (DateTime)Trainee.UpdatedDate; 

                 return trainee; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


         public int Save(TraineeEntity trainee) 
         { 
             try 
             { 
                 tblTrainee Trainee = new tblTrainee(); 

                 Trainee.ID = trainee.ID; 
                 Trainee.Fullname = trainee.Fullname; 
                 Trainee.BirthDate = trainee.BirthDate; 
                 Trainee.GenderID = trainee.GenderEntity.ID;
                Trainee.AcademicLevelID = trainee.AcademicLevelEntity.ID;
                Trainee.BranchID = trainee.BranchEntity.ID;
                Trainee.Address = trainee.Address; 
                 Trainee.PhoneNumber = trainee.PhoneNumber; 
                 Trainee.Photo = trainee.Photo; 
                 Trainee.CreatedBy = trainee.CreatedBy; 
                 Trainee.CreatedDate = trainee.CreatedDate; 
                 Trainee.UpdatedBy = trainee.UpdatedBy; 
                 Trainee.UpdatedDate = trainee.UpdatedDate; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 entity.tblTrainees.Add(Trainee); 
                 entity.SaveChanges(); 
                 return Trainee.ID; 
             } 
             catch (Exception ex) 
             { 
                 throw; 
             } 
         } 


             public bool Update(TraineeEntity trainee) 
         { 
             try 
             { 
                 tblTrainee newTrainee = new tblTrainee(); 

                 newTrainee.ID = trainee.ID; 
                 newTrainee.Fullname = trainee.Fullname; 
                 newTrainee.BirthDate = trainee.BirthDate; 
                 newTrainee.GenderID = trainee.GenderEntity.ID;
                newTrainee.AcademicLevelID = trainee.AcademicLevelEntity.ID;
                newTrainee.BranchID = trainee.BranchEntity.ID;
                newTrainee.Address = trainee.Address; 
                 newTrainee.PhoneNumber = trainee.PhoneNumber; 
                 newTrainee.Photo = trainee.Photo; 
                 newTrainee.CreatedBy = trainee.CreatedBy; 
                 newTrainee.CreatedDate = trainee.CreatedDate; 
                 newTrainee.UpdatedBy = trainee.UpdatedBy; 
                 newTrainee.UpdatedDate = trainee.UpdatedDate; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblTrainee oldTrainee = entity.tblTrainees.Where(x => x.ID == trainee.ID).FirstOrDefault(); 
                 entity.Entry(oldTrainee).CurrentValues.SetValues(newTrainee); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception ex) 
             { 
                 throw; 
             } 
         } 


             public bool Delete(TraineeEntity trainee) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblTrainee Trainee = entity.tblTrainees.Where(x => x.ID == trainee.ID).FirstOrDefault(); 

                 entity.tblTrainees.Remove(Trainee); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception ex) 
             { 
                 throw; 
             } 
         } 

         }
    }
