``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22581
AMD Ryzen 7 4800H with Radeon Graphics, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.100
  [Host]     : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT
  DefaultJob : .NET 6.0.0 (6.0.21.52210), X64 RyuJIT


```
|          Method |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
|---------------- |---------:|---------:|---------:|-------:|----------:|
|      ReturnTask | 17.38 ns | 0.413 ns | 0.795 ns | 0.0344 |      72 B |
| ReturnAwaitTask | 37.19 ns | 0.800 ns | 0.982 ns | 0.0688 |     144 B |
