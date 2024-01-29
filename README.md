# refactoring_to_patterns
Translate refactorings from the book "Refactoring to patterns" from Joshua Kerievsky to Python

## Refactorings

### Replace Constructors with Creation Methods
In Python, class methods allow to define alternate constructors. 
These are very similar to the creation methods described in the book.
Class methods belong to a class rather than an instances, and can be used to create class instances from different types of input.
