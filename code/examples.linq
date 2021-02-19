<Query Kind="Statements" />

/*
var movies = new List<string>(); 

movies.Add("Crank");
movies.Add("The Expendables");
movies.Add("Furious 7");
movies.Add("Snatch");
movies.Add("The Meg");

*/

var movies = new string[1];
movies[0] = "Crank"; 

var expandedMovies = new string[2];
movies.CopyTo(expandedMovies, 0);
expandedMovies[1] = "The Expendables";

var expandedExpandedMovies = new string[4];
expandedMovies.CopyTo(expandedExpandedMovies, 0);
expandedExpandedMovies[2] = "Furious 7";
expandedExpandedMovies[3] = "Snatch";


Console.WriteLine(expandedExpandedMovies);
