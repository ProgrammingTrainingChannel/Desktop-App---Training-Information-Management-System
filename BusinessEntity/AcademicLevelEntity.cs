using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
    {
        public class AcademicLevelEntity
        {
            public int ID { get; set; }
            public string Title { get; set; }

            public AcademicLevelEntity()
            {
            }

            public AcademicLevelEntity(DataAccessLogic.tblAcademicLevel tblAcademicLevel)
            {
                this.ID = tblAcademicLevel.ID;
                this.Title = tblAcademicLevel.Title;
            }

            public T MapToTableModel<T>() where T : class
            {
                DataAccessLogic.tblAcademicLevel academicLevel = new DataAccessLogic.tblAcademicLevel();
                academicLevel.ID = this.ID;
                academicLevel.Title = this.Title;
                return academicLevel as T;
            }
        }
    }
