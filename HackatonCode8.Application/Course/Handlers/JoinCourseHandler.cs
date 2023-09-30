using HackatonCode8.Application.Common.Interfaces;
using HackatonCode8.Application.DTOs;
using HackatonCode8.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonCode8.Application.Course.Handlers
{
    public class JoinCourseHandler : IRequestHandler<JoinDto, Response>
    {
        private readonly IApplicationDbContext _context;
        public JoinCourseHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public Task<Response> Handle(JoinDto request, CancellationToken cancellationToken)
        {
            User user = new()
            {
                Name = request.User.Name,
                Email = request.User.Email,
                BirthDate = request.User.BirthDate,
                Gender = request.User.Gender,
                AppointmentDate = request.User.AppointmentDate
            };

            Education education = new()
            {
                UniversityName = request.Education.UniversityName,
                Specialty = request.Education.Specialty,
                CurrentGraduateLevel = request.Education.CurrentGraduateLevel,
                GPA = request.Education.GPA
            };

            Interest interest = new()
            {
                EnjoyedSubjects = request.Interest.EnjoyedSubjects,
                Hobbies = request.Interest.Hobbies,
                CareerEnvisionBusiness = request.Interest.CareerEnvisionBusiness
            };
            
            _context.Users.Add(user);
            _context.Education.Add(education);
            _context.Interests.Add(interest);

            _context.SaveChangesAsync();

            return default;
        }
    }
}
