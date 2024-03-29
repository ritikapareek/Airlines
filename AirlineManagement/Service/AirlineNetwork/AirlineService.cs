﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.ServiceModel.Activation;
using Service.Common;
using Service.Models;

namespace Service.AirlineNetwork
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class AirlineServiceRest :  IAirlineServiceRest
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent?.FullName;
        private readonly string _mAirlinePath = string.Concat(projectDirectory ,  @"\Data\test\Airline.csv"); 
        private  readonly string _mAirPortsPath = string.Concat(projectDirectory , @"\Data\test\Airports.csv");
        private  readonly string _mRoutesPath = string.Concat(projectDirectory ,@"\Data\test\Routes.csv");
        private static List<Airline> airlines;
        private static List<Airports> airports;
        private static List<Routes> routes;
        public AirlineServiceRest()
        {
            airlines = AirlineHelper.ReadCSVAirlineFile(_mAirlinePath);
            airports = AirlineHelper.ReadCSVAirportsFile(_mAirPortsPath);
            routes = AirlineHelper.ReadCSVRoutesFile(_mRoutesPath);
        }
        
        public ShortestRoute GetShortestRouteViaAPI(Graph graph, Node source, Node destination)
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
            ShortestRoute sr = new ShortestRoute {ShortestRoutes = new List<string>()};

            for (var a = destination; prev.ContainsKey(a); a = prev[a])
            {
                sr.ShortestRoutes.Insert(0, prev[a].AirportCode);
            }
            if (sr.ShortestRoutes.Count == 0)
            {
                sr.ShortestRoutes.Add("No route");

            }
            else
            {
                sr.ShortestRoutes.Add(destination.AirportCode);
            }
            
            return sr;
        }

        public ShortestRoute GetRoutesViaAPI(string source, string destination)
        {
            ShortestRoute sr = new ShortestRoute {ShortestRoutes = new List<string>()};
            if (airports.All(a => a.IATA3 != source))
            {
                sr.ShortestRoutes.Add("Invalid source");
                return sr;
            }
            if (airports.All(a => a.IATA3 != destination))
            {
                sr.ShortestRoutes.Add("Invalid destination");
                return sr;
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
          
            return GetShortestRouteViaAPI(graph, start, end);
        }

      
    }

    public class AirlineService :  IAirlineService
    {
        private static readonly string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent?.FullName;
        private readonly string _mAirlinePath = string.Concat(projectDirectory ,  @"\Data\test\Airline.csv"); 
        private  readonly string _mAirPortsPath = string.Concat(projectDirectory , @"\Data\test\Airports.csv");
        private  readonly string _mRoutesPath = string.Concat(projectDirectory ,@"\Data\test\Routes.csv");
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

