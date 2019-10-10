using SchedulerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary
{
    public class GeneratorLoop
    {
        public System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
        private List<List<LessonModel>> plans = new List<List<LessonModel>>();
        private List<LessonModel> lessons = new List<LessonModel>(); // List of all prepared lessons.
        private LessonModel lesson = new LessonModel(); // Current lesson
        private GroupModel group; // Current Group
        private SubgroupModel subgroup;
        private List<SubgroupModel> usedSubgroups = new List<SubgroupModel>();
        private List<SubjectModel> subjects; // All Subjects for Group
        private SubjectModel subject; // Subject that is currently processing
        private List<SubjectModel> notConfiguredSubjects = new List<SubjectModel>();
        private List<List<SubjectModel>> notConfiguredSubjectsByPlan = new List<List<SubjectModel>>();
                                      
        private List<RoomModel> rooms;
        private RoomModel room; // To keep room for current lesson and hour

        private List<PersonUnavDaysHours> teachersUnav = new List<PersonUnavDaysHours>(); // All  teachers assigned to subjects + theirs unav.
        private int _grId = 0;

        int attemptNo = 0;
        int maxSitsInRoom = -1;
        /* DAYS STAFF */
        private List<DayModel> daysDictionary;
        private DayHour lastUsedHour = new DayHour(-1, -1);
        //    private DayModel day;
        /* END DAYS STAFF */


        public void Init(int _grId)
        {
            stopWatch.Start();

            group = GlobalConfig.Connection.GetGroup(_grId)[0];
            group.SetGroupsCnt();
            SetUpLists();
            if (subjects.Count == 0)
                return;
        }

        private void SetUpLists()
        {
            subjects = GlobalConfig.Connection.GetSubjects4Group(_grId); // Get all subjects assigned to Group
            if (subjects.Count == 0)
                return;
            daysDictionary = PrepareDays(); // prepare array of days and hours

            teachersUnav = GetTeachersAndUnav(); // get "reserved" hours for tachers
            var minSitsNo = (int)Math.Ceiling((double)group.StudentsCnt / (group.ProjGrCnt < group.LabGrCnt ? group.ProjGrCnt : group.LabGrCnt));
            rooms = GlobalConfig.Connection.GetRooms(minSitsNo); // get all rooms that have more sits then smalest subgruop students
            if (rooms.Count > 0)
                maxSitsInRoom = rooms.Max(r => r.SitsCnt);
        }

        private void DoLoop()
        {
            subject = GetNextSubject();//  get 1st subject
            do
            {
                if (usedSubgroups.Count == GetMaxSlots()) // check if subject configured for all subgroups
                {
                    if (subjects.Count == 0)
                        break; // All subjects assigned
                    subject = GetNextSubject(); // take next subject
                }
                subgroup = GetNextSubgroup(); // take next subgroup eg. lab-2
                if (subject != null)
                {
                    lastUsedHour = GetNextTime(); // find next available hour represented as day number + hour number
                    SetUpLesson(); // save lesson
                }
            } while (subject != null); // do until all subject processed

            plans.Add(lessons); // add plan to list of plans
            lessons = new List<LessonModel>();
        }

     /*   public GeneratorLoop()
        {

        }
        */
        public GeneratorLoop(int _grId)
        {
            this._grId = _grId;
        }

        public string Start()
        {
            this.Init(_grId);
            if (GlobalConfig.Connection.GetPlan(group.Id).Count > 0)
            {
                return $"Plan dla {group.FullName} jest już skonfigurowany. {Environment.NewLine}Jeśli chcesz powtórzyć proces usuń plan dla tego kierunku w opcji \"Kierunki\"";
            }
            if (subjects.Count == 0)
                return $"Nie znaleziono przedmiotów dla {group.FullName}.";

            DoLoop();
            DoSearching(group.MaxLessonsPerDay);

            while (!CheckIfAnyPlanFullyFulfillConstrains() && GlobalData.MaxLessonsPerDay > group.MaxLessonsPerDay)
            { 
                DoSearching(++group.MaxLessonsPerDay);

                var time = stopWatch.ElapsedMilliseconds;
            }

            notConfiguredSubjectsByPlan.Add(notConfiguredSubjects);
            notConfiguredSubjects = new List<SubjectModel>();

            /*** END of searching **/

            PrepareDocument(); // before summary because there we choose the best plan.
            string summary = PrepareSummary(); // prepare summary for user
            stopWatch.Stop();
            return summary;
        }

        private void DoSearching(int maxLessons)
        {
            if (maxLessons > group.MaxLessonsPerDay)
            {
                group.MaxLessonsPerDay = maxLessons;
                DoConfigure("", "");
            }
            DoConfigure("reverse", "");
            DoConfigure("subType", "");
            DoConfigure("reversSubType", "");
            DoConfigure("2parts", "");
            DoConfigure("2parts", "reverse");
            DoConfigure("2parts", "subType");
            DoConfigure("2parts", "reversSubType");
            DoConfigure("alphabetically", "");
            DoConfigure("alphabetically", "reverse");
            DoConfigure("alphabetically", "subType");
            DoConfigure("alphabetically", "reversSubType");
            DoConfigure("alphabetically2", "");
            DoConfigure("alphabetically2", "reverse");
            DoConfigure("alphabetically2", "subType");
            DoConfigure("alphabetically2", "reversSubType");
            DoConfigure("tId", "");
            DoConfigure("tId", "reverse");
            DoConfigure("tId", "subType");
            DoConfigure("tId", "reversSubType");
            DoConfigure("tName", "");
            DoConfigure("tName", "reverse");
            DoConfigure("tName", "subType");
            DoConfigure("tName", "reversSubType");
            DoConfigure("id", "");
            DoConfigure("id", "reverse");
            DoConfigure("id", "subType");
            DoConfigure("id", "reversSubType");
        }

        private void DoConfigure(string sortMehod1, string sorthMethod2)
        {
            subject = null;
            notConfiguredSubjectsByPlan.Add(notConfiguredSubjects);
            notConfiguredSubjects = new List<SubjectModel>();
            SetUpLists();
            DoSortSubjects(sortMehod1, sorthMethod2);
            DoLoop();
        }

        private void DoSortSubjects(string sortMethod, string sortMethod2 = "")
        {
            switch (sortMethod)
            {
                case "subType":
                    subjects = subjects.OrderBy(s => s.Type).ToList();
                    break;
                case "reverse":
                    subjects.Reverse();
                    break;
                case "2parts":
                    switch (sortMethod2)
                    {
                        case "subType":
                            subjects = subjects.OrderBy(s => s.Type).ToList();
                            break;
                        case "reverse":
                            subjects.Reverse();
                            break;
                        case "reversSubType":
                            subjects.OrderBy(s => s.Type).ToList().Reverse();
                            break;
                        default:
                            break;
                    }
                    int subsCnt = subjects.Count; // the list will be divided into 2 parts to sotr in diffrent way
                    int half1Cnt = subsCnt / 2;
                    var halfSubs1 = new List<SubjectModel>();
                    var halfSubs2 = new List<SubjectModel>();
                    for (int i = 0; i < subsCnt; i++)
                    {
                        if (i < half1Cnt)
                        {
                            var value = subjects[i];
                            halfSubs1.Add(value);
                        }
                        else
                        {
                            var value = subjects[i];
                            halfSubs2.Add(value);
                        }
                    }
                    subjects = halfSubs2;
                    subjects.AddRange(halfSubs1);
                    break;
                case "alphabetically":
                    subjects.OrderBy(s => s.Name);
                    switch (sortMethod2)
                    {
                        case "subType":
                            subjects = subjects.OrderBy(s => s.Name).ThenBy(s => s.Type).ToList();
                            break;
                        case "reverse":
                            subjects.Reverse();
                            break;
                        case "reversSubType":
                            subjects.OrderBy(s => s.Name).ThenBy(s => s.Type).ToList().Reverse();
                            break;
                        default:
                            break;
                    }
                    break;
                case "alphabetically2":
                    subjects.OrderBy(s => s.FullName);
                    switch (sortMethod2)
                    {
                        case "subType":
                            subjects = subjects.OrderBy(s => s.FullName).ThenBy(s => s.Type).ToList();
                            break;
                        case "reverse":
                            subjects.Reverse();
                            break;
                        case "reversSubType":
                            subjects.OrderBy(s => s.FullName).ThenBy(s => s.Type).ToList().Reverse();
                            break;
                        default:
                            break;
                    }
                    break;
                case "tId":
                    subjects.OrderBy(s => s.TeacherId);
                    switch (sortMethod2)
                    {
                        case "subType":
                            subjects = subjects.OrderBy(s => s.TeacherId).ThenBy(s => s.Type).ToList();
                            break;
                        case "reverse":
                            subjects.Reverse();
                            break;
                        case "reversSubType":
                            subjects.OrderBy(s => s.TeacherId).ThenBy(s => s.Type).ToList().Reverse();
                            break;
                        default:
                            break;
                    }
                    break;
                case "tName":
                    subjects.OrderBy(s => s.TypeName);
                    switch (sortMethod2)
                    {
                        case "subType":
                            subjects = subjects.OrderBy(s => s.TypeName).ThenBy(s => s.Type).ToList();
                            break;
                        case "reverse":
                            subjects.Reverse();
                            break;
                        case "reversSubType":
                            subjects.OrderBy(s => s.TypeName).ThenBy(s => s.Type).ToList().Reverse();
                            break;
                        default:
                            break;
                    }
                    break;
                case "id":
                    subjects.OrderBy(s => s.Id);
                    switch (sortMethod2)
                    {
                        case "subType":
                            subjects = subjects.OrderBy(s => s.Id).ThenBy(s => s.Type).ToList();
                            break;
                        case "reverse":
                            subjects.Reverse();
                            break;
                        case "reversSubType":
                            subjects.OrderBy(s => s.Id).ThenBy(s => s.Type).ToList().Reverse();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    switch (sortMethod2)
                    {
                        case "subType":
                            subjects = subjects.OrderBy(s => s.Type).ToList();
                            break;
                        case "reverse":
                            subjects.Reverse();
                            break;
                        case "reversSubType":
                            subjects.OrderBy(s => s.Type).ToList().Reverse();
                            break;
                        default:
                            break;
                    }
                    break;
            }
        }

        private bool CheckIfAnyPlanFullyFulfillConstrains()
        {
            var ans = true;
            var tmpNotConfiguredSubsByPlan = new List<List<SubjectModel>>( notConfiguredSubjectsByPlan);
            tmpNotConfiguredSubsByPlan.Add(notConfiguredSubjects);
            ans = tmpNotConfiguredSubsByPlan.All(n => n.Count == 0); // chek if in all plans all subjects are configured

            if (ans)
            {
                foreach (var plan in plans) // check if there is any plan with all lessons with room
                {
                    if (plan.All(l => l.RoomId != 0))
                        return true; // plan with all subjets configuret and all lessons have assinged room.
                }
            }
            else
            {
                for (int i = 0; i < plans.Count; i++)
                {
                    if(tmpNotConfiguredSubsByPlan[i].Count == 0)
                    {
                        if (plans[i].All(l => l.RoomId != 0))
                            return true; // plan with all subjets configuret and all lessons have assinged room.
                    }
                }
            }
            return false; // there is no plans that fully fulfill constarains
        }


        private string PrepareSummary()
        {
            var _subjects = GlobalConfig.Connection.GetSubjects4Group(_grId); // Get all subjects assigned to Group

            string output = "";
            string notUsedSubjects = "";
            for (int i = 0; i < notConfiguredSubjects.Count; i++)
            {
                notUsedSubjects += string.Format(" {0}{1}. {2}",
                    Environment.NewLine, 
                    (i+1), 
                    notConfiguredSubjects[i].FullName/*,
                    group.Subgroups.First(s => notConfiguredSubjects[i].Type == s.Type && s.GrNo == (i+1)).Name*/
                    );
            }
            if (notUsedSubjects != "")
            {
                notUsedSubjects = group.FullName + Environment.NewLine + "Nieskonfigurowane przedmioty: " + notUsedSubjects;
            }

            string withNoRoom = "";
            var c = 0;
            foreach (var item in lessons)
            {
                if (item.RoomId <=0 )
                {
                    withNoRoom += string.Format(" {0}{1}. {2} - {3}, {4} - {5}",
                        Environment.NewLine,
                        ++c,
                        group.Subgroups.First(sg => sg.Id == item.GroupId).Name,
                        _subjects.First(s => s.Id == item.SubjectId).Name,
                        GlobalData.GetDayName(item.DayNo),
                        GlobalData.GetHourTime(item.HourNo)
                        );
                }
            }
            if (withNoRoom != "")
            {
                withNoRoom = group.FullName + Environment.NewLine + "Przedmioty bez sali: " + withNoRoom;
            }
            output = notUsedSubjects + Environment.NewLine + Environment.NewLine + withNoRoom;
            return output;
        }

        public void PrepareDocument()
        {
            var len = plans[0].Count; // get number of first plan lessons
            lessons = plans[0];
            if (notConfiguredSubjectsByPlan.Count > 0)
                notConfiguredSubjects = notConfiguredSubjectsByPlan[0];
            else
                notConfiguredSubjects = new List<SubjectModel>();
            var i = 0;

            int lessonsWithoutRoomCnt = lessons.Count(l => l.RoomId == 0);

            List<int> emptySlotsForPlan = new List<int>();
            foreach(var plan in plans)
            {
                emptySlotsForPlan.Add(CountEmptySlots(plan));
            }
            int emptySlots = emptySlotsForPlan[0];

            foreach (var plan in plans)
            {
                if (plan.Count > len) 
                { // founded plan with with the greates number of configured lessons.
                    lessonsWithoutRoomCnt = plan.Count(l => l.RoomId == 0);
                    len = plan.Count;
                    lessons = plan;
                    notConfiguredSubjects = notConfiguredSubjectsByPlan[i];
                    emptySlots = emptySlotsForPlan[i];
                }
                else if (plan.Count == len && (lessonsWithoutRoomCnt > plan.Count(l => l.RoomId == 0) || emptySlotsForPlan[i] < emptySlots))
                {
                    // founded plan with with equal number of configured lessons but less lessons have no room or ther is less empty slots.
                    lessonsWithoutRoomCnt = plan.Count(l => l.RoomId == 0);
                    len = plan.Count;
                    lessons = plan;
                    notConfiguredSubjects = notConfiguredSubjectsByPlan[i];
                    emptySlots = emptySlotsForPlan[i];
                }
                i++;
            } // if any condition in loop succeded first plan will be saved.
            
            GlobalConfig.Connection.SavePlan(lessons);
            CreateDocument();
        }

        private List<PersonUnavDaysHours> GetTeachersAndUnav()
        {
            var _teachersUnav = new List<PersonUnavDaysHours>();
            foreach (var _subject in subjects) // TODO - mb replace with one Query
            {
                //var _teacher = GlobalConfig.Connection.GetTeacher(_subject.Id);
                var _teacher = GlobalConfig.Connection.GetTeacher(_subject.TeacherId);
                if (_teacher != new PersonModel() && !(_teachersUnav.Exists(tu => tu.PerId == _teacher.Id)))
                {// if already downloaded do not add again
                    _teachersUnav.Add(GlobalConfig.Connection.GetPersonUnav(_teacher.Id, -1));
                }
            }
            return _teachersUnav;
        }

        /// <summary>
        /// Get subroup according to subject
        /// If subject is type of eg. 2 -> Ex get all subgroups with type of 2 (Exercise).
        /// </summary>
        
        private SubgroupModel GetNextSubgroup()
        {
            SubgroupModel _subgroup;
            var _subgroups = group.Subgroups;
            if (subject.Type == 1)
                _subgroup = _subgroups.First(s => s.Type == 1); // Lecture group should always be only one.
            else
            {
                if (usedSubgroups.Count == 0)
                {
                    if (subgroup != null)
                    {
                        _subgroup = _subgroups.First(s => s.Type == subject.Type && s.GrNo > subgroup.GrNo);
                    }
                    else
                    {
                        _subgroup = _subgroups.First(s => s.Type == subject.Type & s.GrNo == 1);
                    }
                }
                else
                {
                    _subgroup = _subgroups.Except(usedSubgroups).First(s => s.Type == subject.Type);
                }
            }
            return _subgroup;
        }

        /// <summary>
        /// Get next free time for lesson.
        /// </summary>
        /// <param name="includeUnreserved">If "true" include also hours not reserved for ex/lab/proj.</param>
        /// <returns></returns>
        private DayHour GetNextTime(bool includeUnreserved = false)
        {
            DayHour output;// = new KeyValuePair<int, int>(-1,-1);
            DayModel tmpDay = new DayModel();
            int tmpHour = -1;
            int slotsMax = GetMaxSlots(); 
            PersonUnavDaysHours currentTeacherUnav = teachersUnav.First(t => t.PerId == subject.TeacherId);
            room = new RoomModel();
            RoomModel _room = null;
            attemptNo++;
            int tolerance = 0;

            do
            {
                tolerance += 15;
                foreach (var day in daysDictionary) // loop in days
                {
                    if (!CanNextLessonBeAdded(day, group.MaxLessonsPerDay)) // check if adding new lesson will not breake requirments
                        continue; // skip to next day
                    foreach (var hour in day.Hours) // loop in day's hours
                    {
                        if (hour.SlotsMax == slotsMax // check if hours is divided for slots according to current subgroup type
                            && hour.SlotsReserved[subgroup.GrNo - 1] == 0 // check if slot for this subgroup is not reserved
                            && !(currentTeacherUnav.DayAndHour.Exists(
                                th => th.dayNo == day.DayNo && th.hourNo == hour.HourNo)) //check if teacher is not blocked
                        )
                        {
                            _room = GetRoom(day.DayNo, hour.HourNo, tolerance); // get room if fulfill conditions
                            if (_room != null)
                            { // save found resources
                                room = _room;
                                tmpDay = day;
                                tmpHour = hour.HourNo;
                                break;
                            }
                        }
                    }
                    if (tmpHour != -1 && _room != null) // do not take next day if correct time was found
                        break;
                }


                // search again if time not found - do not include reserved slots
                if (tmpHour == -1 && _room == null) // 
                {
                    foreach (var day in daysDictionary)
                    {
                        if (!CanNextLessonBeAdded(day, group.MaxLessonsPerDay))
                            continue;
                        foreach (var hour in day.Hours)
                        {
                            if (hour.SlotsMax == 0
                                && !(currentTeacherUnav.DayAndHour.Exists(th => th.dayNo == day.DayNo && th.hourNo == hour.HourNo))
                                )
                            {
                                _room = GetRoom(day.DayNo, hour.HourNo, tolerance);
                                if (_room != null)
                                {
                                    room = _room;
                                    tmpDay = day;
                                    tmpHour = hour.HourNo;
                                    break;
                                }
                            }
                        }
                        if (tmpHour != -1 && _room != null) // do not take next day if correct time was found
                            break;
                    }
                }//////
            } while (_room == null && maxSitsInRoom >= (subgroup.StudentsCnt + tolerance));

             /******************************  No Room included **********************************/
            if (_room == null) //in case no available room was found.
            {
                foreach (var day in daysDictionary)
                {
                    if (!CanNextLessonBeAdded(day, group.MaxLessonsPerDay)) // do not allow to add more then 6 lesson per day for specyfic subgroup
                        continue;
                    foreach (var hour in day.Hours)
                    {
                        if (hour.SlotsMax == slotsMax
                            && hour.SlotsReserved[subgroup.GrNo - 1] == 0
                            && !(currentTeacherUnav.DayAndHour.Exists(th => th.dayNo == day.DayNo && th.hourNo == hour.HourNo))
                        )
                        {
                            tmpDay = day;
                            tmpHour = hour.HourNo;
                            break;
                        }
                    }
                    if (tmpHour != -1) // do not take next day if correct time was found
                        break;
                }

                if (tmpHour == -1) // now we don't include reserved slots
                {
                    foreach (var day in daysDictionary)
                    {
                        if (!CanNextLessonBeAdded(day, group.MaxLessonsPerDay)) // do not allow to add more then 6 lesson per day for specyfic subgroup
                            continue;
                        foreach (var hour in day.Hours)
                        {
                            if (hour.SlotsMax == 0
                                && !(currentTeacherUnav.DayAndHour.Exists(th => th.dayNo == day.DayNo && th.hourNo == hour.HourNo))
                                )
                            {
                                tmpDay = day;
                                tmpHour = hour.HourNo;
                                break;
                            }
                        }
                        if (tmpHour != -1) // do not take next day if correct time was found
                            break;
                    }
                }
            }

            output = new DayHour(tmpDay.DayNo, tmpHour);

            return output;
        }

        private bool CanNextLessonBeAdded(DayModel day, int maxLessons = 6)
        {
            int lessonsCnt = 0;
            var grNo = subgroup.GrNo;
            var type = subgroup.Type;
            var start = subgroup.StudentsCnt * (subgroup.GrNo-1);
            var stop = subgroup.StudentsCnt * subgroup.GrNo;

            int exStart, labStart, projStart, exStop, labStop, projStop;
            exStart = labStart = projStart = exStop = labStop = projStop = 0;

            var _Subgroups = group.Subgroups.Where(s => s.Type == 2).ToList(); // get subroups->excercise
            for (int i = 0; i < group.ExGrCnt; i++)
            {
                if (start >= i * _Subgroups[0].StudentsCnt && start < (i + 1) * _Subgroups[0].StudentsCnt)
                {
                    exStart = i;
                }
                if (stop <= (i + 1) * _Subgroups[i].StudentsCnt || i == group.ExGrCnt - 1)
                {
                    exStop = i;
                    break;
                }
            }

            _Subgroups = group.Subgroups.Where(s => s.Type == 3).ToList(); // get subroups->lab
            for (int i = 0; i < group.LabGrCnt; i++)
            {
                if (start >= i * _Subgroups[0].StudentsCnt && start < (i + 1) * _Subgroups[0].StudentsCnt)
                    labStart = i;
                if (stop <= (i + 1) * _Subgroups[i].StudentsCnt || i == group.LabGrCnt - 1)
                {
                    labStop = i;
                    break;
                }
            }

            _Subgroups = group.Subgroups.Where(s => s.Type == 4).ToList(); // get subroups->proj
            for (int i = 0; i < group.ProjGrCnt; i++)
            {
                if (start >= i * _Subgroups[0].StudentsCnt && start < (i + 1) * _Subgroups[0].StudentsCnt)
                    projStart = i;
                if (stop <= (i + 1) * _Subgroups[i].StudentsCnt || i == group.ProjGrCnt - 1)
                {
                    projStop = i;
                    break;
                }
            }

            foreach (HourModel hour in day.Hours)
            {
                if (lessonsCnt >= 6)
                    return false; // cannot assign more lessons to this day.
                if (hour.SlotsMax < 1)
                    continue; // no slots -> no lessons
                if (hour.SlotsMax == 1 && hour.SlotsReserved[0] == 1 )
                {
                    lessonsCnt++;
                    continue;
                }


                if (hour.SlotsMax == group.ExGrCnt)
                {
                    for (int i = exStart; i <= exStop; i++)
                    {
                        if (hour.SlotsReserved[i] == 1)
                        {
                            lessonsCnt++;
                            break;
                        }
                    }
                }
                else if (hour.SlotsMax == group.LabGrCnt)
                {
                    for (int i = labStart; i <= labStop; i++)
                    {
                        if (hour.SlotsReserved[i] == 1)
                        {
                            lessonsCnt++;
                            break;
                        }
                    }
                }
                else if (hour.SlotsMax == group.ProjGrCnt)
                {
                    for (int i = projStart; i <= projStop; i++)
                    {
                        if (hour.SlotsReserved[i] == 1)
                        {
                            lessonsCnt++;
                            break;
                        }
                    }
                }


            }

            return !(lessonsCnt >= maxLessons);
        }


        /// <summary>
        /// Return number of slots for this group for specific subject type
        /// </summary>
        /// <returns></returns>
        private int GetMaxSlots()
        {
            int _maxSlots = -1;

            switch (subject.Type)
            {
                case 1:
                    _maxSlots = 1; // lecture
                    break;
                case 2:
                    _maxSlots = group.ExGrCnt;
                    break;
                case 3:
                    _maxSlots = group.LabGrCnt;
                    break;
                case 4:
                    _maxSlots = group.ProjGrCnt;
                    break;
                default:
                    throw new Exception(); // TODO - 
                                           //    break;
            }
            return _maxSlots;
        }

        /// <summary>
        /// Get next not assigned subject.
        /// </summary>
        /// <returns></returns>
        private SubjectModel GetNextSubject()
        {
            SubjectModel _subject;
            if (subjects.Count > 0)
            {
                _subject = subjects.First();
                usedSubgroups = new List<SubgroupModel>(); // it is cleared here because it is used for every subject
            }
            else
            {
                return null;
            }
            return _subject;
        }

        /// <summary>
        /// Get the smalest free room that can hold group.
        /// </summary>
        /// <returns></returns>
        private RoomModel GetRoom(int dayNo, int hourNo, int tolerance = 250)
        {
            //RoomModel room1 = GlobalConfig.Connection.GetRoom(subgroup.StudentsCnt, lastUsedHour.dayNo, lastUsedHour.hourNo);
            if (rooms.Count == 0)
                return null;
            var _rooms = (from r in rooms
                          where r.DayAndHour.Exists(dh => dh.dayNo == dayNo && dh.hourNo == hourNo) == false
                               && r.SitsCnt >= subgroup.StudentsCnt
                               && r.SitsCnt <= (subgroup.StudentsCnt + tolerance)
                          orderby r.SitsCnt
                          select r); 
            if (_rooms.Count() > 0)
            {
                return _rooms.First();
            }
            return null;
        }

        /// <summary>
        /// Assign prepared values to lesson.
        /// </summary>
        private void SetUpLesson()
        {
            if (subject != null && lastUsedHour.hourNo >= 0)
            {
                lesson.GroupId = subgroup.Id;
                lesson.SubjectId = subject.Id;
                lesson.TeacherId = subject.TeacherId;//teacher.Id;
                lesson.RoomId = room.Id;
                //lesson.LessonDayId = hour;




                // Here we are set how much subgroups can have classes in specific hour if not set yet
                if (daysDictionary[lastUsedHour.dayNo].Hours[lastUsedHour.hourNo].SlotsMax < 1 && subject.Type == 1)
                {
                    daysDictionary[lastUsedHour.dayNo].Hours[lastUsedHour.hourNo].SlotsMax = 1;
                }
                else if (daysDictionary[lastUsedHour.dayNo].Hours[lastUsedHour.hourNo].SlotsMax < 1 && subject.Type == 2)
                {
                    daysDictionary[lastUsedHour.dayNo].Hours[lastUsedHour.hourNo].SlotsMax = group.ExGrCnt;
                }
                else if (daysDictionary[lastUsedHour.dayNo].Hours[lastUsedHour.hourNo].SlotsMax < 1 && subject.Type == 3)
                {
                    daysDictionary[lastUsedHour.dayNo].Hours[lastUsedHour.hourNo].SlotsMax = group.LabGrCnt;
                }
                else if (daysDictionary[lastUsedHour.dayNo].Hours[lastUsedHour.hourNo].SlotsMax < 1 && subject.Type == 4)
                {
                    daysDictionary[lastUsedHour.dayNo].Hours[lastUsedHour.hourNo].SlotsMax = group.ProjGrCnt;
                }
                //set 1 - as reserved slot
                daysDictionary[lastUsedHour.dayNo].Hours[lastUsedHour.hourNo].SlotsReserved[subgroup.GrNo - 1] = 1; 

                //lesson.Day = daysDictionary[lastUsedHour.Key];
                lesson.DayNo = lastUsedHour.dayNo;
                lesson.SlotNo = subgroup.GrNo - 1;
                lesson.HourNo = lastUsedHour.hourNo;

                lessons.Add(lesson); // Add lesson configured

                usedSubgroups.Add(subgroup);

                teachersUnav.First(t => t.PerId == subject.TeacherId).DayAndHour.Add(lastUsedHour);
                if (room.Id >0 )
                    rooms.First(r => r.Id == room.Id).DayAndHour.Add(lastUsedHour);

                ClearFields();
            }
            else
            {
                notConfiguredSubjects.Add(subject);
                //usedSubgroups = group.Subgroups.Where(s => s.Type == subject.Type).ToList();
                usedSubgroups.Add(subgroup); // we add only current to check if other subgroups can be setup
                ClearFields();
            }
        }

        private void ClearFields()
        {
            attemptNo = 0;
            lesson = new LessonModel();
            subjects.Remove(subject);
            room = new RoomModel();
            subgroup = new SubgroupModel();
        }

        private List<DayModel> PrepareDays()
        {
            List<DayModel> days = new List<DayModel>();

            for (int i = 0; i < 5; i++)
            {
                var day = new DayModel();
                day.DayNo = i;
                for (int j = 0; j < 7/*GlobalData.hoursInDay*/; j++)
                {
                    day.Hours.Add(new HourModel(j, 0));
                }
                days.Add(day);
            }
            return days;
        }

        private void CreateDocument()
        {
            Logic.Print.CreateDocument(lessons);
        }

        private int CountEmptySlots(List<LessonModel> plan)
        {
            int slots = 0;            

            int x = (group.ExGrCnt > group.LabGrCnt ? group.ExGrCnt : group.LabGrCnt);
            int maxGroups = x > group.ProjGrCnt ? x : group.ProjGrCnt;
            //for(int i = 0; i < 5; i++) // days
            //{
            //    int j = 1, dStart = 0;
            //    List<LessonModel> dayLessons = plan.Where(p => p.DayNo == i).ToList();
            //    if (dayLessons.Count > 0)
            //        dStart = j = dayLessons.Min(dl => dl.HourNo);
            //    bool start = false;
            //    for (/*int j = 0*/; j < 7; j++) // hours
            //    {
            //        if ( group.Subgroups.First(sg => sg.Id == (dayLessons.First(p => p.HourNo == j).GroupId)).Type == 1)
            //            start = true;
            //        for (int k = 1; k <= maxGroups; k++)
            //        {
            //            if(!start)
            //                if()
            //            List<LessonModel> prevL2 = plan.Where(p => p.DayNo == i && p.HourNo == (j - 2)).ToList();
            //            List<LessonModel> prevL = plan.Where(p => p.DayNo == i && p.HourNo == (j - 1)).ToList();
            //            List<LessonModel> L = plan.Where(p => p.DayNo == i && p.HourNo == (j)).ToList();
            //            if ()
            //        }
            //    }
            //}
            
            return slots;
        }
    }
}
