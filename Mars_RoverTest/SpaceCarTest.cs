using System;
using Mars_Rover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mars_RoverTest
{
    [TestClass]
    public class SpaceCarTest
    {
        [TestMethod]
        public void SpaceCarTesting()
        {
            //https://docs.microsoft.com/tr-tr/visualstudio/test/walkthrough-creating-and-running-unit-tests-for-managed-code?view=vs-2019

            SpaceCar car1 = new SpaceCar(1, 2, new N());  
            try
            {
                car1.Move("LMLMLMLMM");
                car1.GetCarLocation();
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, "");
                return;
            }  

        }
    }
}
