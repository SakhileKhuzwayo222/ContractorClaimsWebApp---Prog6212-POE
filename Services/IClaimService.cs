using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Contractor_Claims.Models;

namespace Contractor_Claims.Services // Adjust the namespace to match your project structure
{
    public interface IClaimService
    {
        void SaveClaim(Claim claim, IFormFile supportingDocument);          // Save a new claim
        IEnumerable<Claim> GetAllClaims();    // Retrieve all claims
        Claim GetClaimById(int id);           // Retrieve a claim by its ID
        void UpdateClaim(Claim claim);        // Update an existing claim
        void DeleteClaim(int id);             // Delete a claim by its ID
    }
}

