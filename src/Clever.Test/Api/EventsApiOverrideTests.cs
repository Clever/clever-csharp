using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Clever.Client;
using Clever.Api;
using Clever.Model;

namespace Clever.Test
{
    /// <summary>
    ///  Class for testing EventsApi override
    /// </summary>
    [TestFixture]
    public class EventsApiOverrideTests
    {
        private EventsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // Token for Demo App - Sandbox Events
            Configuration.Default.AccessToken = "DEMO_EVENTS_TOKEN";
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
        /// Test GetEvents loads correct classes
        /// </summary>
        [Test]
        public void GetEventsClassesTest()
        {
            int? limit = 1;
            string startingAfter = null;
            string endingBefore = null;
            var response = instance.GetEvents(limit, startingAfter, endingBefore);
            Assert.IsInstanceOf<EventsResponse> (response, "response expected to be EventsResponse");
            foreach (var eventObj in response.Data) {
              Assert.IsInstanceOf<EventResponse> (eventObj, "response.Data[i] object expected to be EventResponse");
              dynamic eventData = eventObj.Data;
              string eventDataType = eventData.GetType().ToString();
              bool isEventClass = eventDataType.Contains("Created") || eventDataType.Contains("Updated") || eventDataType.Contains("Deleted");
              Assert.IsTrue(isEventClass, "response.Data expected to be event class but is "+eventDataType);
            }
        }

    }

}
