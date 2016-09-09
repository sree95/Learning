using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleViewer;
using PersonRepository.Fake;
using PersonRepository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleViewer.Test
{
    [TestClass]
    public class FakeVMTest
    {
        [TestInitialize]
        public void SetUp()
        {
            FakeRepository repository = new FakeRepository();
            SimpleContainer.MapInstance<IPersonRepository>(repository);
        }

        [TestMethod]
        public void People_OnFetchData_IsPopulated()
        {
            //Arrange

            var viewModel = new MainViewModel();

            //Act
            viewModel.FetchData();

            //Assert
            Assert.IsNotNull(viewModel.People);
            Assert.AreEqual(2, viewModel.People.Count());
        }

        [TestMethod]
        public void RepositoryType_OnCreation_ReturnsFakeRepositoryString()
        {
            //Arrange // Act

            var viewModel = new MainViewModel();
            var expectedResult = "PersonRepository.Fake.FakeRepository";

            // Assert

            Assert.AreEqual(expectedResult, viewModel.RepositoryType);
        }
    }
}
