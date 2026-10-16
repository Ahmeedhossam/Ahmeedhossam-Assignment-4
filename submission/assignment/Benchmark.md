# Benchmark Summary Report

## 1. Environment Specifications
This benchmark was executed on the following environment to ensure isolated and accurate results:
* **OS:** Windows 11 (10.0.26300.9457)[cite: 4]
* **CPU:** 11th Gen Intel Core i7-11370H 3.30GHz[cite: 4]
* **Cores:** 1 CPU, 8 logical and 4 physical cores[cite: 4]
* **.NET SDK:** 10.0.401[cite: 4]
* **Total Execution Time:** 00:36:01 (2161.76 sec)[cite: 5]

## 2. Benchmark Results

| Method | NumOfIterations | Mean | Allocated |
| :--- | :--- | :--- | :--- |
| StringConcatenation | 100 | 7,040.2 ns[cite: 4] | 170.06 KB[cite: 4] |
| StringBuilderConcatenation | 100 | 703.4 ns[cite: 4] | 7.91 KB[cite: 4] |
| StringConcatenation | 1000 | 617,885.6 ns[cite: 4] | 16,642.52 KB[cite: 4] |
| StringBuilderConcatenation | 1000 | 6,559.8 ns[cite: 4] | 81.32 KB[cite: 4] |
| StringConcatenation | 10000 | 168,957,889.7 ns[cite: 4] | 1,660,726.59 KB[cite: 4] |
| StringBuilderConcatenation | 10000 | 194,473.8 ns[cite: 4] | 678.39 KB[cite: 4] |
| StringConcatenation | 100000 | 33,501,675,148.8 ns[cite: 4] | 166,027,195.41 KB[cite: 4] |
| StringBuilderConcatenation | 100000 | 2,105,513.9 ns[cite: 4] | 6,664.77 KB[cite: 4] |

## 3. Analysis & Answers

**Q1: What is the purpose of benchmarking?**
The purpose of benchmarking is to accurately measure code performance in an isolated environment, free from external operating system interference. It calculates the exact execution time (speed) and memory allocation (RAM usage), helping software engineers write optimized and resource-efficient code.

**Q2: At what iteration count does the performance difference become noticeable?**
The performance difference becomes highly noticeable starting at 1,000 iterations[cite: 4]. At this point, standard string concatenation took 617,885.6 ns, while StringBuilder took only 6,559.8 ns[cite: 4]. As the iterations scale to 100,000, standard string concatenation becomes disastrously slow[cite: 4].

**Q3: How much memory is allocated by `string` vs `StringBuilder` at 10,000 iterations?**
At 10,000 iterations:
* `StringConcatenation` allocated a massive 1,660,726.59 KB of memory[cite: 4].
* `StringBuilderConcatenation` allocated only 678.39 KB of memory[cite: 4].

**Q4: Does `StringBuilder` always perform better?**
No, not always. While `StringBuilder` dominates in large loops and heavy string manipulations, it is actually slower and consumes more memory for very simple concatenations (like joining a first and last name). This is because instantiating a new `StringBuilder` object introduces its own memory allocation and processing overhead. Therefore, standard `string` concatenation is preferred for simple, one-off operations, while `StringBuilder` is strictly used for iterative loops and dynamic text generation.