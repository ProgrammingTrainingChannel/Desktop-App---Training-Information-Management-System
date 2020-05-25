using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
    {
        public class UserRoleEntity
    {
        public int ID { get; set; }
        public RoleEntity Role { get; set; }
        public UserEntity User { get; set; }

        public UserRoleEntity()
            {
            }

            public UserRoleEntity(DataAccessLogic.tblUserRole tblUserRole)
            {
                this.ID = tblUserRole.ID;
                this.Role = new RoleEntity(tblUserRole.tblRole);
                this.User = new UserEntity(tblUserRole.tblUser);
            }

            public T MapToTableModel<T>() where T : class
            {
                DataAccessLogic.tblUserRole userRole = new DataAccessLogic.tblUserRole();
            userRole.ID = this.ID;
            userRole.RoleID = this.Role.ID;
            userRole.UserID = this.User.ID;

            return userRole as T;
            }
        }
    }
