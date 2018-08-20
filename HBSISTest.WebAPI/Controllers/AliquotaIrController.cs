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
    /// Alíquota de Imposto de Renda
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AliquotaIrController : ApiController
    {
        private readonly IAliquotaIrAppService _aliquotaIrAppService;
        
        /// <param name="aliquotaIrAppService"></param>
        public AliquotaIrController(IAliquotaIrAppService aliquotaIrAppService)
        {
            _aliquotaIrAppService = aliquotaIrAppService;
        }

        /// <summary>
        /// Recupera lista de Alíquotas de IR
        /// </summary>
        /// <returns></returns>
        // GET: AliquotaIr
        [System.Web.Mvc.HttpGet]
        [ResponseType(typeof(IEnumerable<AliquotaIrViewModel>))]
        public IHttpActionResult Get()
        {
            var aliquotaIrDomain = _aliquotaIrAppService.GetAll();
            var aliquotaIr = Mapper.Map<IEnumerable<AliquotaIr>, IEnumerable<AliquotaIrViewModel>>(aliquotaIrDomain);

            return Ok(aliquotaIrDomain);
        }
    }
}