using System;
using LengthClassLibrary;
namespace LengthTestProject
{
    public class UnitTest
    {

        [Fact]
        public void shouldReturnStringLengthAs0()
        {
            string data = "";

            LengthHelper lh = new LengthHelper();
            int len = lh.findLength(data);

            Assert.Equal(0, len);
        }


        [Fact]
        public void shouldReturnStringLengthAs1()
        {
            string data = "a"; 

            LengthHelper lh = new LengthHelper();
            int len = lh.findLength(data);

            Assert.Equal(1, len);
        }

        [Fact]
        public void shouldReturnStringLengthAs3()
        {
            string data = "123";

            LengthHelper lh = new LengthHelper();
            int len = lh.findLength(data);

            Assert.Equal(3, len);
        }

        [Fact]
        public void shouldReturnStringLengthAs12()
        {
            string data = "123456789010";

            LengthHelper lh = new LengthHelper();
            int len = lh.findLength(data);

            Assert.Equal(12, len);
        }

        [Fact]
        public void shouldReturnStringSizeAs0WhenDataIsNullPassed()
        {
            string data = null;

            LengthHelper lh = new LengthHelper();
            int len = lh.findLength(data);

            Assert.Equal(0, len);
        }

    }
}