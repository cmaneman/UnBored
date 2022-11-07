using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net;
using Unbored.Model;
using Unbored.Models;

namespace Unbored.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public IActionResult Index()
        {


            using (StreamReader jsonFile = File.OpenText(@"C:\Users\chris\OneDrive\Documents\Unbored\Unbored\Data\TaskData.json"))
            {
                JsonSerializer serializer = new JsonSerializer();

                ITask itask = (ITask)serializer.Deserialize(jsonFile, typeof(ITask));
            }



            return View();
        }
    }
}