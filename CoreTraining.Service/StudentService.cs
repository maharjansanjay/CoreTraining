using CoreTraining.Data;
using CoreTraining.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoreTraining.Service
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int id);
        Student GetStudent(int id);
    }

    public class StudentService : IStudentService
    {
        private CoreTrainingContext _db;

        public StudentService(CoreTrainingContext db)
        {
            _db = db;
        }

        public int AddStudent(Student student)
        {
            _db.Students.Add(student);
            return _db.SaveChanges();
        }

        public int DeleteStudent(int id)
        {
            var student = _db.Students.Find(id);
            _db.Students.Remove(student);
            return _db.SaveChanges();
        }

        public Student GetStudent(int id)
        {
            return _db.Students.Find(id);
        }

        public List<Student> GetStudents()
        {
            return _db.Students.ToList();
        }

        public int UpdateStudent(Student student)
        {
            _db.Students.Update(student);
            return _db.SaveChanges();
        }
    }
}
