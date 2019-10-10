using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulerLibrary.Models;
using System.Data;
using System.Data.SqlClient;

namespace SchedulerLibrary.DataAccess
{
    public class SqlDbConnector// : IDataConnection
    {
        private const string db = "LessonsScheduler";

        public string CnnString { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

       /* public void AddTeacherToSubject(int perId, int subId)
        {
            throw new NotImplementedException();
        }

        public bool CheckPersonUnav(int perId, int dahId, int hourNo)
        {
            throw new NotImplementedException();
        }

        public void ClearPlans()
        {
            throw new NotImplementedException();
        }

        public void CreateGroup(GroupModel model)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString))
            {
                SqlCommand query = connection.CreateCommand();
                query.CommandText = "INSERT INTO Group VALUES ('" + model.Name+"', "+model.Year+", "+model.StudentsCnt+")";

                connection.Open();
                query.ExecuteNonQuery();
                query.Dispose();
                connection.Close();
            }
        }

        public void CreateLesson(LessonModel model)
        {
            throw new NotImplementedException();
        }

        public void CreatePerson(PersonModel model)
        {
            using (SqlConnection connection = new SqlConnection(GlobalConfig.CnnString))
            {
                try
                {
                    connection.Open();
                    SqlCommand query = connection.CreateCommand();
                    query.CommandText = "INSERT INTO [LessonsScheduler].[dbo].[Person] VALUES ('" + model.FirstName + "', '" + model.LastName + "', '" + model.Degree + "', "+model.Identifier+" )";
                    query.ExecuteNonQuery();
                    query.Dispose();
                    connection.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public void CreateRoom(RoomModel model)
        {
            throw new NotImplementedException();
        }

        public void CreateSubject(SubjectModel model, List<int> ids)
        {
            throw new NotImplementedException();
        }

        public void CreateSubject(SubjectModel model, int ids)
        {
            throw new NotImplementedException();
        }

        public bool DeletePersonUnav(List<PersonUnav> peopleUnav)
        {
            throw new NotImplementedException();
        }

        public bool DeletePersonUnav(int perId)
        {
            throw new NotImplementedException();
        }

        public int[] GetCntOfSubgroups(int grId)
        {
            throw new NotImplementedException();
        }

        public List<DayModelX> GetDays(int grId = -1)
        {
            throw new NotImplementedException();
        }

        public List<int> GetDaysIds()
        {
            throw new NotImplementedException();
        }

        public List<GroupModel> GetGroup(int id, int subGrId, string name, int year)
        {
            throw new NotImplementedException();
        }

        public List<HourModelX> GetHours(int grId = -1)
        {
            throw new NotImplementedException();
        }

        public List<int> GetHoursIds(int grId = -1)
        {
            throw new NotImplementedException();
        }

        public List<KeyValuePair<PersonModel, int>> GetPeopleToPrintSummary(string fn = "", string ln = "", int id = -1)
        {
            throw new NotImplementedException();
        }

        public List<KeyValuePair<PersonModel, int>> GetPeopleToPrintSummary(string fn = "", string ln = "", int id = -1, string identifeir = "")
        {
            throw new NotImplementedException();
        }

        public List<PersonModel> GetPerson(int id = -1, string fName = "", string lName = "", string identifeir = "")
        {
            throw new NotImplementedException();
        }

        public PersonUnavDaysHours GetPersonUnav(int perId, int isLesson = 0)
        {
            throw new NotImplementedException();
        }

        public List<LessonModel> GetPlan(int grId)
        {
            throw new NotImplementedException();
        }

        public List<PlanModelForPerson> GetPlanForPerson(int perId = -1)
        {
            throw new NotImplementedException();
        }

        public List<LessonModel> GetPlans(int[] grIds)
        {
            throw new NotImplementedException();
        }

        public List<LessonModel> GetPlans(int grId)
        {
            throw new NotImplementedException();
        }

        public List<PlanInfoModel> GetPlansInfo()
        {
            throw new NotImplementedException();
        }

        public List<PlanInfoModel> GetPlansInfo(string name = "", int year = -1)
        {
            throw new NotImplementedException();
        }

        public RoomModel GetRoom(int studNo, int dayNo = -1, int hourNo = -1)
        {
            throw new NotImplementedException();
        }

        public RoomModel GetRoom(int roomId = -1, int studNo = -1, int dayNo = -1, int hourNo = -1)
        {
            throw new NotImplementedException();
        }

        public List<RoomModel> GetRooms(int minSitsNo)
        {
            throw new NotImplementedException();
        }

        public List<SubjectModel> GetSubjects(int id = -1, int grId = -1, string subName = "", bool forGroup = true)
        {
            throw new NotImplementedException();
        }

        public PersonModel GetTeacher(int subId)
        {
            throw new NotImplementedException();
        }

        public bool SavePersonUnav(List<PersonUnav> peoleUnav)
        {
            throw new NotImplementedException();
        }

        public bool SavePersonUnav(List<List<int>> perHourIds, int isLesson = 0)
        {
            throw new NotImplementedException();
        }

        public bool SavePersonUnav(List<PersonUnav> peoleUnav, int isLesson = 0)
        {
            throw new NotImplementedException();
        }

        public bool SavePlan(List<LessonModel> lessons)
        {
            throw new NotImplementedException();
        }

        public bool SaveRoomUnav(List<List<int>> roomHourIds)
        {
            throw new NotImplementedException();
        }

        public bool SaveSubsForGroup(int grId, List<SubjectModel> toUpdate, List<SubjectModel> toInsert, List<SubjectModel> toDelete)
        {
            throw new NotImplementedException();
        }

        List<PersonModel> IDataConnection.GetPerson(int id, string fName, string lName, string identifeir)
        {
            throw new NotImplementedException();
        }*/
    }
}
