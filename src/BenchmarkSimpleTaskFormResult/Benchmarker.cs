using BenchmarkDotNet.Attributes;

namespace BenchmarkSimpleTaskFormResult;

[MemoryDiagnoser]
public class Benchmarker
{
    private static readonly Task<string> SimpleTask;   

    static Benchmarker()
        => SimpleTask = Task.FromResult("String content");

    [Benchmark]
    public async Task<string> ReturnTask()
        => await GetStringWithoutAsync();

    [Benchmark]
    public async Task<string> ReturnAwaitTask()
        => await GetStringWithAsync();  

    public Task<string> GetStringWithoutAsync()
        => SimpleTask;

    public async Task<string> GetStringWithAsync()
        => await SimpleTask;
}