# Topic: *Creational Design Patterns*
## Author: *Ciobanu Andy-Constantin*
------
## Objectives :
__1. Study and understand the Creational Design Patterns;__

__2. Choose a domain, define its main classes/models/entities and choose the appropriate instantiation mechanisms;__

__3. Use some creational design patterns for object instantiation in a sample project;__

## Used Language: 
C# .NET

## Theoretical aspects : 

In software engineering, creational design patterns are design patterns that deal with object creation mechanisms, trying to create objects in a manner suitable to the situation. The basic form of object creation could result in design problems or added complexity to the design. Creational design patterns solve this problem by somehow controlling this object creation.

### Singleton - [Code](https://github.com/andycb479/TMPS-Labs/tree/master/Lab_1/Singleton)
Singleton design pattern is one of the most popular design patterns. In this pattern, a class has only one instance in the program that provides a global point of access to it. In other words, a singleton is a class that allows only a single instance of itself to be created and usually gives simple access to that instance.

![image](https://user-images.githubusercontent.com/30950318/133795572-75c7822b-a47a-40f6-b5c6-b55fa80e130f.png)

There are various ways to implement a singleton pattern. The following are the common characteristics of a singleton pattern implement using lazy loading.

Private and parameterless single constructor

![image](https://user-images.githubusercontent.com/30950318/133797684-a3518663-8090-4ea6-a300-3388d28e56ef.png)

Sealed class.

![image](https://user-images.githubusercontent.com/30950318/133797360-6647a80c-9c2b-4e35-ad90-67c056ce0854.png)

Static variable to hold a reference to the single created instance

![image](https://user-images.githubusercontent.com/30950318/133797393-92a0658e-79ea-4496-8cf0-8c673f113008.png)


A public and static way of getting the reference to the created instance.

![image](https://user-images.githubusercontent.com/30950318/133797446-4ad01d0a-dd32-4838-912f-1d7f248bf1b5.png)

Functionality of the Singleton Class

![image](https://user-images.githubusercontent.com/30950318/133798904-cbd828f9-8713-43f4-8666-9829e1580785.png)

Advantages of Singleton Design Pattern

- Singleton pattern can implement interfaces.
- Can be lazy-loaded and has Static Initialization.
- It helps to hide dependencies.
- It provides a single point of access to a particular instance, so it is easy to maintain.


Use of Singleton in the app:

![image](https://user-images.githubusercontent.com/30950318/133799067-ed27ab30-83f8-459e-83ed-b9ef89025fb5.png)

### Factory Method
Factory Method is a Design Pattern which defines an interface for creating an object but lets the classes that implement the interface decide which class to instantiate. Factory Pattern lets a class postpone instantiation to sub-classes. The factory pattern is used to replace class constructors, abstracting the process of object generation so that the type of the object instantiated can be determined at run-time. 

![image](https://user-images.githubusercontent.com/30950318/133798379-d5f2aea7-b33b-439d-9f59-f039fb873f91.png)

The classes and objects participating in the above UML class diagram are as follows:

1. Product 

This defines the interface of objects the factory method creates

2. ConcreteProduct

This is a class that implements the Product interface.

3. Creator

This is an abstract class and declares the factory method, which returns an object of type Product.
This may also define a default implementation of the factory method that returns a default ConcreteProduct object.
This may call the factory method to create a Product object.

4. ConcreteCreator

This is a class that implements the Creator class and overrides the factory method to return an instance of a ConcreteProduct.

The implementation within the Business Logic:

The abstract class factory - the base factory

![image](https://user-images.githubusercontent.com/30950318/133799419-3b9d57b8-3f92-405c-892e-75d344b3c464.png)

Concrete Factory

![image](https://user-images.githubusercontent.com/30950318/133799879-4e1623c7-47d9-41b1-b632-a907607361d9.png)

The use of the factory for seeding the database with records

![image](https://user-images.githubusercontent.com/30950318/133799988-1146bda7-8dd6-4e6c-a7cf-0e5b2529a525.png)





### Prototype
Prototype is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.

![image](https://user-images.githubusercontent.com/30950318/133795495-1915abb7-f6d0-4eb8-900d-f9437f643c60.png)










