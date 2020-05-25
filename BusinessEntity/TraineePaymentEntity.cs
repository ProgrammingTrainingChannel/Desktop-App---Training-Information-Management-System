using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
    {
        public class TraineePaymentEntity
        {
            public int ID { get; set; }
            public TraineeCourseEntity TraineeCourseEntity { get; set; }
            public DateTime PaymentDate { get; set; }
            public decimal PaymentAmount { get; set; }
            public string CreatedBy { get; set; }
            public DateTime CreatedDate { get; set; }
            public string UpdatedBy { get; set; }
            public DateTime UpdatedDate { get; set; }

            public TraineePaymentEntity()
            {
            }

            public TraineePaymentEntity(DataAccessLogic.tblTraineePayment tblTraineePayment)
            {
                this.ID = tblTraineePayment.ID;
                this.TraineeCourseEntity = new TraineeCourseEntity(tblTraineePayment.tblTraineeCourse);
                this.PaymentDate = tblTraineePayment.PaymentDate;
                this.PaymentAmount = tblTraineePayment.PaymentAmount;
                this.CreatedBy = tblTraineePayment.CreatedBy;
                this.CreatedDate = tblTraineePayment.CreatedDate;
                this.UpdatedBy = tblTraineePayment.UpdatedBy;
                this.UpdatedDate = (DateTime)tblTraineePayment.UpdatedDate;
            }

            public T MapToTableModel<T>() where T : class
            {
                DataAccessLogic.tblTraineePayment traineePayment = new DataAccessLogic.tblTraineePayment();
                traineePayment.ID = this.ID;
                traineePayment.TraineeCourseID = this.TraineeCourseEntity.ID;
                traineePayment.PaymentDate = this.PaymentDate;
                traineePayment.PaymentAmount = this.PaymentAmount;
                traineePayment.CreatedBy = this.CreatedBy;
                traineePayment.CreatedDate = this.CreatedDate;
                traineePayment.UpdatedBy = this.UpdatedBy;
                traineePayment.UpdatedDate = this.UpdatedDate;
                return traineePayment as T;
            }
        }
    }
