using CalendarScripts.Models;
using System.Globalization;

namespace CalendarScripts.Code
{
    internal class SaturdayOps
    {
        public void Sat()
        {
            // path to the csv file
            string path = "C:\\Users\\peter.holliday\\OneDrive - FM Conway Ltd\\Documents\\SaturdayScript.csv";
            string sqlTemp = @"insert into depot_diary_event(DDE_DATE, DDE_DEPOT_REFERENCE, DDE_ENTRY_TYPE, DDE_EMP_ENTERED_BY, DDE_WHEN_ENTERED, DDE_START_HR, DDE_END_HR, DDE_DIARY_REF, DDE_START_HR_2, DDE_END_HR_2) values ('{0}', {1}, 'N', 8314, sysdate, '0000', '0600', diary_seq.nextval, '1200', '2400');";
            string sql;
            int count = 1;
            string[] lines = File.ReadAllLines(path);
            string outfile = @"C:\Users\peter.holliday\OneDrive - FM Conway Ltd\DiaryScripts\Aug 22\saturday_script.sql";

            if (!File.Exists(outfile))
            {
                File.Delete(outfile);
            }

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                if (count > 1)
                {
                    sql = string.Format(sqlTemp, columns[0], columns[2]);
                    //Console.WriteLine(sql);
                    using (StreamWriter sw = File.AppendText(outfile))
                    {
                        sw.WriteLine(sql);
                    }
                }
                count++;
            }
        }

        public List<Saturday> SaturdayList()
        {
            //var cultureInfo = new CultureInfo("en-GB");
            List<Saturday> list = new List<Saturday>();
            int count = 1;

            string path = "C:\\Users\\peter.holliday\\OneDrive - FM Conway Ltd\\Documents\\SaturdayScript.csv";
            string[] lines = File.ReadAllLines(path);

            foreach (string line in lines)
            {
                string[] columns = line.Split(',');
                if (count > 1)
                {
                    list.Add(new Saturday { date = DateTime.Parse(columns[0]), PlantId = Convert.ToInt32(columns[2]) });

                }
                count++;
            }
            return list;
        }
    }
}
