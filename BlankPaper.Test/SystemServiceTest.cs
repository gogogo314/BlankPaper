using BlankPaper.ConsoleApp.Domain.Model;
using BlankPaper.ConsoleApp.Domain.Service;
using System;
using Xunit;


namespace BlankPaper.Test
{
    public class SystemServiceTest
    {
        [Fact]
        public void Test1()
        {
            var service = new SystemService();
            service.AddStudent(new Student { Id = 1001 ,Name="Alan"});
            var stu = service.QueryStudent(1001);
            stu = new Student(){ Id=100,Name="q"};

            Assert.Equal(1001, stu.Id);
            Assert.Equal("Alan", stu.Name);
        }
    }
}
