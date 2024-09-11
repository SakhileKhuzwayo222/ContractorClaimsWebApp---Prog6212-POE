using System.Collections.Generic;
using System.Linq;
using Contractor_Claims.Models; // Add this line at the top of the file
using Microsoft.AspNetCore.Http; // Add this line at the top of the file
using System.IO; // Add this line at the top of the file

namespace Contractor_Claims.Services // Adjust the namespace to match your project structure
{
    public class ClaimService : IClaimService
    {
        private readonly ApplicationDbContext _context;

        public ClaimService(ApplicationDbContext context)
        {
            _context = context;
        }

        // Save a new claim
        public void SaveClaim(Claim claim, IFormFile file)
        {
            _context.Claims.Add(claim);
            
            if (file != null && file.Length > 0)
            {
                var fileName = Path.GetFileName(file.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Uploads", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                // Optionally, save the file path to the claim
                claim.FilePath = filePath;
            }

            _context.SaveChanges();
        }

        // Retrieve all claims
        public IEnumerable<Claim> GetAllClaims()
        {
            return _context.Claims.ToList();
        }

        // Retrieve a claim by its ID
        public Claim GetClaimById(int id)
        {
            return _context.Claims.FirstOrDefault(c => c.Id == id);
        }

        // Update an existing claim
        public void UpdateClaim(Claim claim)
        {
            var existingClaim = _context.Claims.FirstOrDefault(c => c.Id == claim.Id);
            if (existingClaim != null)
            {
                existingClaim.Description = claim.Description;
                existingClaim.Amount = claim.Amount;
                existingClaim.DateFiled = claim.DateFiled;
                // Update other fields as necessary

                _context.SaveChanges();
            }
        }

        // Delete a claim by its ID
        public void DeleteClaim(int id)
        {
            var claim = _context.Claims.FirstOrDefault(c => c.Id == id);
            if (claim != null)
            {
                _context.Claims.Remove(claim);
                _context.SaveChanges();
            }
        }
    }
}