using senai.Hroads.webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Hroads.webAPI.Interfaces
{
    interface ITipoUsuarioRepository
    {
        /// <summary>
        /// Cadastra um novo Tipo de Usuário
        /// </summary>
        /// <param name="novoTipoUsuario">Objeto que recebe os dados do usuário a ser cadastrado</param>
        void Cadastrar(Tipousuario novoTipoUsuario);

        /// <summary>
        /// Lista todos os tipos de usuários
        /// </summary>
        /// <returns>Uma lista de objetos tipo usuários</returns>
        List<Tipousuario> Listar();

        /// <summary>
        /// Atualiza os dados de um tipo de usuário
        /// </summary>
        /// <param name="tipoUsuarioAtualizado">Objeto que recebe id do objeto a ser atualizado e suas novas informações</param>
        void Atualizar(Tipousuario tipoUsuarioAtualizado);

        /// <summary>
        /// Deleta um tipo de usuário
        /// </summary>
        /// <param name="idTipoUsuario">Variável que recebe id do usuário a ser deletado</param>
        void Deletar(int idTipoUsuario);
    }
}
