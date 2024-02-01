# refactoring_to_patterns
Translate refactorings from the book "Refactoring to patterns" from Joshua Kerievsky to Python and C#.

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
