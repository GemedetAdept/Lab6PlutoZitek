# CS 1400 — Lab 6: Memory — Lab Report
---
Tasks: 
[ ] In Program.cs write a function named StackNoParams
	- The function makes 5 Value Type Variables.

[ ] Write a function name StackWithParams
	- The Function makes 3 Value type parameters

[ ] Write a function named StackWithHeap
	- The function takes 3 Value type of parameters
	- The function takes1 reference type parameter
	- The function makes 2 Value type variables
	- The function makes 1 reference type variable

[ ] Write a function called StackOver
	- The function creates a stack overflow error.

[ ] Write a Driver program to call each Function
[ ] The lab report needs to show the memory graph for each function.
[ ] the lab report needs to explain what is happening in the memory graph for each function
[ ] The lab report needs to have a stack diagram for the driver program
 
## 000: Baseline Memory Usage
![Baseline memory graph.](/labReportScreenshots/000_Memory-Baseline.png "Baseline Memory Graph")
| In use | Available | Total | Percentage Used |
|:------:|:---------:|:-----:|:----------:|
| 10.7 GB | 20.9 GB   | ~31.6 GB| ~33.86% |

## 001: StackNoParams
#### Memory Usage Before
![Before StackNoParams](/labReportScreenshots/001-01_Before.png)
#### Memory Usage After
![After StackNoParams](/labReportScreenshots/001-02_After.png)
#### Exact Memory Usage
![Exact memory usage](/labReportScreenshots/001-03_Exact.png)

> The Task Manager's **Perfomance** > **Memory** tab shows an "In use" increase of 0.1 GB, but this is a generalization. The graph itself bumped up by exactly one (1) pixel. The details for the program shows that the program takes **3.2 MB** of memory.

#### Stack Diagram