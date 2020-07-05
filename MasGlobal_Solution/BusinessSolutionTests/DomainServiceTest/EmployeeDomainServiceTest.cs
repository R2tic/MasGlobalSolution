using Bussines_Solution.DomainService;
using Bussines_Solution.DTO;
using Bussines_Solution.DTO.Mapping;
using DataAcces_Solution.Entities;
using DataAcces_Solution.Respositorys;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace BusinessSolutionTests.DomainServiceTest
{
    [TestFixture]
    class EmployeeDomainServiceTest
    {
        private EmployeDomainService sutEmployeDomainService;
        Mock<IEmployeRepository> mockemployRepositry;
        Mock<IEmployeDomainService> mockemployRepositry2;
        [SetUp]
        public void SetUp()
        {
            mockemployRepositry = new Mock<IEmployeRepository>(MockBehavior.Strict);
            mockemployRepositry2 = new Mock<IEmployeDomainService>(MockBehavior.Strict);
        }

        [Test]
        public void GetById_returns_DTO_ok()
        {
            //Arrange
            int employeeId = 1;
            var ExpectedEmploye = new Employe()
            {
                Id = 1,
                Name = "Elkin",
                ContractTypeName = "12",
                RoleId = 1,
                RoleName = "22",
                RoleDescription = "",
                HourlySalary = 1000,
                MonthlySalary = 5000

            };
            mockemployRepositry.Setup(repo => repo.Get(employeeId)).Returns(ExpectedEmploye);
            var dto = ExpectedEmploye.Map();

            //Act
            sutEmployeDomainService = new EmployeDomainService(mockemployRepositry.Object);
            var result = sutEmployeDomainService.GetById(employeeId);
           
            //Assert
            Assert.That(result.Id, Is.EqualTo(dto.Id));
        }

        [Test]
        public void GetById_Returns_Null()
        {
            //Arrange
            int employId = 10;
            var list = new List<string>();
            mockemployRepositry.Setup(repo => repo.Get(employId)).Returns((Employe)null);

            //Act
            sutEmployeDomainService = new EmployeDomainService(mockemployRepositry.Object);
            var result = sutEmployeDomainService.GetById(employId);

            //Assert
            Assert.That(result, Is.Null);
            //Assert.That(list.Count, Is.GreaterThanOrEqualTo(1));            
        }

        [Test]
        public void GetById_returns_DTOAnualSalary_ok()
        {
            //Arrange
            int employeeId = 1;
            var ExpectedEmploye = new Employe()
            {
                Id = 1,
                Name = "Elkin",
                ContractTypeName = "12",
                RoleId = 1,
                RoleName = "22",
                RoleDescription = "",
                HourlySalary = 1000,
                MonthlySalary = 5000,
               };
             mockemployRepositry.Setup(repo => repo.Get(employeeId)).Returns(ExpectedEmploye);
             var dto = ExpectedEmploye.MapAddAnualSalary();

            //Act
            sutEmployeDomainService = new EmployeDomainService(mockemployRepositry.Object);
            var result = sutEmployeDomainService.GetByIdWithAnualSalary(employeeId);

            //Assert
            Assert.That(result.Id, Is.EqualTo(dto.Id));
            Assert.That(result.Name, Is.EqualTo(dto.Name));
         }

        [Test]
        public void GetById_Returns_DTOAnualSalary_Null()
        {
            //Arrange
            int employId = 10;
            mockemployRepositry.Setup(repo => repo.Get(employId)).Returns((Employe)null);
           
            //Act
            sutEmployeDomainService = new EmployeDomainService(mockemployRepositry.Object);
            var result = sutEmployeDomainService.GetByIdWithAnualSalary(employId);

            //Assert
            Assert.That(result, Is.Null);
                     
        }

        [Test]
        public void Get_returns_DTOAnualSalary_ok()
        {
            //Arrange
            var ExpectedEmploye1 = new Employe()
            {
                Id = 1,
                Name = "Elkin",
                ContractTypeName = "12",
                RoleId = 1,
                RoleName = "22",
                RoleDescription = "",
                HourlySalary = 1000,
                MonthlySalary = 5000

            };
            var ExpectedEmploye2 = new Employe()
            {
                Id = 1,
                Name = "Elkin",
                ContractTypeName = "12",
                RoleId = 1,
                RoleName = "22",
                RoleDescription = "",
                HourlySalary = 1000,
                MonthlySalary = 5000

            };
            List<Employe> ListEmployees = new List<Employe>();
            ListEmployees.Add(ExpectedEmploye1);
            ListEmployees.Add(ExpectedEmploye2);
            mockemployRepositry.Setup(repo => repo.Get()).Returns(ListEmployees);
            //Act
            sutEmployeDomainService = new EmployeDomainService(mockemployRepositry.Object);
            var result = sutEmployeDomainService.GetWithAnualSalary();

            //Assert
            Assert.That(result[0].Id, Is.EqualTo(ExpectedEmploye1.Id));
            
        }
        
        [Test]
        public void Get_returns_ok()
        {
            //Arrange
            var ExpectedEmploye1 = new Employe()
            {
                Id = 1,
                Name = "Elkin",
                ContractTypeName = "12",
                RoleId = 1,
                RoleName = "22",
                RoleDescription = "",
                HourlySalary = 1000,
                MonthlySalary = 5000

            };
            var ExpectedEmploye2 = new Employe()
            {
                Id = 1,
                Name = "Elkin",
                ContractTypeName = "12",
                RoleId = 1,
                RoleName = "22",
                RoleDescription = "",
                HourlySalary = 1000,
                MonthlySalary = 5000

            };
            List<Employe> ListEmployees = new List<Employe>();
            ListEmployees.Add(ExpectedEmploye1);
            ListEmployees.Add(ExpectedEmploye2);
            mockemployRepositry.Setup(repo => repo.Get()).Returns(ListEmployees);
            //Act
            sutEmployeDomainService = new EmployeDomainService(mockemployRepositry.Object);
            var result = sutEmployeDomainService.Get();

            //Assert
            Assert.That(result[0].Id, Is.EqualTo(ExpectedEmploye1.Id));

        }


    }


}
