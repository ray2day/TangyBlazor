using Microsoft.JSInterop;

namespace TangyWeb_Client.Helper
{
    public static class IJSRuntimeExtension
    {
        public static async Task ToastrSuccess(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr", "success",message);
        }

        public static async Task ToastrError(this IJSRuntime jsRuntime, string message)
        {
            await jsRuntime.InvokeVoidAsync("ShowToastr", "error",message);
        }
    }
}
