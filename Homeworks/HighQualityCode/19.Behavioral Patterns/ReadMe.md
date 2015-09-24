# Behavioral Patterns
----
#### Problem
>Behavioral patterns are concerned with algorithms and the assignment of responsibilities between objects. Behavioral patterns describe not just patterns of objects or classes but also the patterns of communication between them. These
patterns characterize complex control flow that's difficult to follow at run-time. They shift your focus away from flow of control to let you concentrate just on
the way objects are interconnected. 

>Behavioral `class` patterns use inheritance to distribute behavior between classes.

>Behavioral `object` patterns use object composition rather than inheritance. Some describe how a group of peer objects cooperate to perform a task that no single object can carry out by itself. An important issue here is how peer objects know about each other. Peers could maintain explicit references to each other, but that would increase their coupling.

## Chain of Responsibility

#### Intent
Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.

#### Motivation
The idea of this pattern is to decouple senders and receivers by giving multiple objects a chance to handle a request. The request gets passed along a chain of
objects until one of them handles it.

#### Applicability
Use it when:

* more than one object may handle a request, and the handler isn't known a priori. The handler should be ascertained automatically.
* you want to issue a request to one of several objects without specifying the receiver explicitly.
* the set of objects that can handle a request should be specified dynamically.

#### Consequences
* reduced coupling
* added flexibility in assigning responsibilities to objects
* receipt isn't guaranteed. Since a request has no explicit receiver, there's no guarantee it'll be handled — the request can fall off the end of the chain without ever being handled.

#### Related patterns
Chain of Responsibility is often applied in conjunction with **Composite**. There, a component's parent can act as its successor.


## State

#### Intent
Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.

#### Motivation
 * alter an object's behavior when its state changes.
 * allows an object to have different behavior based on its internal state
 * allows separation of concerns (easier testing)
 * encapsulate the logic of each state (separate class)
 * easy to add new states
 * an object-oriented state machine

#### Applicability
Use it when:

* An object's behavior depends on its state, and it must change its behavior at run-time depending on that state.
* Operations have large, multi part conditional statements that depend on the object's state. This state is usually represented by one or more enumerated constants. Often, several operations will contain this same conditional
structure. The State pattern puts each branch of  the conditional in a separate class. This lets you treat the object's state as an object in its own right that can vary independently from other objects.

#### Consequences
* it localizes state-specific behavior and partitions behavior for different states
* it makes state transitions explicit
* state objects can be shared

#### Examples
  * TCP connection states
  * Music Player (play, pause, stop, etc.)


## Strategy

#### Intent
Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

#### Motivation
* encapsulate a family of related algorithms
* let the algorithm vary and evolve separate from the class using it
* allow a class to maintain a single purpose. 
* separate the calculation from the delivery of its results

#### Applicability
Use it when:

* many related classes differ only in their behavior. Strategies provide a way to configure a class with one of many behaviors.
* you need different variants of an algorithm. For example, you might define algorithms reflecting different space/time trade-offs. Strategies can be used when these variants are implemented as a class hierarchy of
algorithms.
* an algorithm uses data that clients shouldn't know about. Use the Strategy pattern to avoid exposing complex, algorithm-specific data structures.
* a class defines many behaviors, and these appear as multi-preconditional statements in its operations. Instead of many conditionals, move related conditional branches into their own Strategy class.

#### Consequences
* strategies may not use members of the containing class
* tests are easier to be written for individual concrete strategies
* strategies may be mocked when testing the context class
* adding new strategies does not modify anything

#### Related Patterns
Flyweight: Strategy objects often make good flyweights

#### Examples

* In .NET using `Func` or `Delegates`
* Property injection
* Pass strategy on a method or to the constructor


## Template Method

#### Intent
Defines the base of an algorithm in a method, leaving some implementation to its subclasses.

#### Motivation
* Template Method allows the subclasses to redefine the implementation of some of the parts of the algorithm - Doesn’t let the subclasses to change the algorithm structure
* Relies on inheritance - strategy on composition
* Usually override of virtual or abstract method (hook)

#### Applicability
* Two or more classes should follow the same common algorithm or workflow
* The workflow never changes
* Subclasses may redefine the steps (not order)
* Some steps may be implemented in the base class (DRY)

In WebForms we can override the Render() method to output the HTML or intercept into the page life cycle

#### Consequences
* Template methods are a fundamental technique for code reuse
* Template methods lead to an inverted control structure that's sometimes referred to as "the Hollywood principle," that is, "Don't call us, we'll call you"

#### Related Patterns
`Factory Methods` are often called by template methods.
 
`Strategy`: Template methods use inheritance to vary part of an algorithm. Strategies use delegation to vary the entire algorithm.