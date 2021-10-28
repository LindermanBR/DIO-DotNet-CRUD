using System.Collections.Generic;   

namespace DIO.GameList.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
        T RetornoId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }
}