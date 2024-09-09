using System.Collections.Generic;

namespace Contractor_Claims.Services // Adjust the namespace to match your project structure
{
    public interface IClaimService
    {
        void SaveClaim(Claim claim);          // Save a new claim
        IEnumerable<Claim> GetAllClaims();    // Retrieve all claims
        Claim GetClaimById(int id);           // Retrieve a claim by its ID
        void UpdateClaim(Claim claim);        // Update an existing claim
        void DeleteClaim(int id);             // Delete a claim by its ID
    }
}

