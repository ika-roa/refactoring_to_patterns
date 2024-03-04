# refactoring_to_patterns
Translate refactorings from the book "Refactoring to patterns" from Joshua Kerievsky to Python and C#.

## Refactorings in C#

### Replace Constructors with Creation Methods
Different constructors of a class are replaced by creation methods. Those should have clear names that reveal their intention. Advantages are

- Better communication of what kinds of instances exist
- Fewer limitations than normal constructors (two creation methods can have same number and type of arguments)
- Better overview of what code is actually used
  
The example works nearly as described in the book, only the last small step (inline constructor) needs to be done manually.

### Chain Constructors
Different constructors of a class are refactored so that they all call a common catch-all constructor in order to reduce duplication. 
This refactoring might be used as a preliminary step to "Replace Constructors with Creation Methods".

### Factory pattern
Basic implementation of a factory design pattern.

### Encapsulate classes with Factory
This refactoring can be done completely via built-in refactorings with ReSharper. 
1. `Extract method` on the constructor call to produce a public, static creation method
1. `Move to another type` to move the creation method into the base class
1. `Use base type where possible` to make clients interact with the base class interface only
1. `To internal` on subclass to restrict direct access

### Polymorphic creation with Factory Method
This refactoring reduces duplication by combining classes that differ only in their object creation step. Another advantage is that it becomes clearer where the object creation occurs and how it may be
overridden. Steps:
1. Extract creation methods on classes with similar logic, but different creation. Use generic name for those creation methods, and use the same generic return type for both. If there is no common return type, extract an interface.
1. Pull up the creation method as abstract method to a base class in order to create a factory. The base class is now a *Creator* and the subclasses are *ConcreteCreators*.
1. Move all duplicated behavior to the base class, and leave only the differences in the subclasses.

### Replace Conditional logic with strategy
This refactoring simplifies a class by moving complicated conditional logic to specialized subclasses. It thus makes clearer what the task of the original class is, and makes it possible to exchange one kind of algorithm with another. However, it might be complicated to bring all necessary data into the subclasses. Steps:
1. Create a general strategy class, named after the behavior performed by the calculation method.
2. Move the calculation method to the strategy class, with all conditional logic. The original class retains a delegate, a field that contains a reference to the strategy, and that will perform the claculation from now on.
3. Make the necessary data available to the strategy by (1) passing the context as a parameter to the strategy's constructor or (2) passing individual arguments to the strategy.
4. Split up the strategy base class into specialized subclasses, tearing down the complicated conditional logic in the process.
5. Make the original class select which strategy to use in which case.


## Refactorings in Python

### Replace Constructors with Creation Methods
In Python, class methods allow to define alternate constructors. These are very similar to the creation methods described in the book.
Class methods belong to a class rather than an instances, and can be used to create class instances from different types of input.

### Encapsulate Classes with Factory
The factory pattern allows to create objects without exposing the creation logic to the client and to refer to newly created object using a common interface.
Advantages are: 

- Easy addition of new subclasses without changing the existing code (Open / Closed Principle)
- Lose coupling between the client class and the created objects
- The creation logic exists only in one place in the code (Single Responsibility Principle)

### Polymorphic creation with Factory Method
Creation methods create a bit of overhead in Python, where clean interfaces are not built-in as in C#. 
Instead, the similarities between classes can be highlighted using abstract base classes. 
The refactorings in Python need more care, as most of them need to be performed manually.
