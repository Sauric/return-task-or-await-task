var taskFactory = new TestStackTrace.TaskFactory();

try
{
    await taskFactory.GetStringWithAsync();
}
catch (Exception e)
{
    System.Console.WriteLine("Error with async/await");
    System.Console.WriteLine(e.StackTrace);
}

try
{
    await taskFactory.GetStringWithoutAsync();
}
catch (Exception e)
{
    System.Console.WriteLine("\nError without async/await");
    System.Console.WriteLine(e.StackTrace);
}
