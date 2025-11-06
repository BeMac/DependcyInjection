using DependcyInjection.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DependcyInjection.Controllers;

public class HomeController : Controller
{
    private readonly IStudentRepository? _repository = null;
    
    public HomeController(IStudentRepository repository)
    {
        _repository = repository;
    }
    
    public JsonResult Index()
    {
        List<Student>? allStudentDetails = _repository?.GetAllStudent();
        return Json(allStudentDetails);
    }
    public JsonResult GetStudentDetails(int Id)
    {
        Student? studentDetails = _repository?.GetStudentById(Id);
        return Json(studentDetails);
    }
}