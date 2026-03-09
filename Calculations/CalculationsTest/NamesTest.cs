using Calculations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsTest
{
    public class NamesTest
    {
        [Fact]

        public void NickNameTest1()
        {
            //Arrange
            var names = new Names();
            //Act
            names.MakeFullName("Kiss", "Pista");
            //Assert
            Assert.Equal("K+P", names.NickName);
        }



        [Fact]
        public void MakeFullNameTest1()
        {
            //Arrange
            var names = new Names();
            //Act
            var fullName = names.MakeFullName("Kiss", "Pista");
            //Assert
            Assert.Equal("Kiss Pista", fullName);
        }
    }
}
