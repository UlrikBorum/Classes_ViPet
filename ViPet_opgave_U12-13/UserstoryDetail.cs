using System;
using System.Collections.Generic;
using System.Text;

namespace ViPet_opgave_U12_13
{
	// We create a class called UserstoryDetail. This class has two instance fields, one for the description of the user story and one for a list of acceptance criteria. 
	public class UserstoryDetail
	{

		#region instance fields 
		private string _description;

		private List<AcceptanceCriteria> _acList;

		#endregion

		#region Constructor 

		// We also have a default constructor that sets the description to an empty string and initializes the list of acceptance criteria to an empty list.
		public UserstoryDetail()
		{
			_description = "";
			_acList = new List<AcceptanceCriteria>();
		}


		// We also have a constructor that takes a string parameter for the description and a list of acceptance criteria as parameters and sets the instance fields to those parameters.
		public UserstoryDetail(string description, List<AcceptanceCriteria> acList)
		{
			_description = description;
			_acList = acList;
		}

		#endregion

		#region properties 

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}

		public List<AcceptanceCriteria> AcList
		{
			get { return _acList; }
			set { _acList = value; }
		}

		#endregion

		#region methods
		
		// The method for listing all the acceptance criteria returns a new list of acceptance criteria that is a copy of the original list, so that the original list cannot be modified from outside the class.
		
		public List<AcceptanceCriteria> ListAll()
		{
			return new List<AcceptanceCriteria>(_acList);
		}

		#endregion
	}
}
