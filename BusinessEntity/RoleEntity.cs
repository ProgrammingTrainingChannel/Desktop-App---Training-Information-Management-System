using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
    {
        public class RoleEntity
        {
        public int ID { get; set; }
        public string Name { get; set; }

        public RoleEntity()
            {
            }

            public RoleEntity(DataAccessLogic.tblRole tblRole)
            {
                this.ID = tblRole.ID;
                this.Name = tblRole.Name;
            }

            public T MapToTableModel<T>() where T : class
            {
                DataAccessLogic.tblRole role = new DataAccessLogic.tblRole();
            role.ID = this.ID;
            role.Name = this.Name;
                return role as T;
            }
        }
    }
