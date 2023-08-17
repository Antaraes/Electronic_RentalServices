﻿
using System;

namespace RentalService
{
	/// <summary>
	/// Description of Admin.
	/// </summary>
	public class Admin: Person
	{
		String role="";
		
		public Admin() //Constuctor function
		{
			role = "Administrator";
		}
		
		public override Boolean Login(string name, string pass)
		{
			if (name=="admin" && pass=="pass")  
				return true;
			else return false;
			
		}
	}
}
