using Microsoft.AspNetCore.Mvc;
using Weather.Operations.Entities;
using Weather.Operations;


namespace Weather.Admin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SourcesController : ControllerBase
    {

        [HttpGet]
        public List<SourcesEntity> Get()
        {
            var result = new List<SourcesEntity>();

            try
            {
                result = Operations.Sources.Get();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
    }
}
