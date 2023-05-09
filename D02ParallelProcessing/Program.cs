// See https://aka.ms/new-console-template for more information
using D02ParallelProcessing;
using System.Diagnostics;

Console.WriteLine("Hello, World!");

//parallel processing and asynchronous processing

ParallelTesting pt= new ParallelTesting();
Stopwatch stopwatch= new Stopwatch();   

stopwatch.Start();
pt.Task1();
pt.Task2();
stopwatch.Stop();

Console.WriteLine($"Sequential executon took " + $" {stopwatch.ElapsedMilliseconds} ms");

stopwatch.Restart();


Parallel.Invoke(()=> pt.Task1(), ()=>pt.Task2());
stopwatch.Stop();
Console.WriteLine("Sequential executon took " + $" {stopwatch.ElapsedMilliseconds} ms");
int numcores = Environment.ProcessorCount;
Console.WriteLine($"You have " + $" {numcores} cores");

