using Microsoft.AspNetCore.Mvc; /*VS Copy*/
using Newtonsoft.Json;
using System.Net;
using System.IO;
using Unbored.Models;

namespace Unbored.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public IActionResult Index()
        {
            var taskjson = System.IO.File.ReadAllLinesAsync(@"C:\Users\chris\OneDrive\Documents\Unbored\Unbored\Data\TaskData.json");

            if (taskjson == null)
            {
                Console.WriteLine("This is null...");
                return View("Error");
            }
            else
            {
                //ITask? mytask = JsonConvert.DeserializeObject<ITask>(taskjson);
                IList<ITask> mytask = JsonConvert.DeserializeObject<IList<ITask>>(taskjson); //error

                return View(taskjson);
            }
        }
    }
}