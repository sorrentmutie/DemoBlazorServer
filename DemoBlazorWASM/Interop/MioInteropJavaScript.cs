using Microsoft.JSInterop;

namespace DemoBlazorWASM.Interop;

public class MioInteropJavaScript
{
    private readonly IJSRuntime jSRuntime;

    public MioInteropJavaScript(IJSRuntime jSRuntime)
    {
        this.jSRuntime = jSRuntime;
    }

    public async Task<int> SommaDaJavaScript(int a, int b)
    {
        return await jSRuntime.InvokeAsync<int>("miaSomma", a, b);
    }

    public async Task MiaMoltiplicazione(int a , int b)
    {
        await jSRuntime.InvokeVoidAsync("miaMoltiplicazione", a, b);
    }

    public async Task SalutaDaJavaScript(string nome)
    {
       var myHello = new HelloHelper(nome);
       var objRef = DotNetObjectReference.Create(myHello);
       await jSRuntime.InvokeVoidAsync("sayHello", objRef);
    }


}
