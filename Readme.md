AirlineClient - Is a basic Windows form application - which is acting as a client application. User enters source and destination and gets the shortest route between two points using Airline Service > basic http binding.

The project supports both SOAP API and rest api. The UI works on top of SOAP while a rest API GET is exposed as well.

The rest url is http://localhost:8070/AirlineServiceRest/GetRoutesViaAPI?source=JFK&destination=YVR

AirlineManagement:
1. AirlineService - WCF service with GetRoutes method, created endpoints and exposed as nettcpid , web and basic http.
2. AirlineService host - hosted the wcf service as a console application.

*How to run:*
1. Open AirlineManagement/AirlineManagement.sln as administrator in visual studio 2015. Click on _Debug_ > _Start without debugging_. This will start the service as a console application.
2. Open AirClient.cs/AirlineClient.sln as administrator in visual studio 2015. Click on _Debug_ > _Start without debugging_. This will start the client as a windows form application. Enter source/destination and click on _Get Routes_.

I am using basicHttpBinding to read the messages between clients and server.