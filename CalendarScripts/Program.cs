using CalendarScripts.Code;
using CalendarScripts.Models;

var otOps = new OpeningTimes();
var satOps = new SaturdayOps();
var pmOps = new PlannedMaintenance();
var dailyOps = new DailyEntries();

List<Depot> depots = otOps.ListOpeningTimes();
List<Saturday> sats = satOps.SaturdayList();
List<PM> pmList = pmOps.GetPlannedMaintenance();

pmOps.CreatePMScript(pmList);
//dailyOps.CreateScripts(depots, pmList, sats);
dailyOps.CreateScripts(depots);
