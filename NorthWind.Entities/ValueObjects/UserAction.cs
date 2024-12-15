﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entities.ValueObjects
{
	public class UserAction(string user, string descrition)
	{
		public DateTime CreateDateTime { get; } = DateTime.Now;
		public string User => user;
		public string Descrition => descrition;
	}
}
