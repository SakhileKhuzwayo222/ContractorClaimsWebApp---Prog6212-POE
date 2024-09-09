using System.Collections.Generic;
using System.Linq; // For LINQ methods like FirstOrDefault
using Contractor_Claims.Models; // Adjust to your Models namespace

namespace Contractor_Claims.Services
{
    public class LecturerService : ILecturerService
    {
        private readonly List<Lecturer> _lecturers = new List<Lecturer>(); // Placeholder for storing lecturers

        public void SaveLecturer(Lecturer lecturer)
        {
            _lecturers.Add(lecturer);
        }

        public IEnumerable<Lecturer> GetAllLecturers()
        {
            return _lecturers;
        }

        public Lecturer GetLecturerById(int id)
        {
            return _lecturers.FirstOrDefault(l => l.Id == id); // Assuming Lecturer has an Id property
        }

        public void UpdateLecturer(Lecturer lecturer)
        {
            // Logic to update a lecturer
        }

        public void DeleteLecturer(int id)
        {
            var lecturer = _lecturers.FirstOrDefault(l => l.Id == id);
            if (lecturer != null)
            {
                _lecturers.Remove(lecturer);
            }
        }
    }
}

