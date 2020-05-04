using BlankPaper.ConsoleApp.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BlankPaper.ConsoleApp.Presentation;

namespace BlankPaper.ConsoleApp.Domain.Service
{
    public class SystemService
    {
        protected List<Student> students { get; set; }
        public SystemService()
        {
            this.students = new List<Student>();
        }

        public void SetDataByDefault()//初始化数据
        {
            for (var i = 100; i < 110; i++)//加入10个学生,每个学生有3门课
            {
                //学生个人信息初始化
                var student = new Student()
                {
                    Id = i,
                    Name = $"Name-{i}",
                    ClassCode = "计0" + i
                };
                //学生课程信息初始化
                var courses = new List<Course>();
                courses.Add(new Course() { Id = 1001, Name = "C#程序设计", Score = i });
                courses.Add(new Course() { Id = 1002, Name = "HTML+CSS", Score = i });
                courses.Add(new Course() { Id = 1003, Name = "ASP .NET CORE", Score = i });
                student.Courses = courses;

                this.students.Add(student);
            }
        }


        //业务逻辑
        #region Business Actions 
        /// <summary>
        /// 显示特定Id的学生信息
        /// </summary>
        /// <param name="id">学生Id</param>
        public void ShowStudentInformations(int id,IOutput output)
        {
            var student = QueryStudent(id);//查找该学生
            if (student == null)
            {
                throw new Exception(string.Format("没有学生Id={0}",id)) ; 
            }

            student.ShowInformation(output);
        }


        /// <summary>
        /// 新增学生
        /// </summary>
        /// <param name="model"></param>
        public void AddStudent(Student model)
        {
            if (students.Exists(x => x.Id == model.Id))
            {
                throw new Exception($"已存在学号为：{model.Id}的学生！");
            }
            students.Add(model);
            //SaveToFile();

        }
        /// <summary>
        /// 用Id查询学生
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Student QueryStudent(int id)
        {
            Student student = null;
            student = this.students.Find(x => x.Id == id);
            return student;
        }
        /// <summary>
        /// 用分数排序
        /// </summary>
        public void SortByScore()
        {
            this.students.Sort((x, y) =>
            {
                var xScore = x.Courses.Sum(coures => coures.Score);
                var yScore = y.Courses.Sum(coures => coures.Score);
                return xScore.CompareTo(yScore);
            });
        }
        /// <summary>
        ///存到文件 
        /// </summary>
        public void SaveToFile()
        {
        }
        /// <summary>x
        /// 从文件中加载
        /// </summary>
        public void LoadFromFile()
        { }
        #endregion Business Actions 
    }
}

