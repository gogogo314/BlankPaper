using BlankPaper.ConsoleApp.Domain.Model;
using BlankPaper.ConsoleApp.Domain.Service;
using BlankPaper.ConsoleApp.Presentation;
using System;

namespace BlankPaper.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new SystemService();
            service.SetDataByDefault();//准备数据 
            /*
             * 实现学生成绩的插入
             * 通过名字查询
             * 显示总成绩排名列表
             */
            UIInit();//显示初始界面

            switch (Console.ReadLine())
            {
                case "1":
                    var student = UIGetStudent();
                    service.AddStudent(student);
                    break;
                case "2":break;
                case "3":break;
            }

            service.ShowStudentInformations(100, new ConsoleOutput());

            //var stu = service.QueryStudent(101);
            //service.SortByScore();
        }

        static public void UIInit() //显示初始界面
        {
            Console.WriteLine("请选择你的操作：");
            Console.WriteLine("1、添加学生");
            Console.WriteLine("2、通过名字查询");
            Console.WriteLine("3、显示总成绩排名列表");
        }

        static Student UIGetStudent()
        {
            var student = new Student();
            Console.WriteLine("请输入学生基本信息");
            Console.Write("===>id：");
            student.Id = int.Parse(Console.ReadLine());

            Console.Write("===>Name:");
            student.Name = Console.ReadLine();

            return student;

        }
        
    }
}

