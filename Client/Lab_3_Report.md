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

The use of the IdGenerator in the ReserveeFactory

![image](https://user-images.githubusercontent.com/30950318/143626751-333290ae-feb4-46fd-a911-5b547471dca1.png)

The use of ReserveeFactory in Reservee DB Seed

![image](https://user-images.githubusercontent.com/30950318/143626834-dd96e20d-1c03-40d0-8c25-72439fcd27db.png)

The injection of the different algorithms for generating the Id.

![image](https://user-images.githubusercontent.com/30950318/143626880-4e45e6cf-d5ae-4d05-b80e-18fab2130b2b.png)

### Template Method Pattern [Code](https://github.com/andycb479/TMPS-Labs/tree/master/Utilites/IdGenerator)

In object-oriented programming, the template method is one of the behavioral design patterns identified by Gamma et al.in the book Design Patterns. The template method is a method in a superclass, usually an abstract superclass, and defines the skeleton of an operation in terms of a number of high-level steps. These steps are themselves implemented by additional helper methods in the same class as the template method.

The helper methods may be either abstract methods, in which case subclasses are required to provide concrete implementations, or hook methods, which have empty bodies in the superclass. Subclasses can (but are not required to) customize the operation by overriding the hook methods. The intent of the template method is to define the overall structure of the operation, while allowing subclasses to refine, or redefine, certain steps.

Below is the abstract class RandomIdGenerator that implements the interface IdGenerator and also provides an abstract method that will represent the method to be implemented by the classes that will inherit the RandomIdGenerator abstract class.

![image](https://user-images.githubusercontent.com/30950318/143627071-be2314d6-613b-42c1-9be4-fd353be5d052.png)

LaggedFibRandomIdGenerator - the implementation of the abstract class that establishes the logic of the abstract method RandomNumber.

![image](https://user-images.githubusercontent.com/30950318/143627209-8a197913-9edc-46bb-8115-408aa5a72465.png)

LaggedFibRandom - class that implements the Lagged Fibonacci generator. [Code](https://github.com/andycb479/TMPS-Labs/blob/master/Utilites/IdGenerator/LaggedFibRandom.cs)

![image](https://user-images.githubusercontent.com/30950318/143627356-1adc3c16-255a-47f7-8076-e6baad9d676d.png)

LinearCongruentialRandomIdGenerator - the implementation of the abstract class that establishes the logic of the abstract method RandomNumber.

![image](https://user-images.githubusercontent.com/30950318/143627507-8c156c4e-5a27-4a42-9cd7-c43edb26db87.png)

LinearCongruentialRandom - class that implements the Linear congruential generator. [Code](https://github.com/andycb479/TMPSLabs/blob/master/Utilites/IdGenerator/LinearCongruentialRandom.cs)

![image](https://user-images.githubusercontent.com/30950318/143627591-4fa6244e-c5dc-49b1-a40e-11ce2616cbf9.png)

Below is the implementation of the Template Method Pattern.

![image](https://user-images.githubusercontent.com/30950318/143627627-48111ed7-15db-4d55-a881-ab4b9225ad50.png)

## Conclusions

In conclusion, it can be said that *Behavioral Design Patterns* solve some important problems present in software development, namely in the architecure design process. Behavioral design patterns are concerned with the interaction and responsibility of objects. Unlike the Creational and Structural patterns, which deal with the instantiation process and the blueprint of objects and classes, the central idea here is to concentrate on the way objects are interconnected. In a word, we can say this: If Creational is about instantiation, and Structural is the blueprint, then Behavioral is the pattern of the relationship among objects.










