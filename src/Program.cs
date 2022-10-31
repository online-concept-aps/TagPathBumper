// See https://aka.ms/new-console-template for more information
var myargs = Environment.GetCommandLineArgs();
var version = "customer-1.0.0";
Console.WriteLine("Hello, World! Length" + myargs.Length);

Console.Out.WriteLine($"::set-output name=new-tag::{version}"); 
