using DAL.Dal;
using DAL.Interfaces;
using DTO;
using Logic.Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using mixandmatchv3.Controllers;
using Moq;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mixandmatchv3.Controllers.Tests
{
    [TestClass()]
    public class JobsTests
    {
        [TestMethod()]
        public void DetailsTest()
        {
            DateTime starting = new DateTime(2019, 05, 09, 09, 15, 00);
            DateTime ending = new DateTime(2019, 08, 09, 09, 15, 00);
            int id = 1;
            Job expectedJob = new Job()
            {
                id = 1,
                name = "software engineering",
                description = "softwaree engineering description",
                start = starting,
                end = ending,
        Hiring_Managerid = new hiring_manager()
                {
                    id=1,
                    name= "joelle",
        
                }
            };
            var jobsMock = new Mock<IJobDAL>();
            jobsMock.Setup(x=> x.GetJob(id))
                .Returns(expectedJob);
            
            var joblogic = new JobLogic(jobsMock.Object);
            var jobcontroller = new JobsController(joblogic);
            var result = jobcontroller.Details(id);


            Assert.IsNotNull(result);   

            //Assert.IsInstanceOfType(result, typeof(OkObjectResult));
            //if((Type)result == typeof(OkObjectResult))
            //{
            //    Assert.Equals(((OkObjectResult)result).Value, expectedJob);
            //}

            Console.WriteLine(result);
            //Assert.Equals(expectedJob.name, result);
            //Assert.Equals(expectedJob.id, result);
        }
    }
}