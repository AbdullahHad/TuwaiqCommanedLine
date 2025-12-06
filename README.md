# Tuwaiq Command Line Project

A simple C# console application for the Tuwaiq Academy assignment.  
The program reads command-line arguments and prints:

- Total number of arguments (`argc`)
- Each argument with its index (`argv[i]`)

---

## ▶️ How to Run

dotnet run arg1 arg2 arg3



### Example
dotnet run hello world



### Output
argc = 2
argv[0] = hello
argv[1] = world



---

## 🧠 Code Summary

```csharp
Console.WriteLine("argc = " + args.Length);
for (int i = 0; i < args.Length; i++)
{
    Console.WriteLine($"argv[{i}] = {args[i]}");
}
👤 Author
Abdullah Almutairi
GitHub: https://github.com/AbdullahHad


