using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Delete(int id)
        {
            listaSerie[id].Excluir();
        }

        public Serie GetById(int id)
        {
            return listaSerie[id];
        }

        public void Insert(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> List()
        {
            return listaSerie;
        }

        public int NextId()
        {
            return listaSerie.Count;
        }

        public void Update(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }
    }
}