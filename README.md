# C# Intermediate Concepts

In this tutorial, we are going to learn about C# intermediate concepts. We will try to show how to write C# code in an object-oriented manner and how to use the object-oriented concepts while writing that code.

## To learn about the OOP concept, we are going to cover the following topics:

 - [Classes and Constructors](./csharp-intermediate-concepts/Classes-and-Constructors)
 - [Properties](./csharp-intermediate-concepts/Properties)
 - [Static Members, Constants, and Extension Methods](./csharp-intermediate-concepts/Static%20Members,%20Constants%20and%20Extension%20Methods)
 - [Anonymous and Nullable Types](./csharp-intermediate-concepts/Anonymous-and-Nullable-Types)
 - [Structures](./csharp-intermediate-concepts/Structures)
 - [Enumerations](./csharp-intermediate-concepts/Enumerations)
 - [Inheritance](./csharp-intermediate-concepts/Inheritance)
 - [Interfaces](./csharp-intermediate-concepts/Interfaces)
 - [Abstract Classes](./csharp-intermediate-concepts/Abstract-classes)
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

###### Anonymous Classes:
 - An anonymous class is a class that does not have a name. This sounds strange but sometimes an anonymous class can be useful, especially when using query expressions.

###### Nullable Types:
 - The null value is useful for initializing reference types. So, it is logical that we can’t assign the null value to the value type because the null is itself a reference.

###### Structures:
 - A structure is a value type, in the opposite of a class which is a reference type, and it has its own fields, methods, and constructors like a class.
 - The structure is a value type, while the class is a reference type.

###### Enumerations:
- An enumeration type assigns the integer value to every element inside that enumeration. Those numbers start at 0 and increase by 1 for every other element.

###### Interfaces:
 - To define an interface we need to use the interface keyword. It is quite similar to defining a class just we use another keyword. Inside that interface, we specify our members without access modifier and implementation. So, we just provide a declaration for members, an implementation is a job for a class which implements that interfac.

###### Inheritance:
  **Rules to Follow While Working With Polymorphic Methods** :
  -  We can’t declare a virtual method as private. Its purpose is to be exposed to a derived class, so making it private is meaningless. Similarly, overridden methods can’t be private because a derived class can’t change the protection level of a method that it inherits
  - The signatures of virtual and overridden methods must be identical
  - We can override only a virtual method. If we try to override a method that has no virtual keyword, we will get an error
  - If we don’t use the override keyword we are not overriding the method we are just hiding it. If this is the behavior we want, we should use the new keyword
  - An overridden method is a virtual one as well, so it can be overridden in a further derived class
  
###### Properties:
 - A property is a member that provides a flexible tool to read and write the value of a private field. We use them as public data members but actually, they are specific methods called accessors.
 - **Property Accessibility**:
 - We can change the accessibility level of only one accessor. There is no point in having both accessors modified. If we want to modify both accessors, we should just modify the property access level.
 - We can’t use access modifier on the get or set blocks that are less restrictive of the access modifier applied on a property itself. So, if our property is private, there is no point in having the public get or set block.

###### Static Methods:
 - Static methods are the methods that don’t belong to an instance of a class, can interact only with other static elements and have the static keyword in the method description.
 
###### Extension Methods
 - An extension method enables us to extend an existing type with additional static methods. We must create that kind of methods inside a static class and they have the first parameter prefixed with the this keyword.
