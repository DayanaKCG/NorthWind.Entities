using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entities.ValueObjects
{
	public class UserAction(string usr, string descripcion)
	{
		public DateTime CreateDateTime { get; } = DateTime.Now;
		public string User => User;
		public string Descricion => Descricion;
	}
}
