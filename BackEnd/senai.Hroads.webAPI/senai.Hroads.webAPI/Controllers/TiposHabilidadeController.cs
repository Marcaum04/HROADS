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
    [Route("api/[controller]")]
    [ApiController]
    public class TiposHabilidadeController : ControllerBase
    {

        /// <summary>
        /// Objeto que irá receber todos os métodos definidos na interface
        /// </summary>
        private ITipoHabilidadeRepository _TipoHabilidadeRepository { get; set; }


        /// <summary>
        /// Instancia o objeto para que haja referência às implementações feitas no repositório
        /// </summary>
        public TiposHabilidadeController()
        {
            _TipoHabilidadeRepository = new TipoHabilidadeRepository();
        }


        /// <summary>
        ///  Lista todas as Tipo de Habilidades existentes
        /// </summary>
        /// <returns>Uma lista de Tipo de Habilidades com o status code 200 - Ok</returns>
        [Authorize]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_TipoHabilidadeRepository.Listar());
        }


        /// <summary>
        /// Busca uma Tipo de Habilidade pelo seu id
        /// </summary>
        /// <param name="idTipoHabilidade">id da Tipo de Habilidade ser buscada</param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("{idTipoHabilidade}")]
        public IActionResult BuscarPorId(int idTipoHabilidade)
        {
            return Ok(_TipoHabilidadeRepository.BuscarPorId(idTipoHabilidade));
        }


        /// <summary>
        /// Cadastra uma Tipo de Habilidade 
        /// </summary>
        /// <param name="novoTipoHabilidade">"Tipo de Habilidades a ser cadastrada</param>
        /// <returns>Um status code 201 - Created</returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(TipoHabilidade novoTipoHabilidade)
        {
            _TipoHabilidadeRepository.Cadastrar(novoTipoHabilidade);

            return StatusCode(201);
        }


        /// <summary>
        /// Atualiza uma Tipo de Habilidade existente
        /// </summary>
        /// <param name="TipoHabilidadeAtualizada">Objeto com as novos informações da Tipo de Habilidade e o id da Tipo de Habilidade a ser atualizada</param>
        /// <returns>Um status code 204 - No content</returns>
        [Authorize(Roles = "1")]
        [HttpPut]
        public IActionResult Atualizar(TipoHabilidade TipoHabilidadeAtualizada)
        {
            _TipoHabilidadeRepository.Atualizar(TipoHabilidadeAtualizada);

            return StatusCode(204);
        }


        /// <summary>
        /// Deleta uma Tipo de Habilidade pelo id
        /// </summary>
        /// <param name="idTipoHabilidade">id da Tipo de Habilidade a ser deletada</param>
        /// <returns>Um status code 204 - No content</returns>
        [Authorize(Roles = "1")]
        [HttpDelete("{idTipoHabilidade}")]
        public IActionResult Deletar(int idTipoHabilidade)
        {
            _TipoHabilidadeRepository.Deletar(idTipoHabilidade);

            return StatusCode(204);
        }

    }
}
