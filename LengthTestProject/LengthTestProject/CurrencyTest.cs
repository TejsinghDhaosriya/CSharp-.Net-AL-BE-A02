using LengthClassLibrary;
using LengthClassLibrary.exceptions;

namespace LengthTestProject
{
    public class CurrencyTest
    {

        [Fact]
        public void ShouldReturnCurrencyWhenStringIsEmpty()
        {
            var data = "";

            var res = Currency.ToCurrency(null, data);


            Assert.Equal("$" + data, res);
        }

        [Fact]
        public void ShouldReturnCurrencyWhenStringIsNull()
        {
            string data = null;

            var ex = Assert.Throws<InvalidCurrencyException>(() => Currency.ToCurrency(null, data));


            Assert.Equal("No Currency Passed", ex.Message);
        }

        [Fact]
        public void ShouldReturnCurrencyWhenStringIsValid()
        {
            var data = "aa";

            var res = Currency.ToCurrency(null,data);


            Assert.Equal("$"+data, res);
        }


        [Fact]
        public void ShouldThrowErrorWhenStringIsInValid()
        {
            var data = "aaa123a";

            var ex = Assert.Throws<InvalidCurrencyException>(() => Currency.ToCurrency(null, data));

            
            Assert.Equal("Invalid Currency Passed: "+data, ex.Message);
        }
    }
}
