using System;
using System.Collections.Generic;
using System.Text;

namespace ViPet_opgave_U12_13
{
	public class UserstoryDetail
	{

		#region instance fields 
		private string _description;

		private List<AcceptanceCriteria> _acList;

		#endregion

		#region Constructor 

		public UserstoryDetail()
		{
			_description = "";
			_acList = new List<AcceptanceCriteria>();
		}

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


		#endregion
	}
}
