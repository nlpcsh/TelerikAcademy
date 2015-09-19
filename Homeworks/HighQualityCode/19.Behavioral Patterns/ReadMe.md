#Behavioral Patterns

##Chain of Responsibility

**Definition:** Allows you to pass a request to from an object to the next until the request is fulfilled

 * Ordered list of handlers
 * Analogous to the exception handling
 * Simplifies object interconnections - Each sender keeps a single reference to the next
 * There is also Tree of Responsibility
 * Sender is aware of only one receiver
 * Each receiver is only aware of the next receiver
 * Receivers process or send to the next
 * The sender does not know who received the message
 * The first receiver to handle the message terminates the chain
 * The order of the list matters


##State

 * Alter an object's behavior when its state changes

  * Allows an object to have different behavior based on its internal state
  * Allows separation of concerns (easier testing)
  * Encapsulate the logic of each state (separate class)
  * Easy to add new states

 * An object-oriented state machine

 * Examples:

  * TCP connection states
  * Music Player (play, pause, stop, etc.)

 * States are hidden (internal), the client uses only the context
  * The context gets its behavior by delegating the operation to the current state
  * Context acts as a proxy to the states

##Strategy

**Definition:** Define a family of algorithms, encapsulate each one, and make them interchangeable. Lets the algorithm vary independently form clients that use it.

**Main purpose:**

* Encapsulate a family of related algorithms
* Let the algorithm vary and evolve separate from the class using it
* Allow a class to maintain a single purpose
Separate the calculation from the delivery of its results

**When to consider:**

* Switch/if statements
* Adding a new operation will cause class modification

**Encapsulates an algorithm inside a class:**

* Making each algorithm replaceable by others
* All the algorithms can work with the same data transparently - The client can transparently work with each algorithm

**Consequences:**

* Strategies may not use members of the containing class
* Tests are easier to be written for individual concrete strategies
* Strategies may be mocked when testing the context class
* Adding new strategies does not modify anything

**Variations:**

* In .NET using `Func` or `Delegates`
* Property injection
* Pass strategy on a method or to the constructor

##Template Method

**Definition:** Defines the base of an algorithm in a method, leaving some implementation to its subclasses

**Main purpose:**

* Template Method allows the subclasses to redefine the implementation of some of the parts of the algorithm - Doesn’t let the subclasses to change the algorithm structure
* Relies on inheritance - strategy on composition
* Usually override of virtual or abstract method (hook)

**When to use:**

* Two or more classes should follow the same common algorithm or workflow
* The workflow never changes
* Subclasses may redefine the steps (not order)
* Some steps may be implemented in the base class (DRY)

In WebForms we can override the Render() method to output the HTML or intercept into the page life cycle

