using Microsoft.VisualStudio.TestTools.UnitTesting;
using AutomatedTestLibrary;
using System;

namespace AutomatedTestingMSTestProject {
    [TestClass]

    public class Tests {

        Functions functions = null;


        [TestInitialize]//must have the attribute "setup" for any test can be called.
        public void Setup()//must be public void and cannot take any parameters
        {
            functions = new Functions();



        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]////allows for an exception to be thrown as an exception.  Note: Must have a test set up to throw the exception.







        [TestMethod]//must have test attribute and only those marked with "test" can be used
        public void Test1()//must be public void and cannot take any parameters
        {
            var answer = functions.Add1(0);
            Assert.AreEqual(1, answer);
            answer = functions.Add1(-1);
            Assert.AreEqual(0, answer);


        }
        //[Test]//must have test attribute and only those marked with "test" can be used
        //public void Test1()//must be public void and cannot take any parameters
        //{
        //    var answer = functions.Add1(3);
        //    Assert.AreEqual(4, answer);
        //}
        [TestMethod]
        public void Test2() {
            var answer = functions.Add1(3);
            Assert.AreEqual(3, answer);


        }
        [TestMethod]
        public void TesstXSquaredPlus3() {//test 0
            var ans = functions.XSquaredPlus3(0);
            Assert.AreEqual(3, ans);
            //test 3
            ans = functions.XSquaredPlus3(3);
            Assert.AreEqual(12, ans);
            //test -1
            ans = functions.XSquaredPlus3(-1);
            Assert.AreEqual(4, ans);

            //test -10
            ans = functions.XSquaredPlus3(-10);
            Assert.AreEqual(103, ans);



        }
        [TestMethod]
        public void TestX7X12() {
            //Test 0
            var ans = functions.X7X12(0);
            Assert.AreEqual(12, ans);

            //Test -1
            ans = functions.X7X12(-1);
            Assert.AreEqual(20, ans);

            //Test 1
            Assert.AreEqual(6, functions.X7X12(1));

           

        }



    }
}
