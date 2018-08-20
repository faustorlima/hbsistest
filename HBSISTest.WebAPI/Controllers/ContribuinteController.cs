using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using AutoMapper;
using HBSISTest.Application.Interfaces;
using HBSISTest.Domain.Entities;
using HBSISTest.WebAPI.ViewModels;

namespace HBSISTest.WebAPI.Controllers
{
    /// <summary>
    /// Contribuinte
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ContribuinteController : ApiController
    {
        private readonly IContribuinteAppService _contribuinteAppService;
        
        public ContribuinteController(IContribuinteAppService contribuinteAppService)
        {
            _contribuinteAppService = contribuinteAppService;
        }

        /// <summary>
        /// Recupera lista de Contribuintes
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(IEnumerable<ContribuinteViewModel>))]
        public IHttpActionResult Get()
        {
            var contribuintesDomain = _contribuinteAppService.GetAll();
            var contribuintes = Mapper.Map<IEnumerable<Contribuinte>, IEnumerable<ContribuinteViewModel>>(contribuintesDomain);
            
            return Ok(contribuintes);
        }

        /// <summary>
        /// Registra novo Contribuinte
        /// </summary>
        /// <param name="contribuinte"></param>
        [HttpPost]
        public IHttpActionResult Post(ContribuinteViewModel contribuinte)
        {
            string uri = "";

            if (contribuinte == null)
            {
                return BadRequest("Não possível inserir nenhum registro por que nenhuma informação foi passada.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var contribuinteDomain = Mapper.Map<ContribuinteViewModel, Contribuinte>(contribuinte);

                _contribuinteAppService.Add(contribuinteDomain);

                return Ok();
            }
            catch (Exception err)
            {
                return BadRequest(string.Format("{0} | {1} | {2}", err.Message, uri, 1));
            }
        }        
    }
}
