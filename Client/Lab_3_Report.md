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

### Proxy [Code](https://github.com/andycb479/TMPS-Labs/tree/master/Lab_1/Factory)

### Prototype
Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.

![image](https://user-images.githubusercontent.com/30950318/133803581-3a806f48-b02b-4f53-bd6a-76c5da0ddf72.png)

- Prototype  (TablePrototype)
declares an interface for cloning itself

![image](https://user-images.githubusercontent.com/30950318/133805737-1d7e8247-ec79-4762-a278-a10d5e176337.png)

- ConcretePrototype  (Table)
implements an operation for cloning itself

![image](https://user-images.githubusercontent.com/30950318/133805801-869ba9a4-dcce-4725-b35e-15d9801f8295.png)

 - Client  (TableManager)
creates a new object by asking a prototype to clone itself

![image](https://user-images.githubusercontent.com/30950318/133805841-b881f2b3-c6c3-4bee-b806-c68e5e03cea9.png)

Use of the prototype patern

![image](https://user-images.githubusercontent.com/30950318/133806377-2b163592-2e92-4646-9009-228e037f6c0d.png)

Advantages of Prototype Design Pattern

 - You can clone objects without coupling to their concrete classes.
 - You can get rid of repeated initialization code in favor of cloning pre-built prototypes.
 - You can produce complex objects more conveniently.
 - You get an alternative to inheritance when dealing with configuration presets for complex objects.

## Conclusions
In conclusion, it can be said that *Creational Design Patterns* solve some important problems present in software development, namely in the architecure design process. This class of paterns are seeking to centralize the creation and instantiation by eliminating the responsibilities of dependent classes to create objects, that have a valid state and expected content. Often these patterns come to solve some problems but there are cases when their use can cause other problems that contradict the SOLID principles.










