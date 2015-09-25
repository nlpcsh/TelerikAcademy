#Creational Patterns

----------

#### Problem

> Creational design patterns abstract the instantiation process. They help make a system independent of how its objects are created, composed, and represented. A class creational pattern uses inheritance to vary the class that's instantiated, where as an object creational pattern will delegate instantiation to another object.

> Creational patterns become important as systems evolve to depend more on object composition than class inheritance. As that happens, emphasis shifts away from
hard-coding a fixed set of behaviors toward defining a smaller set of fundamental behaviors that can be composed into any number of more complex ones. Thus creating objects with particular behaviors requires more than simply instantiating a class.

> There are two recurring themes in these patterns. First, they all **encapsulate knowledge about which concrete classes the system uses**. Second, they **hide how instances of these classes are created and put together**. All the system at large knows about the objects is their interfaces as defined by abstract classes. Consequently, the creational patterns give you a lot of flexibility in **`WHAT`** gets created, **`WHO`** creates it, **`HOW`** it gets created, and when. They let you configure a system with "product" objects that vary widely in structure and functionality. Configuration can be static (that is, specified at compile-time) or dynamic (at run-time).


## Simple Factory

#### Definition
Encapsulates object creation logic

* If we are making specific class selection logic changes, we make them in one place
* We can hide complex object creation

#### Consequences
* Each time we add new type we need to modify the simple factory code


## Abstract Factory

#### Intent
Provide an interface for creating families of related or dependent objects without specifying their concrete classes.

#### Motivation


#### Applicability
Use the Abstract Factory pattern when:

* a system should be independent of how its products are created, composed, and represented;
* a system should be configured with one of multiple families of products;
* a family of related product objects is designed to be used together, and you need to enforce this constraint;
* you want to provide a class library of products, and you want to reveal just their interfaces, not their implementations.

#### Consequences
The Abstract Factory pattern has the following benefits and liabilities:

1. It isolates concrete classes. The Abstract Factory pattern helps you control the classes of objects that an application creates. Because a factory encapsulates the responsibility and the process of creating product objects, it isolates clients from implementation classes. **Clients manipulate instances through their abstract interfaces.** Product class names are isolated in the implementation of the concrete factory; they do not appear
in client code.

2. It makes exchanging product families easy. The class of a concrete factory appears only once in an application — that is, where it's instantiated. This makes it easy to change the concrete factory an application uses. **It can
use different product configurations simply by changing the concrete factory.** Because an abstract factory creates a complete family of products, the whole product family changes at once. In our user interface example, we can switch from Motif widgets to Presentation Manager widgets simply by switching the corresponding factory objects and recreating the interface.

3. **It promotes consistency among products.** When product objects in a family are designed to work together, it's important that an application use objects from only one family at a time. Abstract Factory makes this easy to enforce.

4. **Supporting new kinds of products is difficult.** Extending abstract factories to produce new kinds of Products isn't easy. That's because the Abstract Factory interface fixes the set of products that can be created.
Supporting new kinds of products requires extending the factory interface, which involves changing the Abstract Factory class and all of its subclasses. We discuss one solution to this problem in the Implementation section.

#### Related Patterns
Abstract Factory classes are often implemented with `Factory Method`, but they can also be implemented using `Prototype`. A concrete factory is often a `Singleton`.


## Builder

#### Intent
Separate the construction of a complex object from its representation so that the same construction process can create different representations.

#### Motivation
Solves 3 problems:

* Too many parameters
* Order dependent
* Different constructions

#### Applicability
Use it when:

* the algorithm for creating a complex object should be independent of the parts that make up the object and how they're assembled.
* the construction process must allow different representations for the object that's constructed.

#### Consequences
* It lets you vary a product's internal representation. The Builder object provides the director with an abstract interface for constructing the product. The interface lets the builder hide the representation and internal structure of the product. It also hides how the product gets  assembled. Because the product is constructed through an abstract interface, all you have to do to change the product's internal representation is define a new kind of builder.
* It isolates code for construction and representation. The Builder pattern improves modularity by encapsulating the way a complex object is constructed and represented. Clients needn't know anything about the classes that define the product's internal structure; such classes don't appear in Builder's interface.
* It gives you finer control over the construction process. Unlike creational patterns that construct products in one shot, the Builder pattern constructs the product step by step under the director's control. Only when the product
is finished does the director retrieve it from the builder. Hence the Builder interface reflects the process of constructing the product more than other creational patterns. This gives you finer control over the construction process and consequently the internal structure of the  resulting product.

