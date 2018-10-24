# HW-5
HW -5 is the introduction to Dependency Injection. 

# How does Dependency Injection help to write 'Clean Code'
Dependency Injection will make the code incredibly flexible, reusable, and uncoupled. The idea behind Dependency Injection is to keep the code uncoupled so you can add, remove and improve your code quickly and effectively. A corollary is also that we are less inclined to break code because when code is uncoupled, we should only be working on the dependencies we need.

# For your final project, how can you use Inversion of Control in your application?
Well, I assume it helps us control the application to make it the way we want. Since it helps us control the flow of application, we don't need to worry about other extra things and we can focus on the main idea of the project. It also help us in designing loosely coupled classes which make them testable, maintainable and extensible.

# What is the Explicit Dependencies Principle?
The Explicit Dependencies Principle states that methods and classes should explicitly require (typically through method parameters or constructor parameters) any collaborating objects they need in order to function correctly.

Being explicit about its dependencies means, that a class exposes all its class-level dependencies in its constructor. However, more local ones may appear as method parameter list. It is due to the explicit declaration, that we are aware of all dependencies a class has, at the time of its object construction.

An explicit dependency is often declared as an interface in the class constructor. Consequently, the dependency can be easily swapped out with its other implementations, whether in production or during testing or debugging. This makes them much easier to maintain and far more open to accept any change.
