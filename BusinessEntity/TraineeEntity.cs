using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
    {
        public class TraineeEntity
        {
            public int ID { get; set; }
            public string Fullname { get; set; }
            public DateTime BirthDate { get; set; }
            public GenderEntity GenderEntity { get; set; }
            public AcademicLevelEntity AcademicLevelEntity { get; set; }
            public BranchEntity BranchEntity { get; set; }
        
            public string Address { get; set; }
            public string PhoneNumber { get; set; }
            public byte[] Photo { get; set; }
            public string CreatedBy { get; set; }
            public DateTime CreatedDate { get; set; }
            public string UpdatedBy { get; set; }
            public DateTime UpdatedDate { get; set; }

            public TraineeEntity()
            {
            }

            public TraineeEntity(DataAccessLogic.tblTrainee tblTrainee)
            {
                this.ID = tblTrainee.ID;
                this.Fullname = tblTrainee.Fullname;
                this.BirthDate = tblTrainee.BirthDate;
                this.GenderEntity = new GenderEntity(tblTrainee.tblGender);
            this.AcademicLevelEntity = new AcademicLevelEntity(tblTrainee.tblAcademicLevel);
            this.BranchEntity = new BranchEntity(tblTrainee.tblBranch);
            this.Address = tblTrainee.Address;
                this.PhoneNumber = tblTrainee.PhoneNumber;
                this.Photo = tblTrainee.Photo;
                this.CreatedBy = tblTrainee.CreatedBy;
                this.CreatedDate = tblTrainee.CreatedDate;
                this.UpdatedBy = tblTrainee.UpdatedBy;
                this.UpdatedDate = (DateTime) tblTrainee.UpdatedDate;
            }

            public T MapToTableModel<T>() where T : class
            {
                DataAccessLogic.tblTrainee trainee = new DataAccessLogic.tblTrainee();
                trainee.ID = this.ID;
                trainee.Fullname = this.Fullname;
                trainee.BirthDate = this.BirthDate;
            trainee.GenderID = this.GenderEntity.ID;
            trainee.AcademicLevelID = this.AcademicLevelEntity.ID;
            trainee.BranchID = this.GenderEntity.ID;
            trainee.Address = this.Address;
                trainee.PhoneNumber = this.PhoneNumber;
                trainee.Photo = this.Photo;
                trainee.CreatedBy = this.CreatedBy;
                trainee.CreatedDate = this.CreatedDate;
                trainee.UpdatedBy = this.UpdatedBy;
                trainee.UpdatedDate = this.UpdatedDate;
                return trainee as T;
            }
        }
    }
