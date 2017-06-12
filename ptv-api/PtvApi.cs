using ptv_api.Clients;

namespace ptv_api
{
    public class PtvApi
    {
        
        private string DeveloperId { get; set; }
        private string DeveloperKey { get; set; }

        private DeparturesClient _departuresClient;
        public DeparturesClient DeparturesClient
        {
            get => _departuresClient ?? (_departuresClient = new DeparturesClient(DeveloperId, DeveloperKey));
            set => _departuresClient = value;
        }

        private DirectionsClient _directionsClient;
        public DirectionsClient DirectionsClient
        {
            get => _directionsClient ?? (_directionsClient = new DirectionsClient(DeveloperId, DeveloperKey));
            set => _directionsClient = value;
        }

        private DisruptionsClient _disruptionsClient;
        public DisruptionsClient DisruptionsClient
        {
            get => _disruptionsClient ?? (_disruptionsClient = new DisruptionsClient(DeveloperId, DeveloperKey));
            set => _disruptionsClient = value;
        }

        private PatternsClient _patternsClient;
        public PatternsClient PatternsClient
        {
            get => _patternsClient ?? (_patternsClient = new PatternsClient(DeveloperId, DeveloperKey));
            set => _patternsClient = value;
        }

        private RoutesClient _routesClient;
        public RoutesClient RoutesClient
        {
            get => _routesClient ?? (_routesClient = new RoutesClient(DeveloperId, DeveloperKey));
            set => _routesClient = value;
        }

        private RouteTypesClient _routeTypesClient;
        public RouteTypesClient RouteTypesClient
        {
            get => _routeTypesClient ?? (_routeTypesClient = new RouteTypesClient(DeveloperId, DeveloperKey));
            set => _routeTypesClient = value;
        }

        private RunsClient _runsClient;
        public RunsClient RunsClient
        {
            get => _runsClient ?? (_runsClient = new RunsClient(DeveloperId, DeveloperKey));
            set => _runsClient = value;
        }

        private SearchClient _searchClient;
        public SearchClient SearchClient
        {
            get => _searchClient ?? (SearchClient = new SearchClient(DeveloperId, DeveloperKey));
            set => _searchClient = value;
        }

        private StopsClient _stopsClient;
        public StopsClient StopsClient
        {
            get => _stopsClient ?? (_stopsClient = new StopsClient(DeveloperId, DeveloperKey));
            set => _stopsClient = value;
        }


        public PtvApi(string developerId, string developerKey)
        {
            DeveloperId = developerId;
            DeveloperKey = developerKey;
        }

        
       
    }
}