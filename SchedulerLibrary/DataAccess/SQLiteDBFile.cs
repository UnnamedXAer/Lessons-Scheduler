using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerLibrary.DataAccess
{
    public static class SQLiteDBFile
    {
        private static string script = @"

--
-- File generated with SQLiteStudio v3.1.1 on Thu May 31 13:36:39 2018
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: DaysAndHours
CREATE TABLE DaysAndHours (

    dahId   INTEGER PRIMARY KEY AUTOINCREMENT

                    UNIQUE

                    NOT NULL,

    dahDay  INT     NOT NULL,

    dahHour INT     NOT NULL

);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (1, 1, 1);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (2, 1, 2);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (3, 1, 3);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (4, 1, 4);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (5, 1, 5);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (6, 1, 6);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (7, 2, 1);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (8, 2, 2);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (9, 2, 3);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (10, 2, 4);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (11, 2, 5);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (12, 2, 6);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (13, 3, 1);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (14, 3, 2);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (15, 3, 3);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (16, 3, 4);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (17, 3, 5);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (18, 3, 6);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (19, 4, 1);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (20, 4, 2);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (21, 4, 3);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (22, 4, 4);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (23, 4, 5);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (24, 4, 6);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (31, 0, 0);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (32, 1, 0);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (33, 2, 0);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (34, 3, 0);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (35, 4, 0);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (36, 0, 7);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (37, 1, 7);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (38, 2, 7);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (39, 3, 7);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (40, 4, 7);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (41, 0, 1);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (42, 0, 2);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (43, 0, 3);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (44, 0, 4);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (45, 0, 5);
INSERT INTO DaysAndHours (dahId, dahDay, dahHour) VALUES (46, 0, 6);

-- Table: Group
CREATE TABLE [Group] (grId INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, grName VARCHAR (150) NOT NULL, grYear INT NOT NULL, grStudNo INT NOT NULL, grMaxLessonsPerDay INTEGER DEFAULT (6));

-- Table: GroupsOfGroup
CREATE TABLE GroupsOfGroup(gogId INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, gogGrId INTEGER REFERENCES[Group] (grId) NOT NULL, gogType INT NOT NULL, gogStudNo INT NOT NULL, gogName VARCHAR (10) NOT NULL DEFAULT('wyk'), gogGroupNo INTEGER NOT NULL);

-- Table: Lesson
CREATE TABLE Lesson(lesId INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, lesPerId INTEGER CONSTRAINT per REFERENCES Person (perId) NOT NULL, lesSubId INTEGER CONSTRAINT sub REFERENCES Subject (subId) NOT NULL, lesRoomId INTEGER CONSTRAINT room REFERENCES Room (roomId), lesGogId INTEGER CONSTRAINT gog REFERENCES GroupsOfGroup (gogId) NOT NULL, lesDayNo INTEGER NOT NULL, lesHourNo INTEGER NOT NULL, lesSlotNo INTEGER NOT NULL, lesDahId INTEGER CONSTRAINT dah REFERENCES DaysAndHours (dahId) NOT NULL);

-- Table: Person
CREATE TABLE Person(perId INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, perFirstName VARCHAR (50) NOT NULL, perLastName VARCHAR(50) NOT NULL, perDegree VARCHAR(50), perIdentifier VARCHAR(10));

-- Table: PersonUnavailability
CREATE TABLE PersonUnavailability(puId INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL UNIQUE, puPerId INTEGER REFERENCES Person (perId) NOT NULL, puDayNo INTEGER NOT NULL, puHourNo INTEGER NOT NULL, puDahId INTEGER REFERENCES DaysAndHours (dahId) NOT NULL, puIsLesson INTEGER (1) NOT NULL DEFAULT(0));

-- Table: Room
CREATE TABLE Room(roomId INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, roomNo VARCHAR (5) NOT NULL, roomWing VARCHAR(10) NOT NULL, roomSitsNo INTEGER NOT NULL);

-- Table: RoomUnavailability
CREATE TABLE RoomUnavailability(ruId INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, ruRoomId INTEGER REFERENCES Room (roomId) NOT NULL, ruDayNo INTEGER NOT NULL, ruHourNo NOT NULL, ruDahId REFERENCES DaysAndHours (dahId) NOT NULL);

-- Table: Setup
CREATE TABLE Setup(setGrPlanPath VARCHAR (3000), setPerPlanPath VARCHAR(3000), setMaxLessonsPerDay INTEGER DEFAULT(6));
INSERT INTO Setup(setGrPlanPath, setPerPlanPath, setMaxLessonsPerDay) VALUES('', '', 6);

-- Table: Subject
CREATE TABLE Subject(subId INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, subName VARCHAR (200) NOT NULL, subHoursNo INT DEFAULT(30), subType INT CHECK(subType = 1 OR subType = 2 OR subType = 3 OR subType = 4) DEFAULT(1) NOT NULL, subColor STRING(20) DEFAULT white);


-- Table: SubsForGroup
CREATE TABLE SubsForGroup(sfgId INTEGER PRIMARY KEY AUTOINCREMENT UNIQUE NOT NULL, sfgGrId INTEGER REFERENCES [Group] (grId) NOT NULL, sfgSubId INTEGER REFERENCES Subject (subId) NOT NULL, sfgPerId INTEGER REFERENCES Person (perId) NOT NULL);

-- Table: TXT
CREATE TABLE TXT(TXT STRING, num INTEGER);

        COMMIT TRANSACTION;
        PRAGMA foreign_keys = on;

";

        public static string CreateDBFile()
        {
            string filePath = Environment.CurrentDirectory + "\\LessonsSchedulerDB.db";
            bool isFile = System.IO.File.Exists(filePath);

            if (!isFile)
            {
                try
                {   // Open the text file using a stream reader.
                    using (StreamReader sr = new StreamReader(Environment.CurrentDirectory + "\\SQLiteDBScript.txt"))
                    {
                        // Read the stream to a string, and write the string to the console.
                        var scriptx = sr.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    return e.Message;
                } 

                SQLiteConnection.CreateFile(filePath);

                string dir = Environment.CurrentDirectory;
                SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source="+ filePath + ";");
                m_dbConnection.Open();

                    SQLiteCommand command = new SQLiteCommand(script, m_dbConnection);
                
                    //Insert create script here.
                    command.ExecuteNonQuery();
                    //Indicates that creating the SQLiteDatabase went succesfully, so the database can be committed.

                
                m_dbConnection.Close();
            }
            return "";
            //GlobalConfig.Connection.IsDbAwailable();
        }
    }
}
