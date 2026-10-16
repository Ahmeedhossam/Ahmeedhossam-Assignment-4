using BenchmarkDotNet.Attributes;
using System;
using System.Text;

[MemoryDiagnoser]
public class StringBenchmark

{
    [Params(100, 1000, 10000, 100000)]
    public int NumOfIterations;

    private readonly string _textToAppend = "TestwithBenchmark";

    [Benchmark]
    public string StringConcatenation()
    {
        string result = "";

        for (int i = 0; i < NumOfIterations; i++)
        {
            result += _textToAppend;
        }

        return result;
    }

    [Benchmark]
    public string StringBuilderConcatenation()
    {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < NumOfIterations; i++)
        {
            result.Append(_textToAppend);
        }

        return result.ToString();
    }
}