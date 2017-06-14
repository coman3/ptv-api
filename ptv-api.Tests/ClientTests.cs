using System.Security.Cryptography;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ptv_api.Clients;
using ptv_api.Models;

namespace ptv_api.Tests
{
    [TestClass]
    [TestCategory("DepaturesClient")]
    public class DepaturesClientTests
    {
        [TestMethod]
        public void GetForStop()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).DeparturesClient.GetForStop(RouteTypes.Train, 3, null, null, null, null, null, null, null);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetForStopAndRoute()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).DeparturesClient.GetForStopAndRoute(RouteTypes.Train, 3, "3", null, null, null, null, null, null);
            Assert.IsNotNull(result);
        }
    }

    [TestClass]
    [TestCategory("DirectionsClient")]
    public class DirectionsClientTests
    {
        [TestMethod]
        public void ForDirection()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).DirectionsClient.ForDirection(1);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ForDirectionAndType()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).DirectionsClient.ForDirectionAndType(1, RouteTypes.Train);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ForRoute()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).DirectionsClient.ForRoute(3);
            Assert.IsNotNull(result);
        }
    }

    [TestClass]
    [TestCategory("DisruptionsClient")]
    public class DisruptionsClientTests
    {
        [TestMethod]
        public void GetAllDisruptions()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).DisruptionsClient.GetAllDisruptions(new []{RouteTypes.Train}, null);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetDisruptionById()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).DisruptionsClient.GetDisruptionById(2);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void GetDisruptionsByRoute()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).DisruptionsClient.GetDisruptionsByRoute(3, null);
            Assert.IsNotNull(result);
        }
    }

    [TestClass]
    [TestCategory("PatternsClient")]
    public class PatternsClientTests
    {
        [TestMethod]
        public void GetPatternByRun()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).PatternsClient.GetPatternByRun(4, RouteTypes.Train, null, null);
            Assert.IsNotNull(result);
        }
    }

    [TestClass]
    [TestCategory("RoutesClient")]
    public class RoutesClientTests
    {
        [TestMethod]
        public void OneOrMoreRoutes()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).RoutesClient.OneOrMoreRoutes(new []{RouteTypes.Train}, "Flinders");
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void RouteFromId()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).RoutesClient.RouteFromId(3);
            Assert.IsNotNull(result);
        }
    }

    [TestClass]
    [TestCategory("RouteTypesClient")]
    public class RouteTypesClientTests
    {
        [TestMethod]
        public void GetRouteTypes()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).RouteTypesClient.GetRouteTypes();
            Assert.IsNotNull(result);
        }
    }

    [TestClass]
    [TestCategory("RunsClient")]
    public class RunsClientTests
    {
        [TestMethod]
        public void ForRoute()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).RunsClient.ForRoute(3);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ForRun()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).RunsClient.ForRun(3);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ForRunAndRouteType()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).RunsClient.ForRunAndRouteType(3, RouteTypes.Train);
            Assert.IsNotNull(result);
        }
    }

    [TestClass]
    [TestCategory("SearchClient")]
    public class SearchClientTests
    {
        [TestMethod]
        public void Search()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).SearchClient.Search("Flinder", new []{RouteTypes.Train}, null, null, 1000, null, null);
            Assert.IsNotNull(result);
        }
    }

    [TestClass]
    [TestCategory("StopsClient")]
    public class StopsClientTests
    {
        [TestMethod]
        public void StopDetails()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).StopsClient.StopDetails(1071, RouteTypes.Train, null, null, null);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void StopsByGeolocation()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).StopsClient.StopsByGeolocation(-37.8182711, 144.9648731, new []{RouteTypes.Train}, null, null);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void StopsForRoute()
        {
            var result = new PtvApi(Data.DeveloperId, Data.DeveloperKey).StopsClient.StopsForRoute(3, RouteTypes.Train);
            Assert.IsNotNull(result);
        }
    }
}