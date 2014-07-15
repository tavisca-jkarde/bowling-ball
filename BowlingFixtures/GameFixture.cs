using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bowling;
namespace BowlingFixtures
{
    [TestClass]
    public class GameFixture
    {
        Game obj = new Game();

        [TestMethod]
        public void NegativeValueShouldThrow()
        {
            
            var negValue = -1;
            try
            {
                obj.Roll(negValue);
                Assert.Fail("No exception has been raised.");
            }
            catch (OverflowException ex)
            {
                
            }
            catch (Exception ex) {
                Assert.Fail("cought Exception of type{0} when pin has bin inputed negative", ex.GetType().Name);

            }
        }

        [TestMethod]
        public void valueGreaterThanTenShouldThrow() 
        {
            var greaterValue = 11;

            try
            {
                obj.Roll(greaterValue);
                Assert.Fail("No exception has been raised.");
            }
            catch (OverflowException)
            {

            }
            catch (Exception ex)
            {
                Assert.Fail("cought Exception of type{0} when pin has bin inputed more than greaterValue", ex.GetType().Name);

            }
        
        }
        [TestMethod]
        public void TestAllCase()
        {
            try
            {
                obj.Roll(10);

                obj.Roll(8);
                obj.Roll(2);

                obj.Roll(5);
                obj.Roll(2);

                obj.Roll(5);
                obj.Roll(5);

                obj.Roll(7);
                obj.Roll(1);

                obj.Roll(8);
                obj.Roll(2);

                obj.Roll(2);
                obj.Roll(3);

                obj.Roll(5);
                obj.Roll(2);

                obj.Roll(7);
                obj.Roll(3);

                obj.Roll(5);
                obj.Roll(5);

                obj.Roll(5);
                obj.Roll(8);


                int result = obj.GetScore();

                  
                Assert.Fail("No exception has been raised.");
            }
            catch (OverflowException)
            {

            }
            catch (Exception ex)
            {
                Assert.Fail("cought Exception of type{0} when pin has bin inputed more than greaterValue", ex.GetType().Name);

            }
        }

            
    }
}
