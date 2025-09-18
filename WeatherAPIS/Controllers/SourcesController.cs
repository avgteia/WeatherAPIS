using Microsoft.AspNetCore.Mvc;
using Weather.Operations.Entities;
using Weather.Operations;
using Weather.Commons.Entities;


namespace Weather.Admin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SourcesController : ControllerBase
    {

        [HttpGet]
        public List<SourcesEntity> Get()
        {
            var result = new List<SourcesEntity>();

            try
            {
                result = Sources.GetService();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
        
        [HttpGet("GetById")]
        public SourcesEntity GetById([FromQuery] SourceRequestEntity request)
        {
            var result = new SourcesEntity();

            try
            {
                result = Sources.GetByIdService(request);
            }
            catch(Exception ex )
            {
                throw new Exception(ex.Message);
            }

            return result;
        }

        [HttpPost]
        public NonQueryResultEntity Add([FromBody]SourceAddDto request)
        {

            var result = new NonQueryResultEntity();

            try
            {
                result = Sources.AddService(request);
            }
            catch(Exception ex)
            {
                result.NonAffectionReason = ex.Message;
            }

            return result;
        }

        [HttpDelete]
        public NonQueryResultEntity DeleteService(Guid idSource)
        {
            var result = new NonQueryResultEntity();

            try
            {
                result = Sources.DeleteService(idSource);
            }
            catch(Exception ex)
            {
                result.NonAffectionReason = ex.Message;
            }

            return result;
        }

        [HttpPatch]
        public NonQueryResultEntity Update([FromBody] SourceUpdDto request)
        {

            var result = new NonQueryResultEntity();

            try
            {
                result = Sources.UpdateService(request);
            }
            catch (Exception ex)
            {
                result.NonAffectionReason = ex.Message;
            }

            return result;
        }
    }
}
