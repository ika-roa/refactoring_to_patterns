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
1. Move the calculation method to the strategy class, with all conditional logic. The original class retains a delegate, a field that contains a reference to the strategy, and that will perform the claculation from now on.
1. Make the necessary data available to the strategy by (1) passing the context as a parameter to the strategy's constructor or (2) passing individual arguments to the strategy.
1. Split up the strategy base class into specialized subclasses, tearing down the complicated conditional logic in the process.
1. Make the original class select which strategy to use in which case.

### Form template method
This refactoring reduces duplicated code in related subclasses, by combining similar, but not identical methods into a common template method. If the two methods contain roughly the same steps in the same order, but the steps are not the same, the sequence can be moved to the super class in the form of concrete methods, abstract methods (that must be overriden) or hook methods (that can optionally be overridden). The advantage of this pattern is that general and individual behavior gets clearly separated, and the steps of a general algorithm are clearly communicated. However, its usefulness decreases the bigger the differences between the methods are. Steps:
1. Identify the similar methods and split them up by extracting shorter methods. The aim here is to make the bodies of the two methods the same by combining general and unique methods. This step depends a lot on domain knowledge.
1. Pull up the now identical methods into the super class.
1. Clean up by pulling identical helper methods up into the super class.
1. For similar, but not identical methods, make the method signature the same and pull them up as abstract method.
1. If a method has one default behavior, which deviates in only one subclass, a hook method can be used. This hook method has a default behavior, but can be overridden. 


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
