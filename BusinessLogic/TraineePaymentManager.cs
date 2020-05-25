using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLogic;
using System.Data.SqlClient;

namespace BusinessLogic
    {
         public class TraineePaymentManager
         {
             public List<TraineePaymentEntity> GetAll() 
         { 
             try 
             { 
                 List<TraineePaymentEntity> TraineePaymentEntities = new List<TraineePaymentEntity>(); 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 List<tblTraineePayment> TraineePayments = entity.tblTraineePayments.ToList(); 

                 foreach (tblTraineePayment TraineePayment in TraineePayments) 
                 { 
                     TraineePaymentEntity traineePayment = new TraineePaymentEntity(); 
                     traineePayment.ID = TraineePayment.ID; 
                     traineePayment.TraineeCourseEntity = new TraineeCourseEntity(TraineePayment.tblTraineeCourse); 
                     traineePayment.PaymentDate = TraineePayment.PaymentDate; 
                     traineePayment.PaymentAmount = TraineePayment.PaymentAmount; 
                     traineePayment.CreatedBy = TraineePayment.CreatedBy; 
                     traineePayment.CreatedDate = TraineePayment.CreatedDate; 
                     traineePayment.UpdatedBy = TraineePayment.UpdatedBy; 
                     traineePayment.UpdatedDate = (DateTime)TraineePayment.UpdatedDate; 

                     TraineePaymentEntities.Add(traineePayment); 
                 } 
                 return TraineePaymentEntities; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public TraineePaymentEntity GetSingle(int ID) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 

                 tblTraineePayment TraineePayment = entity.tblTraineePayments.Where(x => x.ID == ID).FirstOrDefault(); 
                 TraineePaymentEntity traineePayment = new TraineePaymentEntity(); 
                 traineePayment.ID = TraineePayment.ID; 
                 traineePayment.TraineeCourseEntity = new TraineeCourseEntity(TraineePayment.tblTraineeCourse); 
                 traineePayment.PaymentDate = TraineePayment.PaymentDate; 
                 traineePayment.PaymentAmount = TraineePayment.PaymentAmount; 
                 traineePayment.CreatedBy = TraineePayment.CreatedBy; 
                 traineePayment.CreatedDate = TraineePayment.CreatedDate; 
                 traineePayment.UpdatedBy = TraineePayment.UpdatedBy; 
                 traineePayment.UpdatedDate = (DateTime)TraineePayment.UpdatedDate; 

                 return traineePayment; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public bool Save(TraineePaymentEntity traineePayment) 
         { 
             try 
             { 
                 tblTraineePayment TraineePayment = new tblTraineePayment(); 

                 TraineePayment.ID = traineePayment.ID; 
                 TraineePayment.TraineeCourseID = traineePayment.TraineeCourseEntity.ID; 
                 TraineePayment.PaymentDate = traineePayment.PaymentDate; 
                 TraineePayment.PaymentAmount = traineePayment.PaymentAmount; 
                 TraineePayment.CreatedBy = traineePayment.CreatedBy; 
                 TraineePayment.CreatedDate = traineePayment.CreatedDate; 
                 TraineePayment.UpdatedBy = traineePayment.UpdatedBy; 
                 TraineePayment.UpdatedDate = traineePayment.UpdatedDate; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 entity.tblTraineePayments.Add(TraineePayment); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception ex) 
             { 
                 throw; 
             } 
         } 


             public bool Update(TraineePaymentEntity traineePayment) 
         { 
             try 
             { 
                 tblTraineePayment newTraineePayment = new tblTraineePayment(); 

                 newTraineePayment.ID = traineePayment.ID; 
                 newTraineePayment.TraineeCourseID = traineePayment.TraineeCourseEntity.ID; 
                 newTraineePayment.PaymentDate = traineePayment.PaymentDate; 
                 newTraineePayment.PaymentAmount = traineePayment.PaymentAmount; 
                 newTraineePayment.CreatedBy = traineePayment.CreatedBy; 
                 newTraineePayment.CreatedDate = traineePayment.CreatedDate; 
                 newTraineePayment.UpdatedBy = traineePayment.UpdatedBy; 
                 newTraineePayment.UpdatedDate = traineePayment.UpdatedDate; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblTraineePayment oldTraineePayment = entity.tblTraineePayments.Where(x => x.ID == traineePayment.ID).FirstOrDefault(); 
                 entity.Entry(oldTraineePayment).CurrentValues.SetValues(newTraineePayment); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Delete(TraineePaymentEntity traineePayment) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblTraineePayment TraineePayment = entity.tblTraineePayments.Where(x => x.ID == traineePayment.ID).FirstOrDefault(); 

                 entity.tblTraineePayments.Remove(TraineePayment); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         }
        
        public int CalculatePaymentAmountLeft(int traineeCourseID, string connectionString)
        {
            string query = "SELECT CAST(AmountLeft AS int) AS AmountLeft FROM [dbo].[View_PaymentAmountLeft] WHERE TraineeCourseID = " + traineeCourseID;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetInt32(0);
            }
            else
            {
                return 0;
            }
        }

         }
    }
