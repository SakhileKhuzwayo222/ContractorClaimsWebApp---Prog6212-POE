using Microsoft.AspNetCore.Mvc;
using YourProjectNamespace.Models; // Adjust according to your models' namespace
using YourProjectNamespace.Services; // Adjust according to your services' namespace

public class LecturerController : Controller
{
    private readonly ILecturerService _lecturerService;

    public LecturerController(ILecturerService lecturerService)
    {
        _lecturerService = lecturerService;
    }

    public IActionResult AddLecturer()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddLecturer(Lecturer lecturer)
    {
        if (ModelState.IsValid)
        {
            _lecturerService.SaveLecturer(lecturer); // Implement SaveLecturer method in service
            return RedirectToAction("ViewLecturers");
        }
        return View(lecturer);
    }

    public IActionResult ViewLecturers()
    {
        var lecturers = _lecturerService.GetAllLecturers(); // Implement GetAllLecturers method in service
        return View(lecturers);
    }

    public IActionResult EditLecturer(int id)
    {
        var lecturer = _lecturerService.GetLecturerById(id); // Implement GetLecturerById method in service
        return View(lecturer);
    }

    [HttpPost]
    public IActionResult EditLecturer(Lecturer lecturer)
    {
        if (ModelState.IsValid)
        {
            _lecturerService.UpdateLecturer(lecturer); // Implement UpdateLecturer method in service
            return RedirectToAction("ViewLecturers");
        }
        return View(lecturer);
    }

    public IActionResult DeleteLecturer(int id)
    {
        _lecturerService.DeleteLecturer(id); // Implement DeleteLecturer method in service
        return RedirectToAction("ViewLecturers");
    }
}

