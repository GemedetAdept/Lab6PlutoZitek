# CS 1400 — Lab 6: Memory — Lab Report
---
 
## 000: Baseline Memory Usage
![Baseline memory graph.](/labReportScreenshots/000_Memory-Baseline.png "Baseline Memory Graph")
| In use | Available | Total | Percentage Used |
|:------:|:---------:|:-----:|:----------:|
| 11.4 GB | 20.1 GB   | ~31.5 GB| ~36.19% |

## 001: StackNoParams
#### Memory Usage Before
![Before StackNoParams](/labReportScreenshots/001-01_Before.png)
#### Memory Usage After
![After StackNoParams](/labReportScreenshots/001-02_After.png)
#### Exact Memory Usage
![Exact memory usage](/labReportScreenshots/001-03_Exact.png)

> The Task Manager's **Perfomance** > **Memory** tab shows an "In use" increase of 0.1 GB, but this is a generalization. The graph itself bumped up by exactly one (1) pixel. The details for the program shows that the program takes **3.2 MB** of memory.

#### Stack Diagram

```
+---------------+------------+
| StackNoParams |            |
+---------------+            |
| createdInteger
| createdFloat
| createdDouble
| createdDecimal
| createdChar
| long001 | 9_223_372_036_854_775_807 |
| long002 | 9_223_372_036_854_775_807 |
| long003 | 9_223_372_036_854_775_807 |
| long004 | 9_223_372_036_854_775_807 |
| long005 | 9_223_372_036_854_775_807 |
| long006 | 9_223_372_036_854_775_807 |
| long007 | 9_223_372_036_854_775_807 |
| long008 | 9_223_372_036_854_775_807 |
| long009 | 9_223_372_036_854_775_807 |
| long010 | 9_223_372_036_854_775_807 |
| long011 | 9_223_372_036_854_775_807 |
| long012 | 9_223_372_036_854_775_807 |
| long013 | 9_223_372_036_854_775_807 |
| long014 | 9_223_372_036_854_775_807 |
| long015 | 9_223_372_036_854_775_807 |
| long016 | 9_223_372_036_854_775_807 |
| long017 | 9_223_372_036_854_775_807 |
| long018 | 9_223_372_036_854_775_807 |
| long019 | 9_223_372_036_854_775_807 |
| long020 | 9_223_372_036_854_775_807 |
| long021 | 9_223_372_036_854_775_807 |
| long022 | 9_223_372_036_854_775_807 |
| long023 | 9_223_372_036_854_775_807 |
| long024 | 9_223_372_036_854_775_807 |
| long025 | 9_223_372_036_854_775_807 |
| long026 | 9_223_372_036_854_775_807 |
| long027 | 9_223_372_036_854_775_807 |
| long028 | 9_223_372_036_854_775_807 |
| long029 | 9_223_372_036_854_775_807 |
| long030 | 9_223_372_036_854_775_807 |
| long031 | 9_223_372_036_854_775_807 |
| long032 | 9_223_372_036_854_775_807 |
| long033 | 9_223_372_036_854_775_807 |
| long034 | 9_223_372_036_854_775_807 |
| long035 | 9_223_372_036_854_775_807 |
| long036 | 9_223_372_036_854_775_807 |
| long037 | 9_223_372_036_854_775_807 |
| long038 | 9_223_372_036_854_775_807 |
| long039 | 9_223_372_036_854_775_807 |
| long040 | 9_223_372_036_854_775_807 |
```