# CommonFactors
Common Factor is a simple Windows form in C# that can be used to calculate the Greatest Common Factors (GCF) and Least Common Factors (LCF) of any two integers. The program uses a recursive algorithm to calculate the output. The math behind the GCF algorithm is simple:
```
Greatest Common Factor:
given a and b are two numbers
if a = 0 then b is the GCF
if b = 0 then a is the GCF
else
find the GCF of b and remainder of a/b
```
For the LCF the math and algorithm is even simplier:
```
Least Common Factor:
given a and b are two numbers
a * b / GCF of a and b
```
Example of input

![Input:](https://joshuaestrada329.github.io/CommonFactors/FactorsInput.PNG)
![Output:](https://joshuaestrada329.github.io/CommonFactors/FactorsOutput.PNG)
