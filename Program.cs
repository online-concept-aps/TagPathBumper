// See https://aka.ms/new-console-template for more information
var myargs = Environment.GetCommandLineArgs();

Console.WriteLine("Hello, World! Length" + myargs.Length);

Console.WriteLine($"::set-output name=new-tag::{"customer-1.0.0"}"); 
