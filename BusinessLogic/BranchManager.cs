using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLogic;

namespace BusinessLogic
    {
         public class BranchManager
         {
             public List<BranchEntity> GetAll() 
         { 
             try 
             { 
                 List<BranchEntity> BranchEntities = new List<BranchEntity>(); 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 List<tblBranch> Branchs = entity.tblBranches.ToList(); 

                 foreach (tblBranch tblBranch in Branchs) 
                 { 
                     BranchEntity Branch = new BranchEntity(); 
                     Branch.ID = tblBranch.ID; 
                     Branch.Name = tblBranch.Name; 

                     BranchEntities.Add(Branch); 
                 } 
                 return BranchEntities; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public BranchEntity GetSingle(int ID) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 

                 tblBranch tblBranch = entity.tblBranches.Where(x => x.ID == ID).FirstOrDefault(); 
                 BranchEntity Branch = new BranchEntity(); 
                 Branch.ID = tblBranch.ID; 
                 Branch.Name = tblBranch.Name; 

                 return Branch; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public bool Save(BranchEntity Branch) 
         { 
             try 
             { 
                 tblBranch tblBranch = new tblBranch();

                tblBranch.ID = Branch.ID;
                tblBranch.Name = Branch.Name; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 entity.tblBranches.Add(tblBranch); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Update(BranchEntity Branch) 
         { 
             try 
             { 
                 tblBranch newBranch = new tblBranch(); 

                 newBranch.ID = Branch.ID; 
                 newBranch.Name = Branch.Name; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblBranch oldBranch = entity.tblBranches.Where(x => x.ID == Branch.ID).FirstOrDefault(); 
                 entity.Entry(oldBranch).CurrentValues.SetValues(newBranch); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Delete(BranchEntity Branch) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblBranch tblBranch = entity.tblBranches.Where(x => x.ID == Branch.ID).FirstOrDefault(); 

                 entity.tblBranches.Remove(tblBranch); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 

         }
    }
