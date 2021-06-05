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
            throw new NotImplementedException();
        }

        public Serie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Serie entidade)
        {
            throw new NotImplementedException();
        }

        public List<Serie> List()
        {
            throw new NotImplementedException();
        }

        public int NextId()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Serie entidade)
        {
            throw new NotImplementedException();
        }
    }
}