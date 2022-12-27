using System.Text.Json;
using TestDapper.Tools.Models;

namespace TestDapper.Tools
{
    public class ResponseBuilder
    {
        public static string GenerateResponse<T>(bool Status, string Msg, T Data)
        {
            ResponseModel<T> response = new ResponseModel<T>()
            {
                Status = true,
                Message = Msg,
                Data = Data
            };

            return JsonSerializer.Serialize(response);
        }
    }
}
