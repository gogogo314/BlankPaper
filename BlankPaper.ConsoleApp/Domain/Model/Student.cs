using BlankPaper.ConsoleApp.Presentation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlankPaper.ConsoleApp.Domain.Model
{
    /// <summary>
    /// 学生类
    /// </summary>
    public class Student    
    {
        #region Filed
        /// <summary>
        /// 学号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 学生姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 学生班级
        /// </summary>
        public string ClassCode { get; set; }
        public List<Course> Courses { get; set; }
        #endregion

        #region Action
        public void ShowInformation(IOutput output)
        {
            output.WriteLine("学生基本信息");
            output.WriteLine($"==>Id:{this.Id}");
            output.WriteLine($"==>Name:{this.Name}");
            output.WriteLine($"==>ClassCode{this.ClassCode}");

            output.WriteLine("成绩信息列表：");
            Courses.ForEach(x => x.ShowInformation(output));
            //foreach (var course in Courses)
            //{
            //    course.ShowInformation();
                
            //}
        }
        #endregion
    }
}
