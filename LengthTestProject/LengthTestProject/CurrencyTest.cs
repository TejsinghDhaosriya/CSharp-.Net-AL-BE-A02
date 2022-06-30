using LengthClassLibrary;
using LengthClassLibrary.exceptions;

namespace LengthTestProject
{
    public class CurrencyTest
    {
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
