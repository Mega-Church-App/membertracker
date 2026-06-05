using Microsoft.JSInterop;

namespace ChurchApp.Services.Extensions
{
    public static class Toast
    {
        public static async Task ToastrSuccess(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("showToast", message, "success");
        }

        public static async Task ToastrError(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("showToast", message, "error");
        }
    }
}
