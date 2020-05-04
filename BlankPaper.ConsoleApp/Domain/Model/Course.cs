using BlankPaper.ConsoleApp.Presentation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlankPaper.ConsoleApp.Domain.Model
{
    /// <summary>
    /// 课程类
    /// </summary>
    public class Course
    {
        /// <summary>
        /// 课程代码
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 课程名称
        /// </summary>
        public string Name { get ; set ; }
        /// <summary>
        /// 学分
        /// </summary>
        public decimal Score { get; set; }

        #region Action
        public void ShowInformation(IOutput output)
        {
            output.WriteLine($"{this.Id} - {this.Name} - {this.Score}");
        }
        #endregion
    }
}
