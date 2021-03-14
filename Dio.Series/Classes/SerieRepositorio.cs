using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
		private List<Serie> _listaSerie = new List<Serie>();
		public void Atualiza(int id, Serie objeto)
		{
			_listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			_listaSerie[id].Excluir();
		}

		public void Insere(Serie objeto)
		{
			_listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return _listaSerie;
		}

		public int ProximoId()
		{
			return _listaSerie.Count;
		}

		public Serie RetornaPorId(int id)
		{
			return _listaSerie[id];
		}
	}
}