using System.Collections.Generic;
using Contractor_Claims.Models; // Adjust to your Models namespace

namespace ContractorClaimsProg6212POE.Services
{
    public interface ILecturerService
    {
        void SaveLecturer(Lecturer lecturer);
        IEnumerable<Lecturer> GetAllLecturers();
        Lecturer GetLecturerById(int id);
        void UpdateLecturer(Lecturer lecturer);
        void DeleteLecturer(int id);
    }
}

