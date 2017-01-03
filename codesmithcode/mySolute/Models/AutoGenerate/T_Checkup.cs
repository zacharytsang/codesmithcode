//============================================================
// Producnt name:		Models
// Version: 			7.0
// Coded by:			tjh
// Auto generated at: 	2016/12/20 14:30:26
//============================================================

using System;
using System.Collections.Generic;
using System.Text;
namespace Models
{
	
	[Serializable()]
	public partial class T_Checkup
	{
	    #region private field
		
			private int id;
			private Nullable<int> investigate_id;
			private string off_grades;
			private string rank_scores;
			private string anti_seismics;
			private string repairables;
			private string checkup_suggestions;
			private string evaluate_suggestions;
			private string solutions;
			private string remakes;
			private string create_user;
			private Nullable<DateTime> create_time;
			private string update_user;
			private Nullable<DateTime> update_time;
			private Nullable<bool> status;
			private string checkup_category;

        #endregion

        #region constructor public T_Checkups() {}

        #endregion

        #region public property

			public int Id {
				get { return id; }
				set { id = value; }
			}
			
			public Nullable<int> Investigate_id {
				get { return investigate_id; }
				set { investigate_id = value; }
			}
			
			public string Off_grades {
				get { return off_grades; }
				set { off_grades = value; }
			}
			
			public string Rank_scores {
				get { return rank_scores; }
				set { rank_scores = value; }
			}
			
			public string Anti_seismics {
				get { return anti_seismics; }
				set { anti_seismics = value; }
			}
			
			public string Repairables {
				get { return repairables; }
				set { repairables = value; }
			}
			
			public string Checkup_suggestions {
				get { return checkup_suggestions; }
				set { checkup_suggestions = value; }
			}
			
			public string Evaluate_suggestions {
				get { return evaluate_suggestions; }
				set { evaluate_suggestions = value; }
			}
			
			public string Solutions {
				get { return solutions; }
				set { solutions = value; }
			}
			
			public string Remakes {
				get { return remakes; }
				set { remakes = value; }
			}
			
			public string Create_user {
				get { return create_user; }
				set { create_user = value; }
			}
			
			public Nullable<DateTime> Create_time {
				get { return create_time; }
				set { create_time = value; }
			}
			
			public string Update_user {
				get { return update_user; }
				set { update_user = value; }
			}
			
			public Nullable<DateTime> Update_time {
				get { return update_time; }
				set { update_time = value; }
			}
			
			public Nullable<bool> Status {
				get { return status; }
				set { status = value; }
			}
			
			public string Checkup_category {
				get { return checkup_category; }
				set { checkup_category = value; }
			}
			
			
        #endregion

	}
}

