# CommandPattern
An example of how to use the Command Pattern

Within this project, you can find a simple implementation of the GoF Command Pattern.
It supports simple commands, with an example using a light, Macro Commands to execute
multiple commands at a single call and Undo, well to undo the last Command.

To add more functionality to the solution, simple add your class with implementation
into ItemTypes and create the command classes you want in Commands.

The container method used for Macro Commands can be changed to other containers.
The Undo can be changed to a stack like container to enable a chain of undos.

I hope this example can be of use in understanding how the pattern works.
