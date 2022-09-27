# C# Intermediate Concepts

In this tutorial, we are going to learn about C# intermediate concepts. We will try to show how to write C# code in an object-oriented manner and how to use the object-oriented concepts while writing that code.

## To learn about the OOP concept, we are going to cover the following topics:

 - Classes and Constructors
 - Properties
 - Static Members, Constants, and Extension Methods
 - Anonymous and Nullable Types
 - Structures
 - Enumerations
 - Inheritance
 - Interfaces
 - Abstract Classes
 - [Generics](./csharp-intermediate-concepts/Generics)
 - [Queue, Stack, Hashtable](./csharp-intermediate-concepts/Queue-Stack-Hashtable)
   - [Queue](./csharp-intermediate-concepts/Queue-Stack-Hashtable/QueueCollection.cs)
   - [Stack](./csharp-intermediate-concepts/Queue-Stack-Hashtable/StackCollection.cs)
   - [Hashtable](./csharp-intermediate-concepts/Queue-Stack-Hashtable/HashtableCollection.cs)
 - [Generic List and Dictionary](./csharp-intermediate-concepts/List-and-Dictionary)
   - [List](./csharp-intermediate-concepts/List-and-Dictionary/List.cs)
   - [Dictionary](./csharp-intermediate-concepts/List-and-Dictionary/Dictionary.cs)
 - [Delegates](./csharp-intermediate-concepts/Delegates)


## Definitions

###### Queue Collection:
 - The queue collection represents a first-in, first-out collection of objects. This means that we can place our objects in a queue collection in a certain order and remove those objects by the same order. So, the first object which goes in is the first object to go out.

###### Stack Collection:
 - A stack collection represents a simple last-in, first-out collection. It means that an element which enters first in a collection will exit last.

###### Hashtable:
 - The Hashtable represents a collection of a key-value pair that is organized based on the hash code of the key. Differently, from the queue and stack collections, we can instantiate a hashtable object by using the only System.Collections namespace.

###### List:
 - A List represents a strongly typed collection of objects that can be accessed by index.

###### Dictionary:
 - Dictionary represents a collection of keys and values.

###### Delegates:
 - A delegate is a reference to a method. We can use a delegate object to pass it to the code in which we want to call a referenced method, without knowing at compile time which method will be invoked.

###### Generics:
 - C# provides generics to help us remove the need for casting, to improve type safety and make it easier to create generic classes and generic methods.

###### Abstract Classes:
 - An abstract class can contain abstract methods. An abstract method doesn’t contain implementation just a definition with the abstract keyword.
 
###### Classes and Constructors:
 - A partial class is nothing more than a part of a single class. To define partial classes, we need to use the partial keyword in each file.
 - The constructor is a special method that has the same name as the class it is defined in, doesn’t return any value (not even void) and can take parameters. It runs automatically when we create an instance of a class. So, every time we use the new keyword to instantiate a class, we are calling a constructor of that class.
