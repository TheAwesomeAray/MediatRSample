using Application.Requests;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MediatRSample.Controllers
{
    public class HomeController : Controller
    {
        private IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            
            return View();
        }

        public ActionResult Update([FromBody]UpdateRequestCommand command)
        {
            _mediator.Send(command);

            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}
