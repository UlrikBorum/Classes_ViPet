using System;
using System.Collections.Generic;
using System.Text;

namespace ViPet_opgave_U12_13
{
	public class AcceptanceCriteria
	{
		#region instance fields 
		private string _text;

		#endregion

		#region Constructor 
		public AcceptanceCriteria() 
		{
			_text = "";
		}

		public AcceptanceCriteria (string text)
		{
			_text = text;
		}
		

		#endregion

		#region properties 
		public string Text 
		{ 
			get { return _text; } 
			set { _text = value; }
		}

		#endregion

		#region methods


		#endregion

	}
}
