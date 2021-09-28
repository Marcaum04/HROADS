using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using senai.Hroads.webAPI.Domains;
using senai.Hroads.webAPI.Interfaces;
using senai.Hroads.webAPI.Repositories;

namespace senai.Hroads.webAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonagensController : ControllerBase
    {
        /// <summary>
        ///  Objeto que irá receber todos os métodos definidos na interface
        /// </summary>
        private IPersonagemRepository _PersonagemRepository { get; set; }

        public PersonagensController()
        {
            _PersonagemRepository = new PersonagemRepository();
        }

        /// <summary>
        /// Lista todos os Tipos de personagens existentes
        /// </summary>
        /// <returns>Uma lista de objetos personagem e um status code 200 - OK</returns>
        [Authorize]
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_PersonagemRepository.Listar());
        }

        /// <summary>
        /// Cadastra um novo personagem
        /// </summary>
        /// <param name="novoPersonagem">Objeto que recebe os dados do personagem a ser cadastrado</param>
        /// <returns>Um status code 201 - CREATED</returns>
        [Authorize(Roles = "2")]
        [HttpPost]
        public IActionResult Cadastrar(Personagem novoPersonagem)
        {
            _PersonagemRepository.Cadastrar(novoPersonagem);

            return StatusCode(201);
        }

        /// <summary>
        /// Atualiza um tipo de personagem existente
        /// </summary>
        /// <param name="PersonagemAtualizado">Objeto que recebe o id do tipo de personagem a ser atualizado e seus novos dados</param>
        /// <returns>Um status code 204 - NO CONTENT</returns>
        [Authorize(Roles = "2")]
        [HttpPut]
        public IActionResult Atualizar(Personagem PersonagemAtualizado)
        {
            _PersonagemRepository.Atualizar(PersonagemAtualizado);

            return StatusCode(204);
        }

        /// <summary>
        /// Deleta um personagem
        /// </summary>
        /// <param name="id">variável que recebe o id do personagem a ser deletado</param>
        /// <returns>Status code 204 - NO CONTENT</returns>
        [Authorize(Roles = "2")]
        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            _PersonagemRepository.Deletar(id);

            return StatusCode(204);
        }
    }
}
