using System;
using System.Collections.Generic;
using System.Text;

namespace ViPet_opgave_U12_13
{

	// We create a Class called AcceptanceCriteria. This class has a string field called Text. 
	public class AcceptanceCriteria
	{
		#region instance fields 
		private string _text;

		#endregion

		#region Constructor 
		// We also have a default constructor that sets the Text field to an empty string.
		public AcceptanceCriteria() 
		{
			_text = "";
		}
		
		//We also have a constructor that takes a string parameter and sets the Text field to that parameter.
		public AcceptanceCriteria (string text)
		{
			_text = text;
		}
		#endregion

		#region properties 
		//We also have a property for the Text field, which allows us to get and set the value of the Text field.
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
