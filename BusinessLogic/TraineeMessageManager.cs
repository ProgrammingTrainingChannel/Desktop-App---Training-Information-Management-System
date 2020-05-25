using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLogic;

namespace BusinessLogic
    {
         public class TraineeMessageManager
         {
             public List<TraineeMessageEntity> GetAll() 
         { 
             try 
             { 
                 List<TraineeMessageEntity> TraineeMessageEntities = new List<TraineeMessageEntity>(); 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 List<tblTraineeMessage> TraineeMessages = entity.tblTraineeMessages.ToList(); 

                 foreach (tblTraineeMessage TraineeMessage in TraineeMessages) 
                 { 
                     TraineeMessageEntity traineeMessage = new TraineeMessageEntity(); 
                     traineeMessage.ID = TraineeMessage.ID; 
                     traineeMessage.TraineeEntity = new TraineeEntity(TraineeMessage.tblTrainee); 
                     traineeMessage.PhoneNumber = TraineeMessage.PhoneNumber; 
                     traineeMessage.Message = TraineeMessage.Message; 
                     traineeMessage.Status = TraineeMessage.Status; 
                     traineeMessage.CreatedBy = TraineeMessage.CreatedBy; 
                     traineeMessage.CreatedDate = TraineeMessage.CreatedDate; 
                     traineeMessage.UpdatedBy = TraineeMessage.UpdatedBy; 
                     traineeMessage.UpdatedDate = (DateTime)TraineeMessage.UpdatedDate; 

                     TraineeMessageEntities.Add(traineeMessage); 
                 } 
                 return TraineeMessageEntities; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public TraineeMessageEntity GetSingle(int ID) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 

                 tblTraineeMessage TraineeMessage = entity.tblTraineeMessages.Where(x => x.ID == ID).FirstOrDefault(); 
                 TraineeMessageEntity traineeMessage = new TraineeMessageEntity(); 
                 traineeMessage.ID = TraineeMessage.ID; 
                 traineeMessage.TraineeEntity = new TraineeEntity(TraineeMessage.tblTrainee); 
                 traineeMessage.PhoneNumber = TraineeMessage.PhoneNumber; 
                 traineeMessage.Message = TraineeMessage.Message; 
                 traineeMessage.Status = TraineeMessage.Status; 
                 traineeMessage.CreatedBy = TraineeMessage.CreatedBy; 
                 traineeMessage.CreatedDate = TraineeMessage.CreatedDate; 
                 traineeMessage.UpdatedBy = TraineeMessage.UpdatedBy; 
                 traineeMessage.UpdatedDate = (DateTime)TraineeMessage.UpdatedDate; 

                 return traineeMessage; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public bool Save(TraineeMessageEntity traineeMessage) 
         { 
             try 
             { 
                 tblTraineeMessage TraineeMessage = new tblTraineeMessage(); 

                 TraineeMessage.ID = traineeMessage.ID; 
                 TraineeMessage.TraineeID = traineeMessage.TraineeEntity.ID; 
                 TraineeMessage.PhoneNumber = traineeMessage.PhoneNumber; 
                 TraineeMessage.Message = traineeMessage.Message; 
                 TraineeMessage.Status = traineeMessage.Status; 
                 TraineeMessage.CreatedBy = traineeMessage.CreatedBy; 
                 TraineeMessage.CreatedDate = traineeMessage.CreatedDate; 
                 TraineeMessage.UpdatedBy = traineeMessage.UpdatedBy; 
                 TraineeMessage.UpdatedDate = traineeMessage.UpdatedDate; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 entity.tblTraineeMessages.Add(TraineeMessage); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Update(TraineeMessageEntity traineeMessage) 
         { 
             try 
             { 
                 tblTraineeMessage newTraineeMessage = new tblTraineeMessage(); 

                 newTraineeMessage.ID = traineeMessage.ID; 
                 newTraineeMessage.TraineeID = traineeMessage.TraineeEntity.ID; 
                 newTraineeMessage.PhoneNumber = traineeMessage.PhoneNumber; 
                 newTraineeMessage.Message = traineeMessage.Message; 
                 newTraineeMessage.Status = traineeMessage.Status; 
                 newTraineeMessage.CreatedBy = traineeMessage.CreatedBy; 
                 newTraineeMessage.CreatedDate = traineeMessage.CreatedDate; 
                 newTraineeMessage.UpdatedBy = traineeMessage.UpdatedBy; 
                 newTraineeMessage.UpdatedDate = traineeMessage.UpdatedDate; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblTraineeMessage oldTraineeMessage = entity.tblTraineeMessages.Where(x => x.ID == traineeMessage.ID).FirstOrDefault(); 
                 entity.Entry(oldTraineeMessage).CurrentValues.SetValues(newTraineeMessage); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Delete(TraineeMessageEntity traineeMessage) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblTraineeMessage TraineeMessage = entity.tblTraineeMessages.Where(x => x.ID == traineeMessage.ID).FirstOrDefault(); 

                 entity.tblTraineeMessages.Remove(TraineeMessage); 
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
