using System;
using Xunit;
using ProjectFirst.Models;

namespace ToDoTestProject
{
    public class TodoTest
    {
        [Theory]
        [InlineData(1,"Hi", "ALI")]
        [InlineData(1, "Hellow", "Hellow")]
        [InlineData(1,  "yes", "yes")]
        public void DescriptionTest(int id,  string last, string expect)
        {
            //ARRANGE
           Todo to = new Todo(id,   last);

            //ACT
            string result = to.Description;
            //ASSERT
            Assert.Equal(expect, result);

        }

        [Theory]
        [InlineData(1, "ALI", true, true)]
        [InlineData(1, "ALI", false, false)]

        public void DoneTest(int id,  string description, bool input,bool expect)
        {
            //ARRANGE
            Todo to = new Todo(id, description);
            to.Done = input;
            //ACT
           var  result = to.Done;
            //ASSERT
            Assert.Equal(expect, result);

        }
    }
}
