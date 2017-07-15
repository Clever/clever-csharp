/* 
 * Clever API
 *
 * The Clever API
 *
 * OpenAPI spec version: 1.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing EventsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EventsApiTests
    {
        private EventsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EventsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EventsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EventsApi
            //Assert.IsInstanceOfType(typeof(EventsApi), instance, "instance is a EventsApi");
        }

        
        /// <summary>
        /// Test GetEvent
        /// </summary>
        [Test]
        public void GetEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //var response = instance.GetEvent(id);
            //Assert.IsInstanceOf<EventResponse> (response, "response is EventResponse");
        }
        
        /// <summary>
        /// Test GetEvents
        /// </summary>
        [Test]
        public void GetEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //string startingAfter = null;
            //string endingBefore = null;
            //var response = instance.GetEvents(limit, startingAfter, endingBefore);
            //Assert.IsInstanceOf<EventsResponse> (response, "response is EventsResponse");
        }
        
        /// <summary>
        /// Test GetEventsForSchool
        /// </summary>
        [Test]
        public void GetEventsForSchoolTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? limit = null;
            //string startingAfter = null;
            //string endingBefore = null;
            //var response = instance.GetEventsForSchool(id, limit, startingAfter, endingBefore);
            //Assert.IsInstanceOf<EventsResponse> (response, "response is EventsResponse");
        }
        
        /// <summary>
        /// Test GetEventsForSchoolAdmin
        /// </summary>
        [Test]
        public void GetEventsForSchoolAdminTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? limit = null;
            //string startingAfter = null;
            //string endingBefore = null;
            //var response = instance.GetEventsForSchoolAdmin(id, limit, startingAfter, endingBefore);
            //Assert.IsInstanceOf<EventsResponse> (response, "response is EventsResponse");
        }
        
        /// <summary>
        /// Test GetEventsForSection
        /// </summary>
        [Test]
        public void GetEventsForSectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? limit = null;
            //string startingAfter = null;
            //string endingBefore = null;
            //var response = instance.GetEventsForSection(id, limit, startingAfter, endingBefore);
            //Assert.IsInstanceOf<EventsResponse> (response, "response is EventsResponse");
        }
        
        /// <summary>
        /// Test GetEventsForStudent
        /// </summary>
        [Test]
        public void GetEventsForStudentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? limit = null;
            //string startingAfter = null;
            //string endingBefore = null;
            //var response = instance.GetEventsForStudent(id, limit, startingAfter, endingBefore);
            //Assert.IsInstanceOf<EventsResponse> (response, "response is EventsResponse");
        }
        
        /// <summary>
        /// Test GetEventsForTeacher
        /// </summary>
        [Test]
        public void GetEventsForTeacherTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string id = null;
            //int? limit = null;
            //string startingAfter = null;
            //string endingBefore = null;
            //var response = instance.GetEventsForTeacher(id, limit, startingAfter, endingBefore);
            //Assert.IsInstanceOf<EventsResponse> (response, "response is EventsResponse");
        }
        
    }

}
