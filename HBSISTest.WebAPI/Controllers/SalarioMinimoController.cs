using System;
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
    /// Salário Mínimo
    /// </summary>
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class SalarioMinimoController : ApiController
    {
        private readonly ISalarioMinimoAppService _salarioMinimoAppService;

        public SalarioMinimoController(ISalarioMinimoAppService salarioMinimoAppService)
        {
            _salarioMinimoAppService = salarioMinimoAppService;
        }

        /// <summary>
        /// Recupera Registro de Salário Mínimo
        /// </summary>
        /// <param name="id">Identificação Única do Registro de Salário Mínimo</param>
        /// <returns></returns>
        [HttpGet]
        [ResponseType(typeof(SalarioMinimoViewModel))]
        public IHttpActionResult Get(int id)
        {
            var salarioMinimo = _salarioMinimoAppService.GetById(id);
            var salario = Mapper.Map<SalarioMinimo, SalarioMinimoViewModel>(salarioMinimo);

            return Ok(salario);
        }

        /// <summary>
        /// Altera Salário Mínimo
        /// </summary>
        /// <param name="salarioMinimo"></param>
        [HttpPut]
        public IHttpActionResult Put(SalarioMinimoViewModel salarioMinimo)
        {
            string uri = "";

            if (salarioMinimo == null)
            {
                return BadRequest("Não possível alterar registro por que nenhuma informação foi passada.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var salarioMinimoDomain = Mapper.Map<SalarioMinimoViewModel, SalarioMinimo>(salarioMinimo);

                _salarioMinimoAppService.Update(salarioMinimoDomain);

                return Ok();
            }
            catch (Exception err)
            {
                return BadRequest(string.Format("{0} | {1} | {2}", err.Message, uri, 1));
            }
        }
    }
}