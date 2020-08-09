using NUnit.Framework;
using Moq;
using ComponentProcessingMicroservice.Models;
using ComponentProcessingMicroservice.Controllers;
using ComponentProcessingMicroservice.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using ReturnOrderPortal.Models;
using System;

namespace ComponentProcessingMicroserviceTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

       readonly CardDetails detail = new CardDetails()
        {
            CreditCardNumber = 32,
            CreditLimit = 34000,
            ProcessingCharge = 570
        };
     readonly   Submission Submit = new Submission()
        {
            Result = "True"
        };
     readonly   string json = "{\"Name\":\"Namit\",\"ContactNumber\":\"9690824146\",\"CreditCardNumber\":789515724415,\"ComponentType\":\"Integral\",\"ComponentName\":\"hgkughj\",\"Quantity\":1,\"IsPriorityRequest\":true}";





        [Test]
        public void TestCardDetails()
        {

            string str = "";
            var mock = new Mock<IComponentProcessingMicroservice>();
            mock.Setup(p => p.CardDetails(detail)).Returns(str);
            ComponentProcessingMicroservice2Controller process = new ComponentProcessingMicroservice2Controller(mock.Object);
            var res = process.CardDetails(detail);
            var rescheck = res as OkObjectResult;
            Assert.AreEqual(200, rescheck.StatusCode);
        }

        [Test]
        public void TestPackagingDelivery()
        {

            int num = 0;
            string Item = "Integral"; int Count = 1;
            var mock = new Mock<IComponentProcessingMicroservice>();
            mock.Setup(p => p.PackagingDelivery(Item, Count)).Returns(num);
            ComponentProcessingMicroservice2Controller process = new ComponentProcessingMicroservice2Controller(mock.Object);
            var res = process.PackagingDelivery(Item, Count);
            var rescheck = res as OkObjectResult;
            Assert.AreEqual(200, rescheck.StatusCode);
        }

        [Test]
        public void ProcessId()
        {

            int num = 0;

            var mock = new Mock<IComponentProcessingMicroservice>();
            mock.Setup(p => p.ProcessId()).Returns(num);
         ComponentProcessingMicroservice2Controller process = new ComponentProcessingMicroservice2Controller(mock.Object);
            var res = process.ProcessId();
            var rescheck = res as OkObjectResult;
            Assert.AreEqual(200, rescheck.StatusCode);
        }

        [Test]
        public void ProcessingCharge()
        {

          
            int num = 0;

            var mock = new Mock<IComponentProcessingMicroservice>();
            mock.Setup(p => p.ProcessingCharge()).Returns(num);
            ComponentProcessingMicroservice2Controller process = new ComponentProcessingMicroservice2Controller(mock.Object);
            var res = process.ProcessingCharge();
            var rescheck = res as OkObjectResult;
            Assert.AreEqual(200, rescheck.StatusCode);
        }


        [Test]
        public void TestGetUserMessage()
        {

            string str = "";


            var mock = new Mock<IComponentProcessingMicroservice>();
            mock.Setup(p => p.GetUserMessage(Submit)).Returns(str);
            ComponentProcessingMicroservice2Controller process = new ComponentProcessingMicroservice2Controller(mock.Object);
            var res = process.GetUserMessage(Submit);
            var rescheck = res as OkObjectResult;
            Assert.AreEqual(200, rescheck.StatusCode);
        }

        [Test]
        public void TestDeliveryDate()
        {

            DateTime date = DateTime.Now;


            var mock = new Mock<IComponentProcessingMicroservice>();
            mock.Setup(p => p.DeliveryDate()).Returns(date);
            ComponentProcessingMicroservice2Controller process = new ComponentProcessingMicroservice2Controller(mock.Object);
            var res = process.DeliveryDate();
            var rescheck = res as OkObjectResult;
            Assert.AreEqual(200, rescheck.StatusCode);
        }

        [Test]
        public void TestGetRequest()
        {

            string str = "";

            var mock = new Mock<IComponentProcessingMicroservice>();
            mock.Setup(p => p.GetRequest(json)).Returns(str);
            ComponentProcessingMicroservice2Controller process = new ComponentProcessingMicroservice2Controller(mock.Object);
            var res = process.GetRequest(json);
            var rescheck = res as OkObjectResult;
            Assert.AreEqual(200, rescheck.StatusCode);
        }
    }
}