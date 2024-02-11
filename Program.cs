using Pattern_2.Patterns.Decorator;
using Pattern_2.Patterns.Decorator.Decorators;

IWriter writer = new PDFDecorator(new DOCDecorator(new Writer("Writer 1")));
IWriter writer2 = new PDFDecorator(new Writer("Writer 2"));

writer.Write("A new text");

Console.WriteLine("\n");

writer2.Write("A different new text");