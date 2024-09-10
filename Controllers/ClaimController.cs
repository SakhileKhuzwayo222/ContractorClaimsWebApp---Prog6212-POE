using Microsoft.AspNetCore.Mvc;
using Contractor_Claims.Models; // Adjust according to your models' namespace
using Contractor_Claims.Services; // Adjust according to your services' namespace


public class ClaimController : Controller
{
    private readonly IClaimService _claimService;

    public ClaimController(IClaimService claimService)
    {
        _claimService = claimService;
    }

    public IActionResult SubmitClaim()
    {
        return View();
    }

    [HttpPost]
    public IActionResult SubmitClaim(Claim claim, IFormFile supportingDocument)
    {
        if (ModelState.IsValid)
        {
            _claimService.SaveClaim(claim, supportingDocument);
            return RedirectToAction("ViewClaims");
        }
        return View(claim);
    }

    public IActionResult ViewClaims()
    {
        var claims = _claimService.GetAllClaims(); // Implement GetAllClaims method in service
        return View(claims);
    }

    public IActionResult EditClaim(int id)
    {
        var claim = _claimService.GetClaimById(id); // Implement GetClaimById method in service
        return View(claim);
    }

    [HttpPost]
    public IActionResult EditClaim(Claim claim)
    {
        if (ModelState.IsValid)
        {
            _claimService.UpdateClaim(claim); // Implement UpdateClaim method in service
            return RedirectToAction("ViewClaims");
        }
        return View(claim);
    }

    public IActionResult DeleteClaim(int id)
    {
        _claimService.DeleteClaim(id); // Implement DeleteClaim method in service
        return RedirectToAction("ViewClaims");
    }
}

