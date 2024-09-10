namespace PersonalRegister.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void getNameTest()
        {
            PersonalRegister pr1 = new PersonalRegister("Johan", 25000);
            Assert.Equal("Johan", pr1.getName());
        }

        [Fact]
        public void getSalaryTest()
        {
            PersonalRegister pr1 = new PersonalRegister("Johan", 25000);
            Assert.Equal(25000, pr1.getSalary());
        }

        [Fact]
        public void checkValidNameTest()
        {
            Assert.True(PersonalRegister.checkValidName("Johan"));
            Assert.False(PersonalRegister.checkValidName("Joh n"));
            Assert.False(PersonalRegister.checkValidName("Joh4n"));
        }

        [Fact]
        public void checkValidSalaryTest()
        {
            Assert.True(PersonalRegister.checkValidSalary("25700"));
            Assert.True(PersonalRegister.checkValidSalary("0930")); // 0930 = 930 kr i lön
            Assert.False(PersonalRegister.checkValidSalary("-1"));
            Assert.False(PersonalRegister.checkValidSalary("hej"));
        }
    }
}