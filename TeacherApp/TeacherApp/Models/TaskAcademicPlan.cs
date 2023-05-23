using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherApp.Models
{
    public class TaskAcademicPlan
    {
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private string taskName;
		public string TaskName
		{
			get { return taskName; }
			set { taskName = value; }
		}

		private int resultPoints;
		public int ResultPoints
		{
			get { return resultPoints; }
			set { resultPoints = value; }
		}


		private int maxPoints;
		public int MaxPoints
		{
			get { return maxPoints; }
			set { maxPoints = value; }
		}

		public TaskAcademicPlan()
		{

		}

		public TaskAcademicPlan(int Id, string TaskName,int ResultPoints, int MaxPoints)
		{
			this.Id = Id;
			this.TaskName = TaskName;
			this.ResultPoints = ResultPoints;
			this.MaxPoints = MaxPoints;
		}

		public TaskAcademicPlan(string TaskName, int ResultPoints, int MaxPoints)
		{
            this.TaskName = TaskName;
            this.ResultPoints = ResultPoints;
            this.MaxPoints = MaxPoints;
        }
	}
}
