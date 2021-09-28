using senai.Hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Hroads.webAPI.Interfaces
{
    interface IPersonagemRepository
    {
            /// <summary>
        /// Cadastra um novo Personagem
        /// </summary>
        /// <param name="novoPersonagem">Objeto que recebe os dados do personagem a ser cadastrado</param>
        void Cadastrar(Personagem novoPersonagem);

        /// <summary>
        /// Lista todos os personagens
        /// </summary>
        /// <returns>Uma lista de objetos personagens</returns>
        List<Personagem> Listar();

        /// <summary>
        /// Atualiza os dados de um personagem
        /// </summary>
        /// <param name="PersonagemAtualizado">Objeto que recebe id do objeto a ser atualizado e suas novas informações</param>
        void Atualizar(Personagem PersonagemAtualizado);

        /// <summary>
        /// Deleta um personagem
        /// </summary>
        /// <param name="idPersonagem">Variável que recebe id do usuário a ser deletado</param>
        void Deletar(int idPersonagem);
    }
}
