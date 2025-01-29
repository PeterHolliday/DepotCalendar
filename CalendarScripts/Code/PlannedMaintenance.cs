using CalendarScripts.Models;

namespace CalendarScripts.Code
{
    public class PlannedMaintenance
    {
        public List<PM> GetPlannedMaintenance()
        {
            List<PM> result = new List<PM>();
            int count = 1;

            string path = "C:\\Users\\peter.holliday\\OneDrive - FM Conway Ltd\\DiaryScripts\\PlannedMaintenance.csv";
            string[] lines = File.ReadAllLines(path);

            foreach(string line in lines)
            {
                if (count > 1)
                {
                    string[] columns = line.Split(',');
                    PM pm = new PM();
                    pm.PMDate = DateTime.Parse(columns[0]);
                    pm.PlantId = Convert.ToInt32(columns[3]);

                    result.Add(pm);
                }

                count++;
            }

            return result;
        }

        public void CreatePMScript(List<PM> pmList)
        {
            string sqlTemp = @"insert into depot_diary_event(DDE_DATE, DDE_DEPOT_REFERENCE, DDE_ENTRY_TYPE, DDE_EMP_ENTERED_BY, DDE_WHEN_ENTERED, DDE_START_HR, DDE_END_HR, DDE_DIARY_REF) values ('{0}', {1}, 'P', 8314, sysdate, '0000', '2400', diary_seq.nextval);";
            string outfile = @"C:\Users\peter.holliday\OneDrive - FM Conway Ltd\DiaryScripts\Jan25\pm_script.sql";

            if (!File.Exists(outfile))
            {
                File.Delete(outfile);
            }

            foreach (PM pm in pmList)
            {
                string sql = string.Format(sqlTemp, pm.PMDate, pm.PlantId);
                using (StreamWriter sw = File.AppendText(outfile))
                {
                    sw.WriteLine(sql);
                }
            }
        }
    }
}
