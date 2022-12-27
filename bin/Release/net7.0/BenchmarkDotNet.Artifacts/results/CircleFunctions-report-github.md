``` ini

BenchmarkDotNet=v0.13.3, OS=Windows 11 (10.0.22623.1037)
11th Gen Intel Core i5-1135G7 2.40GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.101
  [Host]     : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.1 (7.0.122.56804), X64 RyuJIT AVX2


```
|                         Method |     Mean |   Error |  StdDev | Allocated |
|------------------------------- |---------:|--------:|--------:|----------:|
|                      PrintArea | 140.7 μs | 2.66 μs | 4.29 μs |     136 B |
|             PrintCircumference | 140.7 μs | 2.29 μs | 2.45 μs |     152 B |
|     PrintAreaUsingNormalMethod | 139.5 μs | 2.18 μs | 2.04 μs |     136 B |
| PrintCircumferenceNormalMethod | 133.8 μs | 2.61 μs | 2.44 μs |      72 B |
