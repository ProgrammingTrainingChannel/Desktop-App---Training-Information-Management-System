using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
    {
        public class TraineeMessageEntity
        {
            public int ID { get; set; }
            public TraineeEntity TraineeEntity { get; set; }
            public string PhoneNumber { get; set; }
            public string Message { get; set; }
            public string Status { get; set; }
            public string CreatedBy { get; set; }
            public DateTime CreatedDate { get; set; }
            public string UpdatedBy { get; set; }
            public DateTime UpdatedDate { get; set; }

            public TraineeMessageEntity()
            {
            }

            public TraineeMessageEntity(DataAccessLogic.tblTraineeMessage tblTraineeMessage)
            {
                this.ID = tblTraineeMessage.ID;
                this.TraineeEntity = new TraineeEntity(tblTraineeMessage.tblTrainee);
                this.PhoneNumber = tblTraineeMessage.PhoneNumber;
                this.Message = tblTraineeMessage.Message;
                this.Status = tblTraineeMessage.Status;
                this.CreatedBy = tblTraineeMessage.CreatedBy;
                this.CreatedDate = tblTraineeMessage.CreatedDate;
                this.UpdatedBy = tblTraineeMessage.UpdatedBy;
                this.UpdatedDate = (DateTime)tblTraineeMessage.UpdatedDate;
            }

            public T MapToTableModel<T>() where T : class
            {
                DataAccessLogic.tblTraineeMessage traineeMessage = new DataAccessLogic.tblTraineeMessage();
                traineeMessage.ID = this.ID;
                traineeMessage.TraineeID = this.TraineeEntity.ID;
                traineeMessage.PhoneNumber = this.PhoneNumber;
                traineeMessage.Message = this.Message;
                traineeMessage.Status = this.Status;
                traineeMessage.CreatedBy = this.CreatedBy;
                traineeMessage.CreatedDate = this.CreatedDate;
                traineeMessage.UpdatedBy = this.UpdatedBy;
                traineeMessage.UpdatedDate = this.UpdatedDate;
                return traineeMessage as T;
            }
        }
    }
