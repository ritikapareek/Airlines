using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Service.Common;
using Service.Models;

namespace Service.AirlineNetwork
{
    public class AirlineService : IAirlineService
    {
        private  readonly string _mAirlinePath = Path.Combine(Directory.GetCurrentDirectory(),@"Data\test\airline.csv");
        private  readonly string _mAirPortsPath = Path.Combine(Directory.GetCurrentDirectory(),@"Data\test\airports.csv");
        private  readonly string _mRoutesPath = Path.Combine(Directory.GetCurrentDirectory(),@"Data\test\routes.csv");
        private static List<Airline> airlines;
        private static List<Airports> airports;
        private static List<Routes> routes;
        public AirlineService()
        {
            airlines = AirlineHelper.ReadCSVAirlineFile(_mAirlinePath);
            airports = AirlineHelper.ReadCSVAirportsFile(_mAirPortsPath);
            routes = AirlineHelper.ReadCSVRoutesFile(_mRoutesPath);
        }
        public List<string> GetRoutes(string source, string destination)
        {
            
            var list = new List<string>();
            if (airports.All(a => a.IATA3 != source))
            {
                list.Add("Invalid source");
                return list;
            }
            if (airports.All(a => a.IATA3 != destination))
            {
                list.Add("Invalid destination");
                return list;
            }
            List<Node> vertices = new List<Node>();

            foreach (var airport in airports)
            {
                var node = new Node(airport.IATA3);
                vertices.Add(node);
            }

            List<Tuple<Node, Node>> edges = new List<Tuple<Node, Node>>();
            foreach (var route in routes)
            {
               
                var nodeFrom = new Node(route.Origin);
                var nodeTo = new Node(route.Destination);
                var edge = Tuple.Create(nodeTo, nodeFrom);
                edges.Add(edge);
                
            }


            var graph = new Graph(vertices, edges);
            Node start = new Node(source);
            Node end = new Node(destination);
          
            return GetShortestRoute(graph, start, end);
            
        }

        public List<string> GetShortestRoute(Graph graph, Node source, Node destination)
        {
            
	
	            //BFS to find shortest path
	            Queue<Node> queue = new Queue<Node>();
	            Dictionary<Node, bool> visited = new Dictionary<Node, bool>(new NodeEqualityComparator());
	            Dictionary<Node, Node> prev = new Dictionary<Node, Node>(new NodeEqualityComparator());
	            queue.Enqueue(source);
	            visited[source] = true;
	            while (queue.Count > 0)
	            {
	                Node curAirport = queue.Dequeue();
	                if (graph.AdjacencyList.ContainsKey(curAirport))
	                {
	                    foreach (var neighbor in graph.AdjacencyList[curAirport])
	                    {
	                        if (!visited.ContainsKey(neighbor) || !visited[neighbor])
	                        {
	                            queue.Enqueue(neighbor);
	                            visited[neighbor] = true;
	                            prev[neighbor] = curAirport;
	                            if (neighbor == destination)
	                            {
	                                break;
	                            }
	                        }
	                    }
	                }
	            }
	
	            //construct shortest path
	            List<string> rm = new List<string>();
                
	            
	            for (var a = destination; prev.ContainsKey(a); a = prev[a])
	            {
	                rm.Insert(0, prev[a].AirportCode);
	            }
	            if (rm.Count == 0)
	            {
	                rm.Add("No route");

	            }
	            else
	            {
                    rm.Add(destination.AirportCode);
	            }
            
	            return rm;
	        }
    }

    }

