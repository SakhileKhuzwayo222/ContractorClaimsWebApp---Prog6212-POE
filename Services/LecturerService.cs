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

        public Lecturer GetLecturerById(string id)
        {
            return _lecturers.FirstOrDefault(l => l.Id == id) ?? throw new KeyNotFoundException($"Lecturer with id {id} not found.");
        }

        public void UpdateLecturer(Lecturer lecturer)
        {
            var index = _lecturers.FindIndex(l => l.Id == lecturer.Id);
            if (index != -1)
            {
                _lecturers[index] = lecturer;
            }
        }

        public void DeleteLecturer(string id)
        {
            var lecturer = _lecturers.FirstOrDefault(l => l.Id == id);
            if (lecturer != null)
            {
                _lecturers.Remove(lecturer);
            }
        }
    }
}

