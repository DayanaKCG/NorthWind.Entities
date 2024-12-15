﻿namespace NorthWind.Writers
{
	public class DebugWriter : IUserActionWriter
	{
		public void Write(UserAction action)
		{
			Debug.WriteLine("Console: {0}, {1}1 {2}",
			action.CreatedDateTime, action.User, action.Descrpition);
		}
	}
}
