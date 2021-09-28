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
    public class ClassesHabilidadesController : ControllerBase
    {

        /// <summary>
        /// Objeto que irá receber todos os métodos definidos na interface
        /// </summary>
        private IClasseHabilidadeRepository _classeHabilidadeRepository { get; set; }


        /// <summary>
        /// Instancia o objeto para que haja referência às implementações feitas no repositório
        /// </summary>
        public ClassesHabilidadesController()
        {
            _classeHabilidadeRepository = new ClasseHabilidadeRepository();
        }


        /// <summary>
        ///  Lista todas as habilidades de classes existentes
        /// </summary>
        /// <returns>Uma lista de habilidades de classes com o status code 200 - Ok</returns>
        [Authorize]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_classeHabilidadeRepository.Listar());
        }


        /// <summary>
        /// Busca uma habilidade de classe pelo seu id
        /// </summary>
        /// <param name="idClasseHabilidade">id da habilidade de classe a ser buscada</param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("{idClasseHabilidade}")]
        public IActionResult BuscarPorId(int idClasseHabilidade)
        {
            return Ok(_classeHabilidadeRepository.BuscarPorId(idClasseHabilidade));
        }


        /// <summary>
        /// Cadastra uma habilidade de classe
        /// </summary>
        /// <param name="novaClasseHabilidade">"Habilidades de Classe a ser cadastrada</param>
        /// <returns>Um status code 201 - Created</returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(ClasseHabilidade novaClasseHabilidade)
        {
            _classeHabilidadeRepository.Cadastrar(novaClasseHabilidade);

            return StatusCode(201);
        }


        /// <summary>
        /// Atualiza uma habilidade de classe existente
        /// </summary>
        /// <param name="classeHabilidadeAtualizada">Objeto com as novas informações da habilidade de classe e o id da classe a ser atualizada</param>
        /// <returns>Um status code 204 - No content</returns>
        [Authorize(Roles = "1")]
        [HttpPut]
        public IActionResult Atualizar(ClasseHabilidade classeHabilidadeAtualizada)
        {
            _classeHabilidadeRepository.Atualizar(classeHabilidadeAtualizada);

            return StatusCode(204);
        }


        /// <summary>
        /// Deleta uma habilidade de classe pelo id
        /// </summary>
        /// <param name="idClasseHabilidade">id da habilidade de classe a ser deletada</param>
        /// <returns>Um status code 204 - No content</returns>
        [Authorize(Roles = "1")]
        [HttpDelete("{idClasseHabilidade}")]
        public IActionResult Deletar(int idClasseHabilidade)
        {
            _classeHabilidadeRepository.Deletar(idClasseHabilidade);

            return StatusCode(204);
        }

    }
}
