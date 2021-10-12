# Topic: *Structural Design Patterns*
## Author: *Ciobanu Andy-Constantin*
## Objectives :
__1. Study and understand the Structural Design Patterns;__

__2. As a continuation of the previous laboratory work, think about the functionalities that your system will need to provide to the user;__

__3. Implement some additional functionalities using structural design patterns;__

## Used Design Patterns: 
* Facade Pattern
* Proxy Pattern
* Decorator Pattern

## Used Language: 
C# .NET

## Theoretical aspects : 

Structural design patterns are those that simplify the design of large object structures by identifying relationships between them. They describe common ways of composing classes and objects so that they become repeatable as solutions.

### Facade - [Code](https://github.com/andycb479/TMPS-Labs/tree/master/Utilites/NotificationManager)
The facade pattern (also spelled façade) is a software-design pattern commonly used in object-oriented programming. Analogous to a facade in architecture, a facade is an object that serves as a front-facing interface masking more complex underlying or structural code. 
A facade can:
* improve the readability and usability of a software library by masking interaction with more complex components behind a single (and often simplified) API
* provide a context-specific interface to more generic functionality (complete with context-specific input validation)
* serve as a launching point for a broader refactor of monolithic or tightly-coupled systems in favor of more loosely-coupled code

![image](https://user-images.githubusercontent.com/30950318/136900188-9f71d7ad-f195-4bb8-8136-abba8114c4fe.png)

Here, we can see that the client is calling the Façade class which interacts with multiple subsystems making it easier for the client to interact with them.

Below is the Notification Service façade class implementation, which will be used by the client to send a notification to a specific Reservee.

![image](https://user-images.githubusercontent.com/30950318/136900567-b625b162-85ba-4766-8aa9-ae956b28c6ca.png)

Here we can see that the Notification Service class is hiding the implementation of sending a notification. Giving the client a simple method that it can use to send a notification without having to know about the internal processes and subsystem access.

Below is the implementation of the NotificationServed that is a subsystem that the Notification Service interacts with.

![image](https://user-images.githubusercontent.com/30950318/136900865-7cd0614e-d4d4-43d4-8c2d-199df479fdb2.png)

Use of Facade in the Client:

![image](https://user-images.githubusercontent.com/30950318/136900405-c1582202-fbdb-4164-9b9e-f20dae382ddd.png)

### Proxy [Code](https://github.com/andycb479/TMPS-Labs/tree/master/Domain/Models/Video)

In computer programming, the proxy pattern is a software design pattern. A proxy, in its most general form, is a class functioning as an interface to something else. The proxy could interface to anything: a network connection, a large object in memory, a file, or some other resource that is expensive or impossible to duplicate. In short, a proxy is a wrapper or agent object that is being called by the client to access the real serving object behind the scenes. Use of the proxy can simply be forwarding to the real object, or can provide additional logic. In the proxy, extra functionality can be provided, for example caching when operations on the real object are resource intensive, or checking preconditions before operations on the real object are invoked. For the client, usage of a proxy object is similar to using the real object, because both implement the same interface.
Below is the generic UML Diagram of Proxy Design Pattern

![image](https://user-images.githubusercontent.com/30950318/136901497-1176c187-4614-4d6c-8c1f-182f0986a873.png)

The classes and objects participating in this pattern include:

Proxy Class - This is the main class of the system, used by the client code to access the resources. This proxy class will contain the reference to the subject classes, in the form of the interface of the subject.
![image](https://user-images.githubusercontent.com/30950318/136902171-7bf7ff6c-f306-474d-bb39-4bdde24044e3.png)

ISubject - This is the simple interface used to define the abstract resources that we want to access using the proxy class or one can say that it contains the abstract functions that we want to share with the client code though the proxy class.

![image](https://user-images.githubusercontent.com/30950318/136902352-49999d3b-638f-440a-aef8-1bc014595e6d.png)

The pattern implementation matches the Virtual Proxy type. This type of proxy is created to manage creation of an instance of resources that are very expensive in nature, in other words that consume too much memory or take too much time for accessing the main resource or any other kind of heavy operation.

Proxy Subject - This is the proxy implementation of the preceding interface (ISpotVideo).

![image](https://user-images.githubusercontent.com/30950318/136902726-a1e39180-1f8d-4f6b-b059-e6f8e0a978e0.png)

Real Subject - This is the real implementatio of the the interface (ISpotVideo), where is performed the acces to the database that is costly.

![image](https://user-images.githubusercontent.com/30950318/136902856-58d07ecf-b16b-4d91-b310-f62a00c6e816.png)

Use of Proxy pattern

![image](https://user-images.githubusercontent.com/30950318/136903527-e619c521-dd53-418f-a28f-c494a8490fae.png)




### Decorator [Code](https://github.com/andycb479/TMPS-Labs/tree/master/Core/VideoStream)

In object-oriented programming, the decorator pattern is a design pattern that allows behavior to be added to an individual object, dynamically, without affecting the behavior of other objects from the same class. The decorator pattern is often useful for adhering to the Single Responsibility Principle, as it allows functionality to be divided between classes with unique areas of concern. Decorator use can be more efficient than subclassing, because an object's behavior can be augmented without defining an entirely new object.

Below is the UML Diagram of the Decorator Pattern

![image](https://user-images.githubusercontent.com/30950318/136903823-7d77b95a-57f2-40c2-b86e-4bdac2357ce3.png)

Component - It defines the interface of the actual object that needs functionality to be added dynamically to the ConcreteComponents.

![image](https://user-images.githubusercontent.com/30950318/136904177-16ba4b4d-b991-4dae-9a51-2bc1b8d9e5f0.png)

ConcreteComponent - The actual object in which the functionalities could be added dynamically.

![image](https://user-images.githubusercontent.com/30950318/136904227-0b3dac83-2e3e-424a-a4b4-5519dd4456b0.png)

ConcreteDecorator - All the functionalities that can be added to the ConcreteComponent. Each needed functionality will be one ConcreteDecorator class.

* EncodedVideoStream - ConcreteDecorator 1

![image](https://user-images.githubusercontent.com/30950318/136904457-7fc32a57-6693-4457-ba21-9f911d3c51bf.png)

* CompressedVideoStream - ConcreteDecorator 2

![image](https://user-images.githubusercontent.com/30950318/136904513-64433a98-9f8e-4f18-a88a-2760fba6efed.png)

Advantages of Decorator Pattern:
* Adds functionality to existing objects dynamically
* Alternative to sub classing
* Flexible design
* Supports Open Closed Principle

## Conclusions
In conclusion, it can be said that *Structural Design Patterns* explain how to assemble objects and classes into larger structures while keeping these structures flexible and efficient, also this group of Design Patterns ease the design by identifying a simple way to realize relationships between entities. This pattern category discusses the composition between the modules or components which allow one to develop or build larger systems. Structural patterns define how each component or entity should be structured so as to have very flexible interconnecting modules which can work together in a larger system. The use of Structural Patterns can lead to overall better performance of the developed system by adding abstractions and methods of decoupling.





