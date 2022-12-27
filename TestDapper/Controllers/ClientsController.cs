using DAL;
using Microsoft.AspNetCore.Mvc;
using TestDapper.Tools;

namespace TestDapper.Controllers
{
    
    [Route("Clients")]
    [ApiController]
    public class ClientsController : Controller
    {
        private ClientsDAO clientsDAO;

        public ClientsController(ClientsDAO _clientsDAO)
        {
            clientsDAO = _clientsDAO;
        }

        [HttpGet]
        [Route("test")]
        public ContentResult Test()
        {
            string response = ResponseBuilder.GenerateResponse(true, "success", clientsDAO.SelectTestClass());
            return Content(response, "application/json");

        }
    }
}
