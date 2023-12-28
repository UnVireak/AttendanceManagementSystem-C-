using System.IO;
using System.Text.Json;

namespace AttendanceManagementSystem.Feature
{
    class TimeSheetDataStorage
    {
        public static void SaveTimeSheetToStorage(TimeSheet AttenList)
        {
            var jsonString = JsonSerializer.Serialize<TimeSheet>(AttenList);
            File.WriteAllText("timesheet.json", jsonString);
        }
        public static TimeSheet LoadTimeSheetFromStorage()
        {
            using FileStream stream = File.OpenRead("timesheet.json");
            if(stream.Length > 0)
            {
                var loadList = JsonSerializer.Deserialize<TimeSheet>(stream);
                return loadList!;
            }
            return new TimeSheet();
        }
    }
}
