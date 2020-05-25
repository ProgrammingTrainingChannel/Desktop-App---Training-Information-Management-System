using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
    {
        public class TraineeCourseCostEntity
    {
        public int ID { get; set; }
        public string TraineeCourseDetail { get; set; }

        public TraineeCourseCostEntity()
            {
            }

            public TraineeCourseCostEntity(DataAccessLogic.View_TraineeCourseCost traineeCourseCost)
            {
                this.ID = traineeCourseCost.ID;
                this.TraineeCourseDetail = traineeCourseCost.TraineeCourseDetail;
            }
        }
    }
