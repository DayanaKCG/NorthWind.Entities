﻿using NorthWind.Entities.Interfaces;
using NorthWind.Entities.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Writers;

public class ConsoleWriter : IUserActionWriter
{
	public void Write(UserAction action)
	{
		Console.WriteLine("Console: {0}, {1}1 {2}",
			action.CreatedDateTime, action.User, action.Descrpition);
	}
}