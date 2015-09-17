# Structural Patterns

## `Composite`

**Definition** - collection of objects, any one of which may be either itself a Composite or just a leaf object.

**Advantage** - gives the possibility to treat the same individual objects or groups of objects

**Usage**

 * We have different objects and we want to treat them the same way
 * We want to present hierarchy of objects - Tree-like structures


**Examples** (in .NET Framework):

 * Windows.Forms.Control
 * System.Web.UI.Control
 * System.Xml.XmlNode


## `Decorator`

**Definition** - a class that surrounds a given class, adds new capabilities to it and passes all the unchanged methods to the underlying class. It provides us with a way to modify the behavior of individual objects without having to create a new derived class.

**Advantage** - Add functionality to existing objects at run-time

 * Wrapping original component
 * Alternative to inheritance (class explosion)
 * Support Open-Closed principle - flexible design, original object is unaware

**Usage** 

 * Applicable in legacy systems
 * Used to add functionality to UI controls
 * Can be used to extend sealed classes
 * In .NET: CryptoStream and GZipStream decorates Stream
 * In WPF _Decorator_ class provides a base class for  elements that apply effects onto or around a single child element, such as Border or Viewbox

## `Proxy`

**Definition** - provides a simple placeholder object for a more complex object that is in some way time consuming or expensive to instantiate

**Advantage** - If creating an object is expensive in time or computer resources, Proxy allows you to postpone this creation until you need the actual object. 

**Usage** - When you need to represent an object that is
complex or time consuming to create, by a simpler one. Proxies can also be used to distinguish between requesting an instance of an object and the actual need to access it. 

**Examples**:

1. An object, such as a large image, takes a long time to load.
2. The results of a computation take a long time to complete, and you
need to display intermediate results while the computation continues.
3. The object is on a remote machine, and loading it over the network
may be slow, especially during peak network load periods.
4. The object has limited access rights, and the proxy can validate the
access permissions for that user.