#### Related Patterns

**Abstract Factory** is similar to Builder in that it too may construct complex objects. The primary difference is that the Builder pattern focuses on constructing a complex object step by step. Abstract Factory's emphasis is on families of product objects (either simple or complex). Builder returns the product as a final step, but as far as the Abstract Factory pattern is concerned, the product gets returned immediately.
A **Composite** is what the builder often builds.


## Factory Method

#### Intent
Define an interface for creating an object, but let subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.

#### Motivation
Frameworks use abstract classes to define and maintain relationships between objects. A framework is often responsible for creating these objects as well.

#### Applicability
Use it when:

* a class can't anticipate the class of objects it must create.
* a class wants its subclasses to specify the objects it creates.
* classes delegate responsibility to one of several helper subclasses, and you want to localize the knowledge of which helper subclass is the delegate.

#### Consequences
* Provides hooks for subclasses. Creating objects inside a class with a factory method is always more flexible than creating an object directly. Factory Method gives subclasses a hook for providing an extended version
of an object.
* Connects parallel class hierarchies

#### Related Patterns
**Abstract Factory** is often implemented with factory methods.
Factory methods are usually called within **Template Methods**.
**Prototypes** don't require subclassing Creator. However, they often require an Initialize operation on the Product class. Creator uses Initialize to initialize the object. Factory Method doesn't require such an operation.

## Prototype

#### Intent
Specify the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.

#### Motivation


#### Applicability
* when the classes to instantiate are specified at run-time, for example, by dynamic loading; or
* to avoid building a class hierarchy of factories that parallels the class hierarchy of products; or
* when instances of a class can have one of only a few different combinations of state. It may be more convenient to install a corresponding number of prototypes and clone them rather than instantiating the class manually, each time with the appropriate state.

#### Consequences
* Adding and removing products at run-time
* Specifying new objects by varying values
* Specifying new objects by varying structure
* Reduced subclassing
* Configuring an application with classes dynamically

#### Related Patterns
Prototype and **Abstract Factory** are competing patterns in some ways. They can also be used together, however. An
Abstract Factory might store a set of prototypes from which to clone and return product objects.
Designs that make heavy use of the **Composite** and **Decorator** patterns often can benefit from Prototype as well.

## Singleton

#### Intent
Ensure a class only has one instance, and provide a global point of access to it.

#### Motivation
It's important for some classes to have exactly one instance. Although there can be many printers in a system, there should be only one printer spooler. There should be only one file system and one window manager.

#### Applicability
* there must be exactly one instance of a class, and it must be accessible to clients from a well-known access point.
* when the sole instance should be extensible by subclassing, and clients should be able to use an extended instance without modifying their code.

#### Consequences
* Controlled access to sole instance
* Reduced name space
* Permits refinement of operations and representation
* Permits a variable number of instances
* More flexible than class operations

#### Related Patterns
Many patterns can be implemented using the Singleton pattern. See **Abstract Factory**, **Builder**, and **Prototype**.


## Discussion of Creational Patterns

There are two common ways to parameterize a system by the classes of objects it creates. One way is to subclass the class that creates the objects; this corresponds to using the **Factory Method** pattern. The main drawback of this approach is that it can require creating a new subclass just to change the class of the product. Such changes can cascade. For example, when the product creator is itself created by a factory method, then you have to override its creator as well.

The other way to parameterize a system relies more on object composition: Define an object that's responsible for knowing the class of the product objects, and make it a parameter of the system. This is a key aspect of the **Abstract Factory**, **Builder**, and **Prototype** patterns. All three involve creating a new "factory object" whose responsibility is to create product objects.
 
* Abstract Factory has the factory object producing objects of several classes. 
* Builder has the factory object building a complex product incrementally using a correspondingly complex protocol. 
* Prototype has the factory object building a product by copying a prototype object. 

In this case, the factory object and the prototype are the same object, because the prototype is responsible for returning the product.