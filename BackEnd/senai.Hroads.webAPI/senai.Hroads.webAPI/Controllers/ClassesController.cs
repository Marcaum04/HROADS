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
    public class ClassesController : ControllerBase
    {
        /// <summary>
        /// Objeto que irá receber todos os métodos definidos na interface
        /// </summary>
        private IClasseRepository _classeRepository { get; set; }


        /// <summary>
        /// Instancia o objeto para que haja referência às implementações feitas no repositório
        /// </summary>
        public ClassesController()
        {
            _classeRepository = new ClasseRepository();
        }


        /// <summary>
        ///  Lista todas as classes existentes
        /// </summary>
        /// <returns>Uma lista de classes com o status code 200 - Ok</returns>
        [Authorize]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_classeRepository.Listar());
        }


        /// <summary>
        /// Busca uma classe pelo seu id
        /// </summary>
        /// <param name="idClasse">id da classe a ser buscada</param>
        /// <returns></returns>
        [Authorize]
        [HttpGet("{idClasse}")]
        public IActionResult BuscarPorId(int idClasse)
        {
            return Ok(_classeRepository.BuscarPorId(idClasse));
        }


        /// <summary>
        /// Cadastra uma classe
        /// </summary>
        /// <param name="novaClasse">Classe a ser cadastrada</param>
        /// <returns>Um status code 201 - Created</returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Classe novaClasse)
        {
            _classeRepository.Cadastrar(novaClasse);

            return StatusCode(201);
        }


        /// <summary>
        /// Atualiza uma classe existente
        /// </summary>
        /// <param name="classeAtualizada">Objeto com as novas informações da classe e o id da classe a ser atualizada</param>
        /// <returns>Um status code 204 - No content</returns>
        [Authorize(Roles = "1")]
        [HttpPut]
        public IActionResult Atualizar(Classe classeAtualizada)
        {
            _classeRepository.Atualizar(classeAtualizada);

            return StatusCode(204);
        }


        /// <summary>
        /// Deleta uma classe pelo id
        /// </summary>
        /// <param name="idClasse">id da classe a ser deletada</param>
        /// <returns>Um status code 204 - No content</returns>
        [Authorize(Roles = "1")]
        [HttpDelete("{idClasse}")]
        public IActionResult Deletar(int idClasse)
        {
            _classeRepository.Deletar(idClasse);

            return StatusCode(204);
        }

    }
}
