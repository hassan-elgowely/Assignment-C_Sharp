using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Seesion02.Models;
using System.Reflection.Emit;

namespace Seesion02.Controllers
{
    //- (controller ) inherit from(controller-base ) and API inherit from(controller base )
    //- (controller base ) : has behavior shared with ⇒ API controller,⇒ MVC controller
    //- why layer(controller ) ⇒ has behavior related to View and API didn’t have View
    //                            EX : value Type inherit from **`System.ValueType`** (layer )
    //                                 and**`System.ValueType`** inherit from**`System.Object`**
    public class MoviesController : Controller  // MVC controler
    {
        // Action
        // Base-URL/Controller/Action
        // loacal5000/movies/GetMovie
        //[HttpGet] default
        //[HttpPost] 
        //public void GetMovie(int? Id , string name)
        //{
            
        //}
        // each action named index ==> called master action
        public string Index()
        {
            return $"Master Action";
        }
        [HttpGet]
        //public string GetMovie(int? id , string name)
        //{
        //    return $"movie ID: {id} </br> movie Name: {name} ";
        //}
        //public ContentResult GetMovie(int? id, string name)
        //{
        //    ContentResult cr = new ContentResult();
        //    cr.StatusCode = StatusCodes.Status200OK;
        //    cr.ContentType = "text/html";
        //    cr.Content = $"movie ID: {id} </br> movie Name: {name} ";
        //    return cr;
        //}


        //    - use**`ActionResult`**
        //    - parent of all helper & it concrete class 
        //    - and prefer to use **`IActionResult` ⇒ General Scoop**
        //    - other types implement interface  , it not all inherit from**`ActionResult`**
        //      EX : **`BadRequest()`;** not implement **`IActionResult` , internally inherit from `ActionResult`** 
        //           and**`ActionResult`  implement `IActionResult` ⇒ General Scoop**

        public IActionResult GetMovie(int? id, string name)
        {
            if (id == null || id == 0)
                return BadRequest();
            else if (id < 10)
                return NotFound();
            else
                return Content(content: $"movie ID: {id} </br> movie Name: {name} ", contentType: "text/html"/*, StatusCode: StatusCodes.Status202Accepted*/);
        }
        //public IActionResult TestRedirect()
        //{
        //    //return Redirect("https://www.google.com/url?sa=t&source=web&rct=j&opi=89978449&url=https://www.google.com/&ved=2ahUKEwjB-Y-Lw_iPAxVcTKQEHQcNMSEQFnoECA4QAQ&usg=AOvVaw1xDfJh-YduXzT4-Mrql0P3");
        //    //return RedirectToAction(controllerName: "movies", actionName: nameof(GetMovie), routeValues: new { id = 77 , name = 777 });
        //    return RedirectToRoute(routeName: "default" , routeValues:new { Action = "index" , Controller = "movies"  });
        //}
        [HttpPost]
        public IActionResult TestModelBinding([FromHeader]int? id ,[FromHeader] string name ,[FromBody]Movie m,int[] arr)
        {
             return Content(content: "");
        }
    }
}
