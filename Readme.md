AirlineClient - Is a basic Windows form application - which is acting as a client application. User enters source and destination and gets the shortest route between two points using Airline Service > basic http binding.

AirlineManagement:
1. AirlineService - WCF service with GetRoutes method, created endpoints and exposed as nettcpid , web and basic http.
2. AirlineService host - hosted the wcf service as a console application.

