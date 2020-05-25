using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
    {
        public class UserEntity
        {
            public int ID { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }

            public UserEntity()
            {
            }

            public UserEntity(DataAccessLogic.tblUser tblUser)
            {
                this.ID = tblUser.ID;
                this.Username = tblUser.Username;
                this.Password = tblUser.Password;
            }

            public T MapToTableModel<T>() where T : class
            {
                DataAccessLogic.tblUser user = new DataAccessLogic.tblUser();
                user.ID = this.ID;
                user.Username = this.Username;
                user.Password = this.Password;
                return user as T;
            }
        }
    }
