using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Infraestructures;

namespace Datos.Repositories
{
	public class PruebaDeConexion
	{
		public Boolean ProbarConexion()
		{
			try
			{
				using (var contexto = new equipo_c_dbEntities())
				{
					List<usuarios> productos = contexto.usuarios.ToList();
				}
				return true;
			} catch (Exception)
			{
				return false;
				throw;
			}
		}
	}
}
