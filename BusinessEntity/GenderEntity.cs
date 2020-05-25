using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
    {
        public class GenderEntity
        {
            public int ID { get; set; }
            public string Title { get; set; }

            public GenderEntity()
            {
            }

            public GenderEntity(DataAccessLogic.tblGender tblGender)
            {
                this.ID = tblGender.ID;
                this.Title = tblGender.Title;
            }

            public T MapToTableModel<T>() where T : class
            {
                DataAccessLogic.tblGender gender = new DataAccessLogic.tblGender();
                gender.ID = this.ID;
                gender.Title = this.Title;
                return gender as T;
            }
        }
    }
