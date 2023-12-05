using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OurFirstApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        //So now these are part of our IndexModel (View Model)
            //We can go to the front end and access them
            //you can add as many properties as you want here and be able to access them on the View
        public List<Employee> EmployeeList {get;set;}
        public List<Department> Departments {get;set;}

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string? Message { get; set; }
        


        public void OnGet()
        {
            Message = $"Hello World {DateTime.Now.ToLongTimeString()}";

            //Here we could use our Db Context, to call out and get the values to populate our EmployeeList and Departments just like we do on all the scaffolded pages for the individual database table
        }
    }
}