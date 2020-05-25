using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
    {
        public class CourseEntity
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }

            public CourseEntity()
            {
            }

            public CourseEntity(DataAccessLogic.tblCourse tblCourse)
            {
                this.ID = tblCourse.ID;
                this.Title = tblCourse.Title;
                this.Description = tblCourse.Description;
            }

            public T MapToTableModel<T>() where T : class
            {
                DataAccessLogic.tblCourse course = new DataAccessLogic.tblCourse();
                course.ID = this.ID;
                course.Title = this.Title;
                course.Description = this.Description;
                return course as T;
            }
        }
    }
