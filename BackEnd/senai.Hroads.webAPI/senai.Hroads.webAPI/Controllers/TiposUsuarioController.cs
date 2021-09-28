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
    public class TiposUsuarioController : ControllerBase
    {
        /// <summary>
        ///  Objeto que irá receber todos os métodos definidos na interface
        /// </summary>
        private ITipoUsuarioRepository _TipoUsuarioRepository { get; set; }

        public TiposUsuarioController()
        {
            _TipoUsuarioRepository = new TipoUsuarioRepository();
        }

        /// <summary>
        /// Lista todos os Tipos de usuários existentes
        /// </summary>
        /// <returns>Uma lista de objetos Tipo Usuário e um status code 200 - OK</returns>
        [Authorize]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_TipoUsuarioRepository.Listar());
        }

        /// <summary>
        /// Cadastra um novo Tipo de Usuário
        /// </summary>
        /// <param name="novoTipoUsuario">Objeto que recebe o objeto a ser cadastrado</param>
        /// <returns>Um status code 201 - CREATED</returns>
        [Authorize(Roles = "1")]
        [HttpPost]
        public IActionResult Cadastrar(Tipousuario novoTipoUsuario)
        {
            _TipoUsuarioRepository.Cadastrar(novoTipoUsuario);

            return StatusCode(201);
        }

        /// <summary>
        /// Atualiza um tipo de usuário existente
        /// </summary>
        /// <param name="tipoUsuarioAtualizado">Objeto que recebe o id do tipo de usuário a ser atualizado e seus novos dados</param>
        /// <returns>Um status code 204 - NO CONTENT</returns>
        [Authorize(Roles = "1")]
        [HttpPut]
        public IActionResult Atualizar(Tipousuario tipoUsuarioAtualizado)
        {
            _TipoUsuarioRepository.Atualizar(tipoUsuarioAtualizado);

            return StatusCode(204);
        }

        /// <summary>
        /// Deleta um Tipo de Usuário
        /// </summary>
        /// <param name="id">variável que recebe o id do Tipo de Usuário a ser deletado</param>
        /// <returns>Status code 204 - NO CONTENT</returns>
        [Authorize(Roles = "1")]
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _TipoUsuarioRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
