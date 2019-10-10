using SchedulerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.DataAccess
{
    public interface IDataConnection
    {
        bool IsDbAvailable();

        void CreatePerson(PersonModel model);
        void CreateGroup(GroupModel model);
        void CreateRoom(RoomModel model);
        void CreateSubject(SubjectModel model/*, int ids*/);

        List<PersonModel> GetPerson(int id = -1, string fName = "", string lName = "", string identifeir = "");
        List<GroupModel> GetGroup(int id = -1, int subGrId = -1, string name= "", int year = -1);
        List<SubjectModel> GetSubjects(int id = -1, int grId = -1, string subName = "", bool forGroup = true);
        List<SubjectModel> GetSubjects4Group(int grId);
        List<RoomModel> GetRooms(int minSitsNo);
        List<RoomModel> GetRooms(string rNo, string wing);
        PersonModel GetTeacher(int perId);
        RoomModel GetRoom(int roomId = -1, int studNo = -1, int dayNo = -1, int hourNo = -1);
        PersonUnavDaysHours GetPersonUnav(int perId, int isLesson = 0);
        int[] GetCntOfSubgroups(int grId);
        List<GroupPlanInfoModel> GetPlansInfo(string name = "", int year = -1);
        List<LessonModel> GetPlan(int grId);
        List<KeyValuePair<PersonModel, int>> GetPeopleToPrintSummary(string fn = "",string ln = "",int id = -1, string identifeir = "");
        List<PlanModelForPerson> GetPlanForPerson(int perId = -1);
        List<int> GetSubjectsIdsForPerson(int perId);
        List<SubjectWithTeacherModel> GetSubjectsWithTeacher4Group(int grId = -1);
        List<int> GetGroups4Subject(int subId);
        void SetSetup();

        bool SaveSubsForGroup(int grId, List<SubjectModel> toUpdate, List<SubjectModel> toInsert, List<SubjectModel> toDelete);
        bool SavePersonUnav(List<PersonUnav> peoleUnav, int isLesson = 0);
        bool SavePersonUnav(List<List<int>> perHourIds, int isLesson = 0);
        bool SaveRoomUnav(List<List<int>> roomHourIds);
        bool SavePlan(List<LessonModel> lessons);
        string SaveSetup(string grPath, string pPath, int maxLessons);
        string UnlinkAndSaveSubsForGroup(int grId, List<SubjectWithTeacherModel> subsToLink);

        bool CheckPersonUnav(int perId, int dayNo, int hourNo);

        void ClearPlans();

        bool DeletePersonUnav(int perId);
        string DeletePlan(int grId);
        string UnlinkSubjects(int grId);
        void DeleteGroup(int grId);
        string DeletePerson(int perId);
        string DeleteSubjects(List<int> subsIds);
        string UnlinkGroupsFromSubject(int subId);
        string DeleteRoom(List<int> roomsIds);

        string PrepareSummary(int grId);

        string saveTestingData();
    }
}
