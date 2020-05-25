using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntity;
using DataAccessLogic;

namespace BusinessLogic
    {
         public class CourseManager
         {
             public List<CourseEntity> GetAll() 
         { 
             try 
             { 
                 List<CourseEntity> CourseEntities = new List<CourseEntity>(); 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 List<tblCourse> Courses = entity.tblCourses.ToList(); 

                 foreach (tblCourse Course in Courses) 
                 { 
                     CourseEntity course = new CourseEntity(); 
                     course.ID = Course.ID; 
                     course.Title = Course.Title; 
                     course.Description = Course.Description; 

                     CourseEntities.Add(course); 
                 } 
                 return CourseEntities; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public CourseEntity GetSingle(int ID) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 

                 tblCourse Course = entity.tblCourses.Where(x => x.ID == ID).FirstOrDefault(); 
                 CourseEntity course = new CourseEntity(); 
                 course.ID = Course.ID; 
                 course.Title = Course.Title; 
                 course.Description = Course.Description; 

                 return course; 
             } 
             catch (Exception ex) 
             { 
                 return null; 
             } 
         } 


             public bool Save(CourseEntity course) 
         { 
             try 
             { 
                 tblCourse Course = new tblCourse(); 

                 Course.ID = course.ID; 
                 Course.Title = course.Title; 
                 Course.Description = course.Description; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 entity.tblCourses.Add(Course); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Update(CourseEntity course) 
         { 
             try 
             { 
                 tblCourse newCourse = new tblCourse(); 

                 newCourse.ID = course.ID; 
                 newCourse.Title = course.Title; 
                 newCourse.Description = course.Description; 

                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblCourse oldCourse = entity.tblCourses.Where(x => x.ID == course.ID).FirstOrDefault(); 
                 entity.Entry(oldCourse).CurrentValues.SetValues(newCourse); 
                 entity.SaveChanges(); 
                 return true; 
             } 
             catch (Exception) 
             { 
                 throw; 
             } 
         } 


             public bool Delete(CourseEntity course) 
         { 
             try 
             { 
                 TIMSDBEntities entity = new TIMSDBEntities(); 
                 tblCourse Course = entity.tblCourses.Where(x => x.ID == course.ID).FirstOrDefault(); 

                 entity.tblCourses.Remove(Course); 
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
