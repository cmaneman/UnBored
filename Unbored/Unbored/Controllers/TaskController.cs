using Microsoft.AspNetCore.Mvc; /*VS Copy*/
using Newtonsoft.Json;
using System.Net;
using System.IO;
using Unbored.Models;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

//https://www.bing.com/search?q=asp.net+get+data+from+controller+to+index&cvid=7c475516b9174a4396f8780e280132f9&aqs=edge..69i57j0l4.22809j0j1&FORM=ANNTA1&PC=HCTS&ntref=1

namespace Unbored.Controllers
{
    public class TaskController : Controller
    {

        // GET: Task
        public IActionResult Index()
        {


            List<Models.Task> TData = GetTasks();

            return View(TData);
        }

        static List<Models.Task> GetTasks()
        {
            string? jsonFile = @"C:\Users\chris\OneDrive\Documents\Unbored\Unbored\Models\LTask.cs";


            if (System.IO.File.Exists(jsonFile))
            {
                Debug.WriteLine("File Exists!!!");

                List<Models.Task>? tasks = JsonConvert.DeserializeObject<List<Models.Task>>(System.IO.File.ReadAllText(jsonFile))!;

                return tasks;
            }
            else
            {
                Debug.WriteLine("File is missing...");
                Environment.Exit(0);
                return null;
            }
        }
    }
}