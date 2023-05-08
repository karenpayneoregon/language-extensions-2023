This repository is for the [following article](https://dev.to/karenpayneoregon/c-language-extensions-1jk6).

The article will discuss the fundamentals to extend existing types without creating new derived type, recompiling, or otherwise modifying the original type. [Extension methods](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/extension-methods) are a special kind of static method, but they are called as if they were instance methods on the extended type. The following [MSDN page](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-implement-and-call-a-custom-extension-method) lays out the basics for creating language extension methods.

For client code written in C#, F# and Visual Basic, there is no apparent difference between calling an extension method and the methods that are defined in a type. The primary language will be C# but extension methods as mention prior will work in other languages and can be written in one language and used in another language.

## Four advantages of extension methods

1. **Discoverability** – variable name plus dot will give you the method name via Intellisense, this serves you time when coding.

1. **Cleaner and simpler syntax** – all you must do is write variable name, dot and the extension method name and you are done.

1. **Code readability** – based on the above example, use of extension methods results in few lines of code written. This greatly improves the code readability.

1. **Extend functionality** of libraries you do not have access to the code – suppose you have a third-party library and you would like it to add more methods without recompiling the original code, you can take advantage of extension methods and add the functionality yourself. Your development team will use them as if they were shipped with the original library.


## Extension class projects

Although extension methods may be placed directly into a project this works although most developers will write many projects during their career, this should take extension methods from a given project to a Visual Studio solution with a project for the language extension methods. One extensions are required by a project simply add a reference to the project for the extension methods. Alternately the solution for extension method can contain one project per extension type, for instance a project for string extension methods, another project for generic extension methods and so forth.

## Extension namespaces

Extension methods are brought into scope by including a using [namespace]; statement at the top of the file. You need to know which C# namespace includes the extension methods you’re looking for, but that’s easy to determine once you know what it is you’re searching for.

When the C# compiler encounters a method call on an instance of an object and doesn’t find that method defined on the referenced object class, it then looks at all extension methods that are within scope to try to find one which matches the required method signature and class. If it finds one, it will pass the instance reference as the first argument to that extension method, then the rest of the arguments, if any, will be passed as subsequent arguments to the extension method. (If the C# compiler doesn’t find any corresponding extension method within scope, it will throw an error.)"

This is imperative this is understood, a good example is with a included extension method StringExtensions.Contains which when this extension method is invoked and not found a using statement is required. When for instance the using statement is not included but there is a reference in the project and R# (ReSharper is installed) the extension method Contains will be displayed with IntelliSense while without R# Visual Studio will not know about the extension method which in turn will offer to create it for you which is not what is intended.
