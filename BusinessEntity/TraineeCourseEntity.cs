using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
    {
        public class TraineeCourseEntity
        {
            public int ID { get; set; }
            public TraineeEntity TraineeEntity { get; set; }
            public CourseEntity CourseEntity { get; set; }
            public DateTime RegistrationDate { get; set; }
            public string Duration { get; set; }
            public decimal Cost { get; set; }
            public string CreatedBy { get; set; }
            public DateTime CreatedDate { get; set; }
            public string UpdatedBy { get; set; }
            public DateTime UpdatedDate { get; set; }

            public TraineeCourseEntity()
            {
            }

            public TraineeCourseEntity(DataAccessLogic.tblTraineeCourse tblTraineeCourse)
            {
                this.ID = tblTraineeCourse.ID;
                this.TraineeEntity = new TraineeEntity(tblTraineeCourse.tblTrainee);
                this.CourseEntity = new CourseEntity(tblTraineeCourse.tblCourse);
                this.RegistrationDate = tblTraineeCourse.RegistrationDate;
                this.Duration = tblTraineeCourse.Duration;
                this.Cost = tblTraineeCourse.Cost;
                this.CreatedBy = tblTraineeCourse.CreatedBy;
                this.CreatedDate = tblTraineeCourse.CreatedDate;
                this.UpdatedBy = tblTraineeCourse.UpdatedBy;
                this.UpdatedDate = (DateTime)tblTraineeCourse.UpdatedDate;
            }

            public T MapToTableModel<T>() where T : class
            {
                DataAccessLogic.tblTraineeCourse traineeCourse = new DataAccessLogic.tblTraineeCourse();
                traineeCourse.ID = this.ID;
                traineeCourse.TraineeID = this.TraineeEntity.ID;
                traineeCourse.CourseID = this.CourseEntity.ID;
                traineeCourse.RegistrationDate = this.RegistrationDate;
                traineeCourse.Duration = this.Duration;
                traineeCourse.Cost = this.Cost;
                traineeCourse.CreatedBy = this.CreatedBy;
                traineeCourse.CreatedDate = this.CreatedDate;
                traineeCourse.UpdatedBy = this.UpdatedBy;
                traineeCourse.UpdatedDate = this.UpdatedDate;
                return traineeCourse as T;
            }
        }
    }
