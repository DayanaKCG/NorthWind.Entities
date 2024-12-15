using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entities.Services
{
	internal class AppLogger(IUserActionWriter writer)
	{
		public void WritherLine(string message)
		{
			UserAction Log = new UserAction("System", message);
			writer.Writer(Log);
		}
	}
}
