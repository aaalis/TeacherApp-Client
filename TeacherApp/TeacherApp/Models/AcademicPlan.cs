using System;
using System.Collections.Generic;
using System.Text;

namespace TeacherApp.Models
{
    public class AcademicPlan
    {
		private int id;
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		private Discipline academicPlanDiscipline;
		public Discipline AcademicPlanDiscipline
        {
			get { return academicPlanDiscipline; }
			set { academicPlanDiscipline = value; }
		}


		private IEnumerable<TaskAcademicPlan> tasks;
		public IEnumerable<TaskAcademicPlan> Tasks
		{
			get { return tasks; }
			set { tasks = value; }
		}

		private int studentId;
		public int StudentId
		{
			get { return studentId; }
			set { studentId = value; }
		}

		public AcademicPlan()
		{

		}

		public AcademicPlan(int Id, Discipline AcademicPlanDiscipline, IEnumerable<TaskAcademicPlan> Tasks, int StudentId)
		{
			this.Id = Id;
			this.AcademicPlanDiscipline = AcademicPlanDiscipline;
			this.Tasks = Tasks;
			this.StudentId = StudentId;
		}
	}
}
