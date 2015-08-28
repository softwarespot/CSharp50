# CSharp50

The following library is a port of the CS50 library. Details about the original library and what it's all about, can be found at https://manual.cs50.net/library.

## How to use

Download the repository, extract the contents and open Visual Studio. Once complete, right-click on the solution in the `solution explorer` pane and choose `add item`. Navigate to the directory where the contents of the repository were extracted and select `CSharp.cs`. This will copy the file (and any additional references) to your project. Then it's as simple as using the namespace (CSharp) plus the method name.

Current methods available:

- GetChar()
- GetDouble()
- GetFloat()
- GetInt()
- GetLong() (formerly known as GetLongLong(), but C# uses long)
- GetString()

## Example

```csharp
    string userChoice = CSharp.GetString();
    Console.WriteLine("Choice entered: " + userChoice);

    int userAge = CSharp.GetInt();
    Console.WriteLine("Age entered: " + userAge);
```
