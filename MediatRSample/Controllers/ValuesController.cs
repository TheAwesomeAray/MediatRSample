using MediatR;
using Request.Commands;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace MediatRSample.Controllers
{
    public class ValuesController : ApiController
    {
        private IMediator _mediator;

        public ValuesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public async Task<IHttpActionResult> Post([FromBody]UpdateRequestCommand command)
        {
            string result = await _mediator.Send(command);
            return Ok(result);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
