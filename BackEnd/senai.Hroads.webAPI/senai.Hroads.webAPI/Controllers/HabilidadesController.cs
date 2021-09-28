using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.Hroads.webAPI.Domains;
using senai.Hroads.webAPI.Interfaces;
using senai.Hroads.webAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Hroads.webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class HabilidadesController : ControllerBase
    {
        /// <summary>
        /// Objeto que irá receber todos os métodos definidos na interface
        /// </summary>
        private IHabilidadeRepository _HabilidadeRepository { get; set; }


        /// <summary>
        /// Instancia o objeto para que haja referência às implementações feitas no repositório
        /// </summary>
        public HabilidadesController()
        {
            _HabilidadeRepository = new HabilidadeRepository();
        }


        /// <summary>
        ///  Lista todas as habilidades existentes
        /// </summary>
        /// <returns>Uma lista de habilidades com o status code 200 - Ok</returns>
        [Authorize]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_HabilidadeRepository.Listar());
        }


        /// <summary>
        /// Busca uma habilidade pelo seu id
        /// </summary>
        /// <param name="idHabilidade">id da habilidade ser buscada</param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("{idHabilidade}")]
        public IActionResult BuscarPorId(int idHabilidade)
        {
            return Ok(_HabilidadeRepository.BuscarPorId(idHabilidade));
        }


        /// <summary>
        /// Cadastra uma habilidade 
        /// </summary>
        /// <param name="novaHabilidade">"Habilidades a ser cadastrada</param>
        /// <returns>Um status code 201 - Created</returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Habilidade novaHabilidade)
        {
            _HabilidadeRepository.Cadastrar(novaHabilidade);

            return StatusCode(201);
        }


        /// <summary>
        /// Atualiza uma habilidade existente
        /// </summary>
        /// <param name="HabilidadeAtualizada">Objeto com as novas informações da habilidade e o id da habilidade a ser atualizada</param>
        /// <returns>Um status code 204 - No content</returns>
        [Authorize(Roles = "1")]
        [HttpPut]
        public IActionResult Atualizar(Habilidade HabilidadeAtualizada)
        {
            _HabilidadeRepository.Atualizar(HabilidadeAtualizada);

            return StatusCode(204);
        }


        /// <summary>
        /// Deleta uma habilidade pelo id
        /// </summary>
        /// <param name="idHabilidade">id da habilidade a ser deletada</param>
        /// <returns>Um status code 204 - No content</returns>
        [Authorize(Roles = "1")]
        [HttpDelete("{idHabilidade}")]
        public IActionResult Deletar(int idHabilidade)
        {
            _HabilidadeRepository.Deletar(idHabilidade);

            return StatusCode(204);
        }

    }
}
