using System;
using Xunit;
using ProjectFirst.Models;

namespace ToDoTestProject
{
    public class PersonTest
    {
        [Theory]
        [InlineData(1,"ALI", "Hadi", "ALI")]
        [InlineData(1, "", "Hadi", "")]
        [InlineData(1, null, "Hadi", null)]
        public void FirstNameTest(int id, string first, string last, string expect)
        {
            //ARRANGE
            Person person = new Person(id, first,  last);

            //ACT
            string result = person.FirstName;
            //ASSERT
            Assert.Equal(expect, result);

        }

        [Theory]
        [InlineData(1, "ALI", "Hadi", "Hadi")]
        [InlineData(1, "ALI", "", "")]
        [InlineData(1, "ALI", null, null)]
        public void LastNameTest(int id, string first, string last, string expect)
        {
            //ARRANGE
            Person person = new Person(id, first, last);

            //ACT
            string result = person.LastName;
            //ASSERT
            Assert.Equal(expect, result);

        }
    }
}
