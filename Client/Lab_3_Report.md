# Topic: *Behavioral Design Patterns*
## Author: *Ciobanu Andy-Constantin*
## Objectives :
__1. Study and understand the Behavioral Design Patterns;__

__2. As a continuation of the previous laboratory work, think about the functionalities that your system will need to provide to the user;__

__3. Implement some additional functionalities using behavioral design patterns;__

## Used Design Patterns: 
* Strategy Pattern
* Template Method Pattern

## Used Language: 
C# .NET

## Theoretical aspects : 

In software engineering, behavioral design patterns are design patterns that identify common communication patterns between objects and realize these patterns. By doing so, these patterns increase flexibility in carrying out this communication.

### Strategy [Code](https://github.com/andycb479/TMPS-Labs/tree/master/Utilites/IdGenerator)

In computer programming, the strategy pattern (also known as the policy pattern) is a behavioral software design pattern that enables selecting an algorithm at runtime. Instead of implementing a single algorithm directly, code receives run-time instructions as to which in a family of algorithms to use.

Strategy lets the algorithm vary independently from clients that use it. Strategy is one of the patterns included in the influential book Design Patterns by Gamma et al. that popularized the concept of using design patterns to describe how to design flexible and reusable object-oriented software. Deferring the decision about which algorithm to use until runtime allows the calling code to be more flexible and reusable.

The Laboratory Work 3 implements Strategy Pattern for generating the Id of the Reservees of the systems. The Id's are generated using different algorithms that can be injected in the constructor of the Factory from the Factory Pattern.

Below is the main interface of the IdGenerator, with the signature of the GenerateId that will be used by the implementation to generate the Id.

![image](https://user-images.githubusercontent.com/30950318/143626028-b758f8d6-43c4-42ce-81f9-ef39fa672c31.png)

GuidGenerator - is a implementation of the IdGenerator that generates a Guid that is used as an Id by the Factory.

![image](https://user-images.githubusercontent.com/30950318/143626138-438d9cff-3a26-403f-b007-50c6e01c9594.png)

EncodedCodeIdGenerator - is a implementation of the IdGenerator that generated an Id by encoding the First and Last Name of a Reservee.

![image](https://user-images.githubusercontent.com/30950318/143626254-d627ec67-f430-4ac0-8b11-295430d5c494.png)

## Conclusions
In conclusion, it can be said that *Behavioral Design Patterns* solve some important problems present in software development, namely in the architecure design process.










