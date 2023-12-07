using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DTO;
using Moq;

namespace Logic.Tests
{
    [TestClass()]
    public class JobsTests
    {
        [TestMethod()]
        public void GetJobIsNotNullTest()
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
                    id = 1,
                    name = "joelle",

                }
            };
            var jobsMock = new Mock<IJobDAL>();
            jobsMock.Setup(x => x.GetJob(id))
                .Returns(expectedJob);

            var joblogic = new JobLogic(jobsMock.Object);
            var result = joblogic.getjob(id);
            Assert.IsNotNull(result);
            
        }

        [TestMethod()]
        public void JobsDetailsException_HiringManager_Missing()
        {

                DateTime starting = new DateTime(2019, 05, 09, 09, 15, 00);
                DateTime ending = new DateTime(2019, 08, 09, 09, 15, 00);
                int id = 1;
                Job actualjob = new Job()
                {
                    id = 1,
                    name = "software engineering",
                    description = "softwaree engineering description",
                    start = starting,
                    end = ending,

                };
                var jobsMock = new Mock<IJobDAL>();
                jobsMock.Setup(x => x.GetJob(id))
                    .Returns(actualjob);

                var joblogic = new JobLogic(jobsMock.Object);
            Assert.ThrowsException<NullReferenceException> (() => joblogic.getjob(id));

        }
        [TestMethod()]
        public void GetJob_Wrong_Id_Execption()
        {
            DateTime starting = new DateTime(2019, 05, 09, 09, 15, 00);
            DateTime ending = new DateTime(2019, 08, 09, 09, 15, 00);
            int id = 20;
            Job expectedJob = new Job()
            {
                id = 1,
                name = "software engineering",
                description = "softwaree engineering description",
                start = starting,
                end = ending,
                Hiring_Managerid = new hiring_manager()
                {
                    id = 1,
                    name = "joelle",

                }
            };
            var jobsMock = new Mock<IJobDAL>();
            jobsMock.Setup(x => x.GetJob(id))
                .Returns(expectedJob);

            var joblogic = new JobLogic(jobsMock.Object);
           
           
            Exception e = new Exception("not found correct job");
            var ex = Assert.ThrowsException<Exception>(()  => joblogic.getjob(id));
            Assert.AreEqual("not found correct job", ex.Message);
        }
    }
}