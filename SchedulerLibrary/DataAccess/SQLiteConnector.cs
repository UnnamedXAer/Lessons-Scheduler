using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulerLibrary.Models;
using System.Data.SQLite;
using System.IO;

namespace SchedulerLibrary.DataAccess
{
    class SQLiteConnector : IDataConnection
    {
        public void CreateGroup(GroupModel model)
        {
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                string maxLessons;
                if (model.MaxLessonsPerDay == 0)
                    maxLessons = " (SELECT (case when max(setMaxLessonsPerDay) is null then 6 else max(setMaxLessonsPerDay) end) FROM [Setup] )";
                else
                    maxLessons = model.MaxLessonsPerDay.ToString();
                SQLiteCommand query = connection.CreateCommand();
                query.CommandText = "INSERT INTO [Group] VALUES (null, '" + model.Name + "', " + model.Year + ", " + model.StudentsCnt + ", "+ maxLessons +")";

                connection.Open();
                query.ExecuteNonQuery();
                Int64 lastRow = connection.LastInsertRowId;
                //setup wyk group.
                query.CommandText = "INSERT INTO GroupsOfGroup VALUES (null, " + lastRow + ", " + 1 + ", " + model.StudentsCnt + ", 'Wyk.', 1)";
                query.ExecuteNonQuery();

                //setup exerc. groups.
                int studNo = (int)Math.Ceiling(((double)model.StudentsCnt / model.ExGrCnt));
                for (int i = 0; i < model.ExGrCnt; i++)
                {
                    query.CommandText = "INSERT INTO [GroupsOfGroup] VALUES (null, " + lastRow + ", " + 2 + ", " + studNo + ", 'Ćw. " + (i + 1) + "', " + (i + 1) + ")";
                    query.ExecuteNonQuery();
                }

                //setup lab groups.
                studNo = (int)Math.Ceiling((double)((double)model.StudentsCnt / model.LabGrCnt));
                for (int i = 0; i < model.LabGrCnt; i++)
                {
                    query.CommandText = "INSERT INTO GroupsOfGroup VALUES (null, " + lastRow + ", " + 3 + ", " + studNo + ", 'Lab. " + (i + 1) + "', " + (i + 1) + ")";
                    query.ExecuteNonQuery();
                }

                if (model.ProjGrCnt != 0)
                {
                    studNo = (int)Math.Ceiling((double)((double)model.StudentsCnt / model.ProjGrCnt));
                    for (int i = 0; i < model.ProjGrCnt; i++)
                    {
                        query.CommandText = "INSERT INTO GroupsOfGroup VALUES (null, " + lastRow + ", " + 4 + ", " + studNo + ", 'Proj. " + (i + 1) + "', " + (i + 1) + ")";
                        query.ExecuteNonQuery();
                    }
                }


                query.Dispose();
                connection.Close();
            }
        }

        public void CreatePerson(PersonModel model)
        {
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                SQLiteCommand query = connection.CreateCommand();
                query.CommandText = "INSERT INTO [Person] VALUES (null, '" + model.FirstName + "', '" + model.LastName + "', '" + model.Degree + "', '" + model.Identifier + "')";

                connection.Open();
                query.ExecuteNonQuery();
                //Int64 lastRow = connection.LastInsertRowId;

                query.Dispose();
                connection.Close();

            }
        }

        public void CreateRoom(RoomModel model)
        {
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                SQLiteCommand query = connection.CreateCommand();
                query.CommandText = "INSERT INTO [Room] VALUES (null, '" + model.RoomNo + "', '" + model.Wing + "', " + model.SitsCnt + ")";

                connection.Open();
                query.ExecuteNonQuery();
                //Int64 lastRow = connection.LastInsertRowId;

                query.Dispose();
                connection.Close();

            }
        }

        public void CreateSubject(SubjectModel model/*, int personId*/)
        {
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                SQLiteCommand command;
                string query = "INSERT INTO [Subject](subName, subHoursNo, subType, subColor) VALUES ( '" +
                    model.Name + "', " +
                    ((model.HoursInSemesterCnt == 0) ? 30 : model.HoursInSemesterCnt) + ", " +
                    model.Type + ", '" +
                    model.CellColor + "');";

                connection.Open();
                using (command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                    //Int64 lastRow = connection.LastInsertRowId;
                    //GlobalConfig.Connection.AddTeacherToSubject(personId, (int)lastRow);
                }

                connection.Close();
            }
        }

        public List<GroupModel> GetGroup(int id = -1, int subGrId = -1, string name = "", int year = -1)
        {
            List<GroupModel> groups = new List<GroupModel>();
            SQLiteDataReader dataReader;

            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                SQLiteCommand command;
                string query = "SELECT grId, grName, grYear, grStudNo, grMaxLessonsPerDay FROM [Group] ";

                if (id != -1)
                    query += "WHERE Grid = " + id;
                else if (subGrId != -1)
                {
                    query += " WHERE grId = (SELECT gogGrId FROM GroupsOfGroup WHERE gogId = " + subGrId + " ) ";
                }
                else
                {
                    if (name != "")
                    {
                        query += "WHERE UPPER(grName) LIKE UPPER('" + name + "%') ";
                    }
                    if (year != -1)
                    {
                        if (name != "")
                            query += " AND ";
                        else
                            query += " WHERE ";
                        query += " grYear = " + year + " ";
                    }

                }
                query += " ORDER BY grName, grYear";

                connection.Open();
                using (command = new SQLiteCommand(query, connection))
                {
                    using (dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var group = new GroupModel(
                                    int.Parse(dataReader["grId"].ToString()),
                                    dataReader["grName"].ToString(),
                                    int.Parse(dataReader["grYear"].ToString()),
                                    int.Parse(dataReader["grStudNo"].ToString()),
                                    int.Parse(dataReader["grMaxLessonsPerDay"].ToString())
                                );

                                var gogQuery = "SELECT * FROM GroupsOfGroup WHERE gogGrId = " + group.Id + " ORDER BY gogType;";
                                using (var subCommand = new SQLiteCommand(gogQuery, connection))
                                {
                                    using (SQLiteDataReader subDReader = subCommand.ExecuteReader())
                                    {
                                        if (subDReader.HasRows)
                                        {
                                            while (subDReader.Read())
                                            {
                                                var subgroup = new SubgroupModel(
                                                            int.Parse(subDReader["gogId"].ToString()),
                                                                      subDReader["gogName"].ToString(),
                                                            int.Parse(subDReader["gogType"].ToString()),
                                                            int.Parse(subDReader["gogStudNo"].ToString()),
                                                            int.Parse(subDReader["gogGroupNo"].ToString())
                                                        );
                                                group.Subgroups.Add(
                                                    subgroup
                                                    );
                                            }
                                        }
                                    }
                                }

                                groups.Add(group);
                            }
                        }
                    }
                }
                connection.Close();
            }

            return groups;
        }

        public List<PersonModel> GetPerson(int id = -1, string fName = "", string lName = "", string identifeir = "")
        {
            List<PersonModel> people = new List<PersonModel>();
            SQLiteDataReader dataReader;

            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                SQLiteCommand command;
                string query = "SELECT * FROM person ";

                if (id != -1)
                    query += " where perid = " + id;
                else
                {
                    if (fName != "")
                    {
                        query += "where upper(perFirstName) like upper('" + fName + "%') ";
                    }
                    if (lName != "")
                    {
                        if (fName != "")
                            query += " and ";
                        else
                            query += " where ";
                        query += " upper(perLastName) like upper('" + lName + "%') ";
                    }

                    if (identifeir != "")
                    {
                        if (fName != "" || lName != "")
                            query += " and ";
                        else
                            query += " where ";
                        query += $" upper(perIdentifier) like upper('{identifeir}%') ";
                    }

                }
                query += " order by perLastName, perFirstName, perDegree;";

                connection.Open();
                using (command = new SQLiteCommand(query, connection))
                {
                    using (dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                people.Add(new PersonModel(
                                    int.Parse(dataReader["perId"].ToString()),
                                    dataReader["perFirstName"].ToString(),
                                    dataReader["perLastName"].ToString(),
                                    dataReader["perDegree"].ToString(),
                                    dataReader["perIdentifier"].ToString())
                                    );
                            }
                        }
                    }
                }
                connection.Close();
            }

            return people;
        }

        public List<SubjectModel> GetSubjects(int id = -1, int grId = -1, string subName = "", bool forGroup = true)
        {
            List<SubjectModel> subjects = new List<SubjectModel>();
            SQLiteDataReader dataReader;

            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                SQLiteCommand command;
                //string query = "SELECT s.*, st.stPerId FROM Subject s JOIN SubjectTeachers st on st.stSubId = s.subId ";
                string query = "SELECT s.* FROM Subject s  ";
                string where = "";
                if (id != -1) // TODO - Check if this work!!!!
                    query += "WHERE s.subId = " + id;
                else
                {
                    if (subName != "")
                    {
                        where = "WHERE UPPER(s.subName) LIKE UPPER('" + subName + "%') ";
                    }
                }
                if (grId != -1)
                {
                    if (where != "")
                    {
                        where += " AND ";
                    }
                    else
                    {
                        where = " WHERE ";
                    }
                    if (forGroup)
                    {
                        where += "  s.subId IN (SELECT sfgSubId FROM SubsForGroup WHERE sfgGrId = " + grId + ") ";
                    }
                    else
                    {
                        where += "  s.subId NOT IN (SELECT sfgSubId FROM SubsForGroup WHERE sfgGrId = " + grId + ") ";
                    }
                }
                where += " ORDER BY subName, subHoursNo ;";
                query += where;
                connection.Open();
                using (command = new SQLiteCommand(query, connection))
                {
                    using (dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                subjects.Add(new SubjectModel(
                                    int.Parse(dataReader["subId"].ToString()),
                                              dataReader["subName"].ToString(),
                                    int.Parse(dataReader["subType"].ToString()),
                                    int.Parse(dataReader["subHoursNo"].ToString()),
                                              dataReader["subColor"].ToString()/*,
                                    int.Parse(dataReader["stPerId"].ToString()) // TODO - Prevent from selecting more then one teacher!
                                                                                /* Convert.ToBoolean(dataReader["subLec"]),
                                                                                 Convert.ToBoolean(dataReader["subEx"]),
                                                                                 Convert.ToBoolean(dataReader["subLab"]),
                                                                                 Convert.ToBoolean(dataReader["subProj"])*/
                                    ));
                            }
                        }
                    }
                }
                connection.Close();
            }

            return subjects;
        }

        public List<SubjectModel> GetSubjects4Group(int grId)
        {
            List<SubjectModel> subjects = new List<SubjectModel>();
            SQLiteDataReader dataReader;

            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                SQLiteCommand command;
                string query = $"SELECT s.*, sfg.sfgPerId FROM Subject s join SubsForGroup sfg on s.subId = sfg.sfgSubId join [Group] on sfgGrId = grId where grId = {grId}  ORDER BY subName ;";

                connection.Open();
                using (command = new SQLiteCommand(query, connection))
                {
                    using (dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                subjects.Add(new SubjectModel(
                                    int.Parse(dataReader["subId"].ToString()),
                                              dataReader["subName"].ToString(),
                                    int.Parse(dataReader["subType"].ToString()),
                                    int.Parse(dataReader["subHoursNo"].ToString()),
                                              dataReader["subColor"].ToString(),
                                    int.Parse(dataReader["sfgPerId"].ToString()) 
                                    ));
                            }
                        }
                    }
                }
                connection.Close();
            }

            return subjects;
        }

        public bool CheckPersonUnav(int perId, int dayNo, int hourNo)
        {
            var hasTime = false;
            SQLiteDataReader dataReader;

            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                SQLiteCommand command;
                string query = string.Format("SELECT count(puId) cnt FROM PersonUnavailability WHERE puPerId = {0} AND puDayNo = {1} AND puHourNo = {2}", perId, dayNo, hourNo);

                connection.Open();
                using (command = new SQLiteCommand(query, connection))
                {
                    using (dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                hasTime = (int.Parse(dataReader["cnt"].ToString()) > 0) ? false : true;
                            }
                        }
                    }
                }
                connection.Close();
            }

            return hasTime;
        }

        public bool SavePersonUnav(List<PersonUnav> peoleUnav, int isLesson = 0)
        {
            var isOk = true;

            string query = "";
            string where = "";
            int rowsAffected = 0;
            int peopleToSave = 0;
            //SQLiteDataReader dataReader;
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                SQLiteCommand command;
                //connection.Open();
                query = "INSERT INTO PersonUnavailability ( puPerId, puDayNo, puHourNo, puDahId, puIsLesson ) VALUES ";

                foreach (var perUnav in peoleUnav)
                {
                    peopleToSave++;
                    if (where != "")
                        where += " , ";
                    where += string.Format(" ( {0}, {1}, {2}, (SELECT dahId FROM DaysAndHours WHERE dahDay = {1} AND dahHour = {2}), {3} ) ",
                    perUnav.Per.Id, perUnav.Day.Key, perUnav.HourNo, isLesson);
                }
                query += where;
                if (peopleToSave > 0)
                {
                    connection.Open();
                    using (command = new SQLiteCommand(query, connection))
                    {
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                if (rowsAffected != peopleToSave) isOk = false;
            }

            return isOk;
        }

        public bool SaveSubsForGroup(int grId, List<SubjectModel> toUpdate, List<SubjectModel> toInsert, List<SubjectModel> toDelete)
        { //TODO
            List<SubjectModel> people = new List<SubjectModel>();
            bool isOk = true;
            string query = "";
            string where = "";
            int rowsAffected = 0;
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                SQLiteCommand command;
                if (toDelete.Count() > 0)
                {
                    connection.Open();
                    query = "DELETE FROM SubsForGroup WHERE ";
                    foreach (var sub in toDelete)
                    {
                        if (where != "")
                            where += " OR ";
                        where += string.Format(" (sfgGrId={0} and sfgSubId={1}) ", grId, sub.Id);
                    }
                    query += where;
                    using (command = new SQLiteCommand(query, connection))
                    {
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    connection.Close();
                    if (rowsAffected != toDelete.Count()) isOk = false;
                }

                if (toInsert.Count() > 0)
                {
                    query = "";
                    where = "";
                    connection.Open();
                    //query = "INSERT INTO SubsForGroup ( sfgGrId, sfgSubId ) VALUES ";
                    query = "INSERT INTO SubsForGroup ( sfgGrId, sfgSubId, subPerId ) VALUES ";
                    foreach (var sub in toInsert)
                    {
                        if (where != "")
                            where += " , ";
                        where += string.Format(" ({0}, {1}, {2}) ", grId, sub.Id, sub.TeacherId);
                    }
                    query += where;
                    using (command = new SQLiteCommand(query, connection))
                    {
                        rowsAffected = command.ExecuteNonQuery();
                    }
                    connection.Close();
                    if (rowsAffected != toInsert.Count()) isOk = false;
                }
            }

            return isOk;
        }

        public PersonModel GetTeacher(int perId)
        {
            SQLiteCommand command;
            PersonModel person = new PersonModel();
            SQLiteDataReader dataReader;
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                string query = $"SELECT p.* FROM Person p where p.perId = {perId} ";

                //if (perId != -1)
                //{
                //    query += " WHERE st.stSubId = " + perId;
                //}

                query += " ORDER BY perLastName , perFirstName; ";
                connection.Open();
                using (command = new SQLiteCommand(query, connection))
                {
                    using (dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                person.Id = int.Parse(dataReader["perId"].ToString());
                                person.FirstName = dataReader["perFirstName"].ToString();
                                person.LastName = dataReader["perLastName"].ToString();
                                person.Degree = dataReader["perDegree"].ToString();
                            }
                        }
                    }
                }
                connection.Close();
            }
            return person;
        }


        public RoomModel GetRoom(int roomId = -1, int studNo = -1, int dayNo = -1, int hourNo = -1)
        {
            SQLiteCommand command;
            var room = new RoomModel();
            SQLiteDataReader dataReader;
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                string query = "SELECT r.* FROM Room r LEFT JOIN RoomUnavailability ru ON r.roomId = ru.ruRoomId ";
                var where = "";
                if (roomId == -1)
                {
                    if (studNo != -1)
                    {
                        where += " WHERE r.roomSitsNo >= " + studNo;
                    }
                    if (dayNo != -1)
                    {
                        if (where == "")
                            where = " WHERE ";
                        else
                            where += " AND ";
                        where += " r.roomId NOT IN (SELECT ruRoomId FROM RoomUnavailability ruu WHERE ruu.ruDayNo == " + dayNo + " ";

                        if (hourNo != -1)
                        {
                            where += " AND ruu.ruHourNo == " + hourNo + " ) ";
                        }
                        else
                        {
                            where += " ) ";
                        }
                    }
                }
                else
                {
                    where = " WHERE r.roomId = " + roomId;
                }
                query += where;
                query += " ORDER BY r.roomSitsNo asc LIMIT 1 ";
                connection.Open();
                using (command = new SQLiteCommand(query, connection))
                {
                    using (dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                room.Id = int.Parse(dataReader["roomId"].ToString());
                                room.RoomNo = dataReader["roomNo"].ToString();
                                room.Wing = dataReader["roomWing"].ToString();
                                room.SitsCnt = int.Parse(dataReader["roomSitsNo"].ToString());
                            }
                        }
                    }
                }
                connection.Close();
            }
            return room;
        }

        public bool SavePlan(List<LessonModel> lessons)
        {
            var isOk = true;
            var persUnav = new List<List<int>>();
            var roomUnav = new List<List<int>>();
            var lessonQurery = "INSERT INTO Lesson (lesPerId, lesSubId, lesRoomId," +
                " lesGogId, lesDayNo, lesHourNo, lesSlotNo, lesDahId ) VALUES ";
            var where = "";

            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                SQLiteCommand command;
                connection.Open();
                foreach (var lesson in lessons)
                {
                    persUnav.Add(new List<int>() { lesson.TeacherId, lesson.DayNo, lesson.HourNo }); // prepare persons to PersonUnava...
                    roomUnav.Add(new List<int>() { lesson.RoomId, lesson.DayNo, lesson.HourNo }); // prepare rooms to RoomUnava...


                    where = string.Format(" ( {0}, {1}, {2}, {3}, {4}, {5}, {6}, " +
                        "(SELECT dahId from DaysAndHours WHERE dahDay = {4} AND dahHour = {5}) ) ",
                        lesson.TeacherId, lesson.SubjectId, lesson.RoomId, lesson.GroupId, lesson.DayNo, lesson.HourNo, lesson.SlotNo);
                    using (command = new SQLiteCommand(lessonQurery + where, connection))
                    {
                        command.ExecuteNonQuery(); // save to Lesson
                    }
                }

                if (persUnav.Count > 0)
                    SavePersonUnav(persUnav, 1); // save to PersonUnavailability
                if (roomUnav.Count > 0)
                    SaveRoomUnav(roomUnav); // save to RoomUnavailability
                connection.Close();
            }

            return isOk;
        }

        public bool SavePersonUnav(List<List<int>> input, int isLesson = 0)
        {
            var isOk = false;
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                SQLiteCommand command;
                connection.Open();
                var query = "INSERT INTO PersonUnavailability ( puPerId, puDayNo, puHourNo, puDahId, puIsLesson ) VALUES ";
                var where = "";
                foreach (var row in input)
                {
                    if (where != "")
                        where += ',';
                    where += string.Format(" ( {0}, {1}, {2}, (SELECT dahId from DaysAndHours WHERE dahDay = {1} AND dahHour = {2}), {3} ) ",
                        row[0], row[1], row[2], isLesson);
                }
                query += where;
                using (command = new SQLiteCommand(query, connection))
                {
                    if (command.ExecuteNonQuery() > 0)
                        isOk = true;
                }
            }
            return isOk;
        }

        public bool SaveRoomUnav(List<List<int>> input)
        {
            var isOk = false;
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                SQLiteCommand command;
                connection.Open();
                var query = "INSERT INTO RoomUnavailability ( ruRoomId, ruDayNo, ruHourNo, ruDahId ) VALUES ";
                var where = "";
                foreach (var row in input)
                {
                    if (where != "")
                        where += ',';
                    where += string.Format(" ( {0}, {1}, {2}, (SELECT dahId from DaysAndHours WHERE dahDay = {1} AND dahHour = {2}) ) ",
                        row[0], row[1], row[2]);
                }
                query += where;
                using (command = new SQLiteCommand(query, connection))
                {
                    if (command.ExecuteNonQuery() > 0)
                        isOk = true;
                }
            }
            return isOk;
        }

        public void ClearPlans()
        {
            var query = "DELETE FROM PersonUnavailability WHERE puIsLesson = 1; " +
                "DELETE FROM RoomUnavailability; " +
                "DELETE FROM Lesson; ";
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString)) // TODO - add transaction
            {
                SQLiteCommand command;
                connection.Open();

                using (command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery(); 
                }

                connection.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="perId"></param>
        /// <param name="isLesson"> 1- is lesson, 0 manually set, -1 both</param>
        /// <returns></returns>
        public PersonUnavDaysHours GetPersonUnav(int perId, int isLesson = -1)
        {
            SQLiteCommand command;
            var dayAndHour = new List<DayHour>();
            SQLiteDataReader dataReader;

            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                string query = string.Format("select dahDay, dahHour from DaysAndHours where dahId in (select pudahId FROM PersonUnavailability WHERE puPerId = {0} ", perId);
                if (isLesson >= 0)
                    query += $" AND puIsLesson = {isLesson} ";
                query += $" ) ";
                query += " order by dahday, dahhour ";
                connection.Open();
                using (command = new SQLiteCommand(query, connection))
                {
                    using (dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                dayAndHour.Add(new DayHour(
                                        int.Parse(dataReader["dahDay"].ToString()),
                                        int.Parse(dataReader["dahHour"].ToString())
                                    ));
                            }
                        }
                    }
                }
                connection.Close();
            }
            return new PersonUnavDaysHours(perId, dayAndHour);
        }

        public List<RoomModel> GetRooms(int minSitsNo)
        {
            SQLiteCommand command;
            var rooms = new List<RoomModel>();
            SQLiteDataReader dataReader;
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                string query = "SELECT r.* FROM Room r ";
                var where = "";
                if (minSitsNo != -1)
                {
                    where += " WHERE r.roomSitsNo >= " + minSitsNo;
                }
                query += where;
                query += " ORDER BY r.roomSitsNo asc ";
                connection.Open();
                using (command = new SQLiteCommand(query, connection))
                {
                    using (dataReader = command.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                var room = new RoomModel();
                                room.Id = int.Parse(dataReader["roomId"].ToString());
                                room.RoomNo = dataReader["roomNo"].ToString();
                                room.Wing = dataReader["roomWing"].ToString();
                                room.SitsCnt = int.Parse(dataReader["roomSitsNo"].ToString());
                                /**/
                                var subQuery = "SELECT ruDayNo, ruHourNo FROM RoomUnavailability WHERE ruRoomId = " + room.Id + " ORDER BY ruDayNo, ruHourNo;";
                                using (var subCommand = new SQLiteCommand(subQuery, connection))
                                {
                                    using (SQLiteDataReader subDReader = subCommand.ExecuteReader())
                                    {
                                        if (subDReader.HasRows)
                                        {
                                            while (subDReader.Read())
                                            {
                                                room.DayAndHour.Add(new DayHour(
                                                            int.Parse(subDReader["ruDayNo"].ToString()),
                                                            int.Parse(subDReader["ruHourNo"].ToString())
                                                        ));
                                            }
                                        }
                                    }
                                }
                                rooms.Add(room);
                            }
                        }
                    }
                }
                connection.Close();
            }
            return rooms;
        }

        public bool DeletePersonUnav(int perId) // TODO
        {
            var isOk = true;
            if (perId > 0)
            {
                using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
                {
                    SQLiteCommand command;
                    connection.Open();
                    string query = " DELETE FROM PersonUnavailability WHERE " +
                        $" puIsLesson = 0 ";//NOT IN ( SELECT lesDahId FROM LESSON WHERE lesperId = {perId} ) AND puPerId = {perId} ";
                    using (command = new SQLiteCommand(query, connection))
                    {
                        var answer = command.ExecuteNonQuery(); 
                    }
                    connection.Close();
                }
            }
            return isOk;
        }

        public int[] GetCntOfSubgroups(int grId)
        {
            int[] cnts = new int[4];
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                SQLiteCommand command;
                connection.Open();
                string query = $" SELECT COUNT(*) cnt FROM GroupsOfGroup g1  WHERE g1.gogGrId = {grId} group by g1.gogtype order by gogtype ";
                using (command = new SQLiteCommand(query, connection))
                {
                    using (var results = command.ExecuteReader())
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (results.Read())
                            {
                                cnts[i] = results.GetInt32(0);
                            }
                        }
                    }
                }
                connection.Close();
            }
                return cnts;
        }

        public List<GroupPlanInfoModel> GetPlansInfo(string name = "", int year = -1)
        {
            List<GroupPlanInfoModel> plansInfo = new List<GroupPlanInfoModel>();
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                string where = "";
                if (name != "")
                    where = $" WHERE UPPER(grName) LIKE UPPER('{name}%') ";
                if (year != -1)
                {
                    if (where != "")
                        where += $"AND grYear = { year } ";
                    else
                        where = $" WHERE grYear = {year} ";
                }
                string query = $" select grId, grName, gryear, " +
                    $" (select COUNT(lesId) from lesson join [GroupsOfGroup] on lesgogid = gogId where goggrid = grid) lesCnt, " +
                    $" ((select count(sfgId)FROM SubsForGroup where sfggrId = grId)) subsCnt," +
                    $"  grStudNo " +
                    $" FROM[Group] left join GroupsOfGroup on goggrid = grid left join Lesson on lesgogid = gogid " +
                    $" left join SubsForGroup on sfggrid = grid " +
                    where +
                    $" group by grid, sfggrId ORDER BY grname, grYear";

                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (var results = command.ExecuteReader())
                    {
                        if(results.HasRows)
                        {
                            while (results.Read())
                            {
                                plansInfo.Add( new GroupPlanInfoModel(
                                    results.GetInt32(0),
                                    results.GetString(1),
                                    results.GetInt32(2),
                                    results.GetInt32(3),
                                    results.GetInt32(4),
                                    results.GetInt32(5)
                                ));
                            }
                        }
                    }
                }
                connection.Close();
            }
            return plansInfo;
        }

        public List<LessonModel> GetPlan(int grId)
        {
            List<LessonModel> plan = new List<LessonModel>();
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                string query = $"select lesid, lesgogId, lesroomId, lesperid, lessubid, lesdayno, leshourno, lesslotno from lesson " +
                    $" where lesgogId in (select gogid from GroupsOfGroup where goggrid = {grId}) ";

                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (var results = command.ExecuteReader())
                    {
                        if (results.HasRows)
                        {
                            while (results.Read())
                            {
                                plan.Add(new LessonModel(
                                    results.GetInt32(0),
                                    results.GetInt32(1),
                                    results.GetInt32(2),
                                    results.GetInt32(3),
                                    results.GetInt32(4),
                                    results.GetInt32(5),
                                    results.GetInt32(6),
                                    results.GetInt32(7)
                                ));
                            }
                        }
                    }
                }
                connection.Close();
            }
            return plan;
        }

        public List<KeyValuePair<PersonModel, int>> GetPeopleToPrintSummary(string fn = "", string ln = "", int id = -1, string identifeir = "")
        {
            List<KeyValuePair<PersonModel, int>> people = new List<KeyValuePair<PersonModel, int>>();

            List<PersonModel> personList = GlobalConfig.Connection.GetPerson(id, fn, ln, identifeir);

            foreach (PersonModel person in personList)
            {
                using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
                {
                    string query = $" select count(lesid) from lesson where lesperid = {person.Id} ";
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        using (var results = command.ExecuteReader())
                        {
                            if (results.HasRows)
                            {
                                if (results.Read())
                                {
                                    people.Add(new KeyValuePair<PersonModel, int>(person, results.GetInt32(0)));
                                }
                            }
                        }
                    }
                    connection.Close();
                }
            }
            return people;
        }

        public List<PlanModelForPerson> GetPlanForPerson(int perId = -1)
        {
            List<PlanModelForPerson> peoplePlans = new List<PlanModelForPerson>();

            if (perId == -1)
                return peoplePlans;

            string query = $"select subname || ' - ' || (case subType when  1 then 'Wykład' when 2 then 'Ćwiczenia' " +
               $" when 3 then 'Laboratorium' when 4 then 'Projekt' else '' end) subFullName, " +
               $" subType , subColor, grName || ' ' || (case grYear when  1 then 'I' when 2 then 'II' when 3 then 'III' " +
               $" when 4 then 'IV'  when 5 then 'V' else '' end) grFullName, roomNo || ' ' || roomWing roomFullname, " +
               $" gogName subgroupname, " +
               $" lesDayNo, lesHourNo from Lesson join Person on lesPerId = perID join Subject on lessubId = subId " +
               $" join GroupsOfGroup on lesGogId = gogId  join[Group] on gogGrId = grId join Room on lesroomId = roomId " +
               $" where lesperId = {perId} " +
               $" order By perLastName, perFirstName, lesDayNo, lesHourNo";
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (var results = command.ExecuteReader())
                    {
                        if (results.HasRows)
                        {
                            while (results.Read())
                            {
                                peoplePlans.Add(new PlanModelForPerson( 
                          /*          results.GetString(0), // subfullname
                                    (Int32)results.GetInt64(1), //subType
                                    results.GetString(3), //grfullname
                                    results.GetInt32(5), // dayNo
                                    results.GetInt32(6), // hourNo
                                    results.GetString(2), // subColor
                                    results.GetString(4) // roomFullName*/
                                    results["subFullName"].ToString(),
                                    int.Parse(results["subType"].ToString()),
                                    results["grFullName"].ToString(),
                                    int.Parse(results["lesDayNo"].ToString()),
                                    int.Parse(results["lesHourNo"].ToString()),
                                    results["subColor"].ToString(),
                                    results["roomFullname"].ToString(),
                                    results["subgroupname"].ToString()
                                    )
                                );
                            }
                        }
                    }
                }
                connection.Close();
            }

            return peoplePlans;
        }

        public string DeletePlan(int grId)
        {
                string queryPeople = $" SELECT lesperId FROM lesson JOIN GroupsOfGroup ON lesgogid = gogid WHERE  gogGrId = {grId} ";
                string queryRooms =  $" SELECT lesRoomId FROM lesson JOIN GroupsOfGroup ON lesgogid = gogid WHERE  gogGrId = {grId} ";
                string queryLesson = $" SELECT gogid FROM GroupsOfGroup WHERE gogGrId = {grId} ";
            var query = $" DELETE FROM PersonUnavailability WHERE puIsLesson = 1 AND puPerId IN ({queryPeople}); " +
                        $" DELETE FROM RoomUnavailability WHERE ruRoomId IN ({queryRooms}); " +
                        $" DELETE FROM Lesson WHERE lesGogId IN ({queryLesson}) ; ";
            var answer = "OK";
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                connection.Open();
                using (SQLiteTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(query, connection, transaction))
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (Exception e)
                    {
                        transaction.Rollback();
                        answer = e.Message;
                    }
                }
                connection.Close();
            }
            return answer;
        }

        /// <summary>
        /// Unlink subjects from group.
        /// </summary>
        /// <param name="grId"></param>
        public string UnlinkSubjects(int grId)
        {
            var ans = "";
            string query = $" delete from SubsForGroup where sfggrid = {grId}";
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch(SQLiteException ex)
                {
                    ans = "Coś poszło nie tak." + Environment.NewLine + Environment.NewLine + ex;
                }
            }
            return ans;
        }

        public void DeleteGroup(int grId)
        {
            DeletePlan(grId);
            UnlinkSubjects(grId);
            string query = $" delete from GroupsOfGroup where goggrid = {grId}; " +
                $" delete from [Group] where grid = {grId}; ";
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    int rowsAffected = command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public string DeletePerson(int perId)
        {
            var subIds = GetSubjectsIdsForPerson(perId);
            string ans = "";
            if (subIds.Count > 0)
            {
                string subIdsWhere = " ( -10 ";
                foreach (var item in subIds)
                {
                    subIdsWhere += $", {item}";
                }
                subIdsWhere += " )  ";
/*
                string grIdsQuery =  $"select DISTINCT  gogGrId from GroupsOfGroup where gogid in (select lesgogid from lesson where lessubid in " +
                    $"(select stsubId from subjectTeachers where stperid = {perId}));";
*/
                string grIdsQuery = $" select DISTINCT sfgGrId from SubsForGroup where sfgPerId = {perId}; ";
                List<int> grIds = new List<int>();
                using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(connection))
                    {
                        command.CommandText = grIdsQuery;
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    grIds.Add(reader.GetInt32(0));
                                }
                            }
                        }
                    }
                    connection.Close();
                }

                foreach (var item in grIds) // remove plans
                {
                    DeletePlan(item);
                }
                DeletePersonUnav(perId); // delete custom PersonUnav

                //string deleteFromSubjectTeachersQuery = $" delete from subjectteachers where stperId = {perId};";
                string deleteFromSubsForGroupQuery = $" delete from subsForGroup where sfgPerId = {perId}; ";
                string deleteSubsQuery = $" delete from subject where subid in "+ subIdsWhere;

                using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SQLiteCommand command = new SQLiteCommand(/*deleteFromSubjectTeachersQuery*/ deleteFromSubsForGroupQuery, connection, transaction))
                            {
                                command.ExecuteNonQuery();
                            }
                            using (SQLiteCommand command = new SQLiteCommand(deleteSubsQuery, connection, transaction))
                            {
                                command.ExecuteNonQuery();
                            }
                            using (SQLiteCommand command = new SQLiteCommand($"delete from person where perId = {perId}", connection, transaction))
                            {
                                command.ExecuteNonQuery();
                            }
                            transaction.Commit();   
                        }
                        catch(SQLiteException ex)
                        {
                            transaction.Rollback();
                            ans = $"Coś poszło nie tak.{Environment.NewLine + Environment.NewLine + ex}";
                        }
                    }
                    connection.Close();
                }

            }
            else
            {
                using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand($" delete from person where perId = {perId}", connection))
                    {
                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch(SQLiteException ex)
                        {
                            ans = $"Coś poszło nie tak.{Environment.NewLine + ex}";
                        }
                      
                    }
                    connection.Close();
                }
            }
            return ans;
        }

        public List<int> GetSubjectsIdsForPerson(int perId)
        {
            var list = new List<int>();
            string query = $"select DISTINCT sfgsubId from subsForGroup where sfgPerId = {perId} ";
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                list.Add(reader.GetInt32(0));
                            }
                        }
                    }
                }
                connection.Close();
            }
            return list;
        }

        public List<SubjectWithTeacherModel> GetSubjectsWithTeacher4Group(int grId = -1)
        {
            List<SubjectWithTeacherModel> subs = new List<SubjectWithTeacherModel>();

            string query = $" select subid, subname, subtype, perId from subject join SubsForGroup sfg on subId = sfg.sfgSubId " +
                $" join person on sfg.sfgperid = perid where sfg.sfggrid = {grId} order by subname, subtype";
            

            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (var results = command.ExecuteReader())
                    {
                        if (results.HasRows)
                        {
                            while (results.Read())
                            {
                                subs.Add(new SubjectWithTeacherModel(
                                    GetTeacher(results.GetInt32(3)),
                                    results.GetInt32(0),
                                    results.GetString(1),
                                    results.GetInt32(2)
                                ));
                            }
                        }
                    }
                }
                connection.Close();
            }

            return subs;
        }
        
        public string UnlinkAndSaveSubsForGroup(int grId, List<SubjectWithTeacherModel> subsToLink)
        {
            if (grId < 1 || subsToLink == null || subsToLink.Count == 0)
                return "";

            
            string ans = UnlinkSubjects(grId);

            if (ans != "")
            {
                return ans;
            }

            string query = "";

            foreach (var item in subsToLink)
            {
                if (query != "")
                    query += ",";
                query += $" ( {grId}, { item.Id }, {item.Teacher.Id} )";
            }
            query = "insert into SubsForGroup(sfggrId, sfgsubId, sfgPerId) values " + query;
            using (var connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(query, connection, transaction))
                        {
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (SQLiteException ex)
                    {
                        transaction.Rollback();
                        ans = $"Coś poszło nie tak.{Environment.NewLine + ex}";
                    }
                }
                connection.Close();
            }

            return ans;
        }

        public string DeleteSubjects(List<int> subsIds)
        {
            if (subsIds.Count == 0)
                return "";
            var ans = "";

            foreach (var subId in subsIds)
            {
                foreach (int grId in GetGroups4Subject(subId))
                {
                    DeletePlan(grId);
                }
            }

            string inSubIds = "";
            foreach (int subId in subsIds)
            {
                inSubIds += $" ,{subId}";
                ans += UnlinkGroupsFromSubject(subId);
                if (ans != "")
                    return ans;
            }

            //string deleteFromSubjectTeachersQuery = $" delete from subjectteachers where stsubId in (-1 {inSubIds});";
            string deleteFromSubsForGroupQuery = $" delete from subsForGroup where sfgPerId in (-1 {inSubIds});";
            string deleteSubjectsQuery = $" delete from subject where subid in (-1 {inSubIds});";


            using (var connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(/*deleteFromSubjectTeachersQuery */deleteFromSubsForGroupQuery + deleteSubjectsQuery, connection, transaction))
                        {
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (SQLiteException ex)
                    {
                        transaction.Rollback();
                        ans = $"Coś poszło nie tak.{Environment.NewLine + Environment.NewLine + ex}";
                    }
                }
                connection.Close();
            }

            return ans;
        }

        public List<int> GetGroups4Subject(int subId)
        {
            var list = new List<int>();
            string query = $"select sfgGrId from subsForGroup where sfgSubId = {subId} ";
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                list.Add(reader.GetInt32(0));
                            }
                        }
                    }
                }
                connection.Close();
            }
            return list;
        }

        public string UnlinkGroupsFromSubject(int subId)
        {
            var ans = "";
            string query = $" delete from SubsForGroup where sfgsubid = {subId}";
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                try
                {
                    connection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                catch (SQLiteException ex)
                {
                    ans = "Coś poszło nie tak." + Environment.NewLine + Environment.NewLine + ex;
                }
            }
            return ans;
        }

        public List<RoomModel> GetRooms(string rNo, string wing)
        {
            var rooms = new List<RoomModel>();

            string query = "";
            if (rNo != "")
            {
                query = $" where upper(roomNo) = upper('{rNo}') ";
            }
            if (wing != "")
            {
                if(query != "")
                {
                    query += " and ";
                }
                else
                {
                    query = " where ";
                }
                query += $" upper(roomwing) = upper('{wing}') ";
            }

            query = "Select roomId, roomNo, roomWing, roomSitsNo from room " + query;

            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                rooms.Add(new RoomModel(
                                    reader.GetInt32(0),
                                    reader.GetString(1),
                                    reader.GetString(2),
                                    reader.GetInt32(3)
                                    ));
                            }
                        }
                    }
                }
                connection.Close();
            }
            return rooms;
        }

        public string DeleteRoom(List<int> roomsIds)
        {
            if (roomsIds.Count == 0)
                return "";
            var ans = "";

            string inIds = "-1 ";
            foreach (var id in roomsIds)
            {
                inIds += $" , {id} ";
            }
            string updateLessons = $" update Lesson set lesroomId = (0) where lesroomid in ( {inIds} )";

            string removeRoomUnav = $" delete from RoomUnavailability where ruroomid in ( {inIds} )";

            string removeRooms = $" delete from room where roomid in  ( {inIds} )";

            using (var connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (SQLiteCommand command = new SQLiteCommand(updateLessons, connection, transaction))
                        {
                            command.ExecuteNonQuery();
                        }
                        using (SQLiteCommand command = new SQLiteCommand(removeRoomUnav, connection, transaction))
                        {
                            command.ExecuteNonQuery();
                        }
                        using (SQLiteCommand command = new SQLiteCommand(removeRooms, connection, transaction))
                        {
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (SQLiteException ex)
                    {
                        transaction.Rollback();
                        ans = $"Coś poszło nie tak.{Environment.NewLine + Environment.NewLine + ex}";
                    }
                }
                connection.Close();
            }

            return ans;
        }

        public bool IsDbAvailable()
        {
            bool isAwailable = false;
            

            return isAwailable;
        }

        public void SetSetup()
        {
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(" select setGrPlanPath, setPerPlanPath, setMaxLessonsPerDay from setup ", connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            if (reader.Read())
                            {
                                GlobalData.Path4Groups = reader.GetString(0);
                                GlobalData.Path4People = reader.GetString(1);
                                GlobalData.MaxLessonsPerDay = int.Parse(reader["setMaxLessonsPerDay"].ToString());
                            }
                        }
                    }
                }
            }
        }

        public string SaveSetup(string grPath, string pPath, int maxLessons)
        {
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                connection.Open();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        
                        using (SQLiteCommand command = new SQLiteCommand("delete from setup", connection, transaction))
                        {
                            command.ExecuteNonQuery();
                        }
                        using (SQLiteCommand command = new SQLiteCommand($"insert into setup values ('{grPath}', '{pPath}', '{maxLessons}')", connection, transaction))
                        {
                            command.ExecuteNonQuery();
                        }
                        transaction.Commit();
                    }
                    catch (SQLiteException e)
                    {
                        transaction.Rollback();
                        return $"Coś poszło nie tak.{Environment.NewLine + Environment.NewLine + e}";

                    }
                }
                connection.Close();
            }
            return "";
        }

        public string PrepareSummary(int grId)
        {
            var summary = "";
            var group = GetGroup(grId).First();
            summary = $"{group.FullName} {Environment.NewLine} ";

            var subjects = GetSubjects(-1, grId);

            var subgroups = group.Subgroups;
            var unconfiguredSubs = "";
            foreach (var sg in group.Subgroups)
            {
                var tmpSubs = subjects.Where(s => s.Type == sg.Type);
                foreach (var sub in tmpSubs)
                {
                    var query = $" select lesid from [lesson] where lessubid = {sub.Id} and lesgogId = {sg.Id} ";
                    using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
                    {
                        connection.Open();
                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            using (SQLiteDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {

                                    /*if (reader.Read())
                                    {
                                        
                                    }*/
                                }
                                else
                                {
                                    unconfiguredSubs = Environment.NewLine +  "  " + sub.FullName + " - " + sg.Name;
                                }
                            }
                        }
                    }

                }
            }
            if (unconfiguredSubs != "")
                summary = summary + Environment.NewLine + "Nieskonfigurowane zajęcia: " + unconfiguredSubs;

            var subsWithNoRoom = "";
            var queryRoom = $"select subname , gogName from lesson join subject on lessubid = subid join groupsofgroup on lesgogid = gogid where lesroomid = 0 and goggrid = {grId} ";
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(queryRoom, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            while(reader.Read())
                            {
                                subsWithNoRoom += $"{Environment.NewLine}  {reader.GetString(0)} - {reader.GetString(1)}";
                            }
                        }
                    }
                }
            }
            
            if(subsWithNoRoom != "")
            {
                summary = summary + Environment.NewLine + Environment.NewLine + "Zajęcia bez przypisanej sali:" + subsWithNoRoom;
            }

            return summary;
        }


        // testing 
        
        public string saveTestingData()
        {
            System.Diagnostics.Stopwatch stopWatch = new System.Diagnostics.Stopwatch();
            stopWatch.Start();
         /*   List<KeyValuePair<string, int>> list = new List<KeyValuePair<string, int>>();
            for (int i = 0; i <= 100; i++)
            {
                GroupModel model = new GroupModel();
                model.Id = -1;
                model.StudentsCnt = (i < 20 ? i + 20 : i);
                model.Year = (i < 20 ? 1 : i < 40 ? 2 : i < 60 ? 3 : i < 90 ? 4 : 5);
                model.MaxLessonsPerDay = model.Year + 1;
                model.Name = "Group G" + i;
                model.LabGrCnt = (i < 30 ? 3 : i < 60 ? 4 : i > 95 ? 5 : 2);
                model.ProjGrCnt = (i < 30 ? 3 : i < 60 ? 4 : i > 95 ? 5 : 2);
                model.ExGrCnt = (i < 30 ? 3 : i < 60 ? 4 : i > 95 ? 5 : 2) - 1;
                CreateGroup(model);

                SubjectModel model0 = new SubjectModel();
                model0.CellColor = $"RGBA({i}, {i + i}, {(i > 20 ? i * 2 - 18 : i * 5)}, 255)";
                model0.Name = "Subject S" + i;
                model0.Type = 1;
                model0.Id = -1;
                CreateSubject(model0);
                SubjectModel model1 = new SubjectModel();
                model1.CellColor = $"RGBA({i}, {i + i}, {(i > 20 ? i * 2 - 18 : i * 5)}, 255)";
                model1.Name = "Subject S" + i;
                model1.Type = 2;
                model1.Id = -1;
                CreateSubject(model1);
                SubjectModel model2 = new SubjectModel();
                model2.CellColor = $"RGBA({i}, {i + i}, {(i > 20 ? i * 2 - 18 : i * 5)}, 255)";
                model2.Name = "Subject S" + i;
                model2.Type = 3;
                model2.Id = -1;
                CreateSubject(model2);
                SubjectModel model3 = new SubjectModel();
                model3.CellColor = $"RGBA({i}, {i + i}, {(i > 20 ? i * 2 - 18 : i * 5)}, 255)";
                model3.Name = "Subject S" + i;
                model3.Type = 4;
                model3.Id = -1;
                CreateSubject(model3);


                PersonModel modelp = new PersonModel();
                modelp.Id = -1;
                modelp.LastName = "LastName L" + i;
                modelp.FirstName = "firstName F" + i;
                modelp.Degree = (i < 30 ? "mgr" : i < 80 ? "dr" : i < 90 ? "mrg" : "prof");
                modelp.Identifier = $"{(i + i * 10000 / 4)}";
                modelp.Id = -1;
                CreatePerson(modelp);
            }*/


            /*using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand("Select * from TXT", connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            while (reader.Read())
                            {
                                list.Add(new KeyValuePair<string, int>( reader.GetString(0), reader.GetInt32(1)));
                            }
                        }
                    }
                }
            }
            var query = $" insert into txt values ";
            var values = "('pierwsze słowo: {i} + drugie slowo: {i * 2} + trzecie slowo bez i',-1) ";
            for (int i = 0; i < 42000; i++)
            {
                values += $",('pierwsze słowo: {i} + drugie slowo: {i * 2} + trzecie slowo bez i',{i}) ";
                
            }
            query = query + "" + values + "";
            using (SQLiteConnection connection = new SQLiteConnection(GlobalConfig.CnnString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }*/
            stopWatch.Stop();
            return stopWatch.Elapsed.ToString("mm\\:ss\\.ff") /* + " cnt: "+ list.Count.ToString()*/;
        }
    }
}
