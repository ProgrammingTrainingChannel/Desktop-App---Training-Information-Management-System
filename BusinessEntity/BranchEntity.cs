using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntity
    {
        public class BranchEntity
    {
            public int ID { get; set; }
            public string Name { get; set; }

            public BranchEntity()
            {
            }

            public BranchEntity(DataAccessLogic.tblBranch tblBranch)
            {
                this.ID = tblBranch.ID;
                this.Name = tblBranch.Name;
            }

            public T MapToTableModel<T>() where T : class
            {
                DataAccessLogic.tblBranch branch = new DataAccessLogic.tblBranch();
            branch.ID = this.ID;
            branch.Name = this.Name;
                return branch as T;
            }
        }
    }
