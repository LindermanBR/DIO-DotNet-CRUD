using System;
using System.Collections.Generic;
using DIO.GameList.Interfaces;


namespace DIO.GameList.Classes
{
    public class GamesRepositorio : IRepositorio<Games>
    {
        private List<Games> listaGames = new List<Games>();

        public void Atualiza(int id, Games entidade)
        {
            listaGames[id] = entidade;
        }

        public void Exclui(int id)
        {
           listaGames[id].Excluir();
        }

        public void Insere(Games entidade)
        {
            listaGames.Add(entidade);
        }

        public List<Games> Lista()
        {
            return listaGames;
        }

        public int ProximoId()
        {
            return listaGames.Count;
        }

        public Games RetornoId(int id)
        {
            return listaGames[id];
        }
    }
}