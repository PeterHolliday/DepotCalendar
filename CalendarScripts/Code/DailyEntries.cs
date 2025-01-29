using CalendarScripts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarScripts.Code
{
    public class DailyEntries
    {
        //public void CreateScripts(List<Depot> depots, List<PM> pmList, List<Saturday> sats)
        public void CreateScripts(List<Depot> depots)
        {
            string sqlTemp = "insert into depot_diary_event(DDE_DATE, DDE_DEPOT_REFERENCE, DDE_ENTRY_TYPE, DDE_EMP_ENTERED_BY, DDE_WHEN_ENTERED, DDE_START_HR, DDE_END_HR, DDE_DIARY_REF, DDE_START_HR_2, DDE_END_HR_2) values ('{0}', {1}, 'N', 8314, sysdate, '{2}', '{3}', diary_seq.nextval, '{4}', '{5}');";
            string outputFileTemp = "C:\\Users\\peter.holliday\\OneDrive - FM Conway Ltd\\DiaryScripts\\Jan25\\{0}_{1}.sql";
            string outputFile;

            string sql;

            string suffix = DateTime.Now.ToString("yyMMdd");

            foreach (Depot d in depots)
            {
                DateTime thisDay = DateTime.Now;
                outputFile = string.Format(outputFileTemp, d.Name, suffix);

                if (File.Exists(outputFile))
                {
                    File.Delete(outputFile);
                }

                using (StreamWriter sw = File.AppendText(outputFile))
                {

                    while (thisDay <= new DateTime(2023, 4, 1))
                    {
                        //var checkPM = pmList.Where(x => x.PMDate.Date == thisDay.Date && x.PlantId == d.Id);
                        //if (!checkPM.Any())
                        //{
                           var checkDay = d.Openings.Where(x => x.Day == thisDay.ToString("dddd")).FirstOrDefault();
                            //if (thisDay.ToString("dddd") == "Saturday")
                            //{
                            //    var checkSat = sats.Where(x => x.PlantId == d.Id && x.date.Date == thisDay.Date).FirstOrDefault();
                            //    if (checkSat != null)
                            //    {
                            //        sql = string.Format(sqlTemp, thisDay.ToString("dd-MMM-yy"), d.Id, checkDay.ClosedFrom, checkDay.OpensAt, checkDay.ClosesAt, checkDay.ClosedUntil);
                            //    }
                            //    else
                            //    {
                            //        sql = string.Format(sqlTemp, thisDay.ToString("dd-MMM-yy"), d.Id, "0000", "2400", string.Empty, string.Empty);
                            //    }

                            //    //Console.WriteLine(thisDay.ToString() + " - Saturday entry exists");
                            //}
                            //else
                            //{
                            //    //Console.WriteLine(thisDay.ToString());
                            //    sql = string.Format(sqlTemp, thisDay.ToString("dd-MMM-yy"), d.Id, checkDay.ClosedFrom, checkDay.OpensAt, checkDay.ClosesAt, checkDay.ClosedUntil);
                            //}

                            //Console.WriteLine(thisDay.ToString());
                            sql = string.Format(sqlTemp, thisDay.ToString("dd-MMM-yy"), d.Id, checkDay.ClosedFrom, checkDay.OpensAt, checkDay.ClosesAt, checkDay.ClosedUntil);
                            sw.WriteLine(sql);


                        //}
                        thisDay = thisDay.AddDays(1);
                    }
                }
            }

        }
    }
}
