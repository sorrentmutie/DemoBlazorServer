using Microsoft.JSInterop;

namespace DemoBlazorWASM.Interop;

public class HelloHelper
{
    public string? Name { get; set; }

    public HelloHelper(string name)
    {
        Name = name;
    }

    [JSInvokable]
    public string SayHello()
    {
        return $"Hello, {Name}!";
    }

}
