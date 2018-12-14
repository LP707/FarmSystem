using FarmSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.FindANameFarm
{

    [TestClass]
    public class UnitTest1
    {
        private readonly DataAccess _dataAccess = DataAccess.instance();
        private readonly MetaLayer _metaLayer = MetaLayer.instance();
        private DbConection _dbCheck = DBCheck.instance();

        [TestMethod]
        public void GetInst_IsSingleton_dataAccess()
        {
            //Arrange
            var instance1 = _dataAccess.InstanceCount;
            var instance2 = _dataAccess.InstanceCount;
            //Act
            //Assert
            Assert.AreEqual(instance1, instance2);
            Assert.AreEqual(_metaLayer.InstanceCount, 1);
        }

        [TestMethod]
        public void GetInst_IsSingleton_MetaLayer()
        {
            //Arrange
            var instance1 = _metaLayer.InstanceCount;
            var instance2 = _metaLayer.InstanceCount;
            //Act
            //Assert
            Assert.AreEqual(instance1, instance2);
            Assert.AreEqual(_metaLayer.InstanceCount, 1);
        }



        //[TestMethod]
        //public void GetInst_IsSingleton_DbCheck()
        //{
        //    //Arrange
        //    var instance1 = _dbCheck.InstanceCount;
        //    var instance2 = _dbCheck.InstanceCount;
        //    //Act
        //    //Assert
        //    Assert.AreEqual(instance1, instance2);
        //    Assert.AreEqual(_dbCheck.InstanceCount, 1);
        //}
    }
}
