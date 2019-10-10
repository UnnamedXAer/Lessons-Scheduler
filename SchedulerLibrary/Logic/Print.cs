using PdfSharp.Pdf;
using SchedulerLibrary.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.PdfSharp;
using IronPdf;

namespace SchedulerLibrary.Logic
{
    static public class Print
    {
        static private string tr = "<tr style = 'height: 70px;' >";
        static private string tre = "</tr>";
        static private string td = "<td style='border: 1px solid green; height: 70px; '>";
        static private string br = "<br>";
        static private string tde = "</td>";
        static private string th = "<td style='border: 1px solid green; text-align: center;  width:19%; background-color:lightgrey; font-size:20px;'>";
        static private string the = "</td>";

        public static string CreateDocumentForPerson(string perName, List<PlanModelForPerson> plan, bool printPdf, bool printHtml)
        {
            var html = "<html style='width: 99%;'><head><meta charset='UTF-8'><title>Lessons Scheduler</title></head><body style='width: 100%;'>" +
                $"<h3> {perName} </h3>" +
                "<table style='border: 1px solid rgb(0, 0, 0); width: 100%; color:black;' >" + 
                "<tr><td style = 'width: 5%;'></td>" + th + "Poniedziałek" + the + th + "Wtorek" + the + th + "Środa" + the + th + "Czwartek" + the + th + "Piątek" + the + tre;

            for (var i = 0; i < 7; i++) // hour
            {
                //html += tr;
                var row = tr + td + GlobalData.GetHourTime(i) + tde;
                for (int j = 0; j < 5; j++) // day
                {
                    string lesCell;
                    bool any = plan.Any(p => p.DayNo == j && p.HourNo == i);
                    if (any)
                    {
                        PlanModelForPerson _lesson = plan.First(p => p.DayNo == j && p.HourNo == i);
                        lesCell = "<td style=' white-space: initial; height: 100%; border-right:1px solid black; text-align: center;  background-color:"
                                    + _lesson.SubjectColor + ";"
                                    + " width:" + 18 + "% !important;" 
                                    + " border: 1px solid green; '>"
                                    + _lesson.SubjectFullName + br 
                                    + _lesson.GroupFullName + " - "
                                    + _lesson.SubgroupName + br
                                    + _lesson.RoomFullName
                                    + "</td>";
                    }
                    else
                    {
                        lesCell = "<td style=' white-space: initial; height: 100%; border: 1px solid blue; text-align: center;"
                                    + " width:" + 18 + "% !important;'></td>";
                    }
                    row = row + lesCell;
                }
                html +=  row + tre;
            }
            html += "</table></body></html>";


         /*   PdfGenerateConfig pdfConfig = new PdfGenerateConfig();
            pdfConfig.PageSize = PdfSharp.PageSize.A3;
            pdfConfig.PageOrientation = PdfSharp.PageOrientation.Landscape;
            PdfSharp.Pdf.PdfDocument pdf = PdfGenerator.GeneratePdf(html, pdfConfig);*/
            var now = DateTime.Now;
            var path = "";
            if (GlobalData.Path4People == "")
                path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString() + "\\LessonsScheduler\\pl";
            else
                path = GlobalData.Path4People + "\\";
            try
            {
                if (!Directory.Exists(path))
                {
                    //path = Environment.SpecialFolder.MyDocuments.ToString();
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            try
            {
                //var fileName = "planIds d" + now.Day + " h" + now.Hour + " m" + now.Minute + " s" + now.Second + " " + perName;
                if (printHtml)
                    File.WriteAllText(path + perName + " " + now.Year + "-" + now.Month + "-" + now.Day + ".html", html);
                if (printPdf)
                {
                    IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();

                    Renderer.PrintOptions.PaperSize = PdfPrintOptions.PdfPaperSize.A3;
                    Renderer.PrintOptions.PaperOrientation = PdfPrintOptions.PdfPaperOrientation.Landscape;
                    Renderer.PrintOptions.MarginTop = 5;  //millimeters
                    Renderer.PrintOptions.MarginBottom = 5;
                    Renderer.PrintOptions.MarginRight = 5;
                    Renderer.PrintOptions.MarginLeft = 2;
                    Renderer.PrintOptions.FitToPaperWidth = true;
                    Renderer.RenderHtmlAsPdf(html).SaveAs(path + perName + " " + now.Year + "-" + now.Month + "-" + now.Day + ".pdf");
                }
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
        /***********************************************************************/


        static public string CreateDocument(List<LessonModel> lessonsArg, bool printPfd = true, bool printHtml = true, bool printInfo = true)
        {
            if (lessonsArg.Count == 0)
                return "";
            var Lessons = lessonsArg.OrderBy(l => l.DayNo).ThenBy(l => l.HourNo).ThenBy(l => l.SlotNo).ToList();
            GroupModel _group = GlobalConfig.Connection.GetGroup(-1, Lessons[0].GroupId)[0];
            int[] subgroupsCnt = GlobalConfig.Connection.GetCntOfSubgroups(_group.Id);

            var html = "<html style='width: 99%;'><head><meta charset='UTF-8'><title>Lessons Scheduler</title></head><body style='width: 100%;'>";
            html += "<h2 style='padding-left:30px;'>" + _group.Name + " " + _group.Year + "</h2>";
            html += "<table style='border: 1px solid rgb(0, 0, 0); width: 100%; color:black;' >";

            html += "<tr><th style = 'width: 5%;'></th>" 
                + th + "Poniedziałek" + the + th + "Wtorek" + the + th + "Środa" + the + th + "Czwartek" + the + th + "Piątek" + the + tre;

            var totalLessonCnt = 0;
            for (var i = 0; i < 7; i++) // hour
            {
                var rowLessons = Lessons.FindAll(l => l.HourNo == i).OrderBy(l => l.DayNo).ThenBy(l => l.SlotNo);
                var row = tr + td + GlobalData.GetHourTime(i) + tde;
                for (int j = 0; j < 5; j++) // day
                {
                    List<LessonModel> hourLessons = ((rowLessons).ToList().Where(rL => rL.DayNo == j)).ToList();//.OrderBy(rL => rL.SlotNo).ToList();
                    totalLessonCnt += hourLessons.Count;
                    var hourCell = td + "<table style='width: 100%; height: 70px;  font-size:10px;' ><tr>";

                    if (hourLessons.Count() > 0)
                    {
                        LessonDetailsModel _lessonTmp = new LessonDetailsModel(hourLessons.First());
                        double width = (double)100.0 / subgroupsCnt[_lessonTmp.Subject.Type - 1];
                        for (int k = 0; k < subgroupsCnt[_lessonTmp.Subject.Type - 1]; k++)
                        {
                            LessonModel les = null;
                            foreach (var item in hourLessons)
                            {
                                if (item.SlotNo == k)
                                    les = item;
                            }
                            if (les != null)
                            {
                                LessonDetailsModel _lesson = new LessonDetailsModel(les);
                                string lesCell = "<td style=' white-space: initial; height:70px; text-align: center;  background-color:"
                                    + _lesson.Subject.CellColor + ";"
                                    + " width:" + width + "% !important;'>"
                                    + _lesson.Subject.FullName + br
                                    + _lesson.Teacher.FullName + br
                                    + _lesson.Room.RoomNo + " "
                                    + _lesson.Room.Wing
                                    //+ " d:" + les.DayNo + br + " h:" + les.HourNo + " s:" + les.SlotNo
                                    + "</td>";
                                hourCell += lesCell;
                            }
                            else
                            {
                                string lesCell = "<td style=' white-space: initial; height: 70px; text-align: center; width:" + width + "% !important;'></td>";
                                hourCell += lesCell;
                            }
                        }
                    }
                    else
                    {
                        string lesCell = "<td style=' white-space: initial; height: 70px; text-align: center; width:" + 19 + "% !important;'></td>";
                        hourCell += lesCell;
                    }

                    hourCell += "</tr></table>" + tde;
                    row += hourCell;
                }

                row += tre;
                html += row;
            }
            html += "</table></body></html>";

            var now = DateTime.Now;
            var path = "";
            if (GlobalData.Path4Groups == "")
                path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString() + "\\LessonsScheduler\\gr\\" ;
            else
                path = GlobalData.Path4Groups + "\\";
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
            }
            catch (Exception e)
            {
                return e.Message;
            }
            try
            {
                if (printHtml)
                {
                    var _path = path + _group.FullName + " " + now.Year + "-" + now.Month + "-" + now.Day + ".html";
                    File.WriteAllText(_path, html);
                }
                if (printPfd)
                {
                    IronPdf.HtmlToPdf Renderer = new IronPdf.HtmlToPdf();

                    Renderer.PrintOptions.PaperSize = PdfPrintOptions.PdfPaperSize.A4;
                    Renderer.PrintOptions.PaperOrientation = PdfPrintOptions.PdfPaperOrientation.Landscape;
                    Renderer.PrintOptions.MarginTop = 5;  //millimeters
                    Renderer.PrintOptions.MarginBottom = 5;
                    Renderer.PrintOptions.MarginRight = 5;
                    Renderer.PrintOptions.MarginLeft = 5;
                    Renderer.PrintOptions.FitToPaperWidth = true;
                    var _path = path + _group.Name + " " + now.Year + "-" + now.Month + "-" + now.Day + "I" + now.Hour + now.Minute + now.Second + ".pdf";
                    Renderer.RenderHtmlAsPdf(html).SaveAs(_path);
                    // pdf.Save(_path);
                    //System.Diagnostics.Process.Start(_path);
                }
                if (printInfo)
                {
                    var summary = GlobalConfig.Connection.PrepareSummary(_group.Id);
                    var _path = path + _group.FullName + " " + now.Year + "-" + now.Month + "-" + now.Day + ".txt";
                    File.WriteAllText(_path, summary);
                }
                return "OK";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
