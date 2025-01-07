using HospitalManagementCORE.Models;
using HospitalManagementDAL.Contexts;
using HospitalManagementDAL.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementDAL.Repositories.Implementations
{
    public class GenderRepository : GenericRepository<Gender>, IGenderRepository
    {
        readonly AppDbContext _context;
        public GenderRepository(AppDbContext context) : base(context)
        {
            _context = context; 
        }

        public async Task<Gender> GetGenderByIdWithPatients(int Id)
        {
            return await _context.Genders.Include(p => p.Patients)
                .FirstOrDefaultAsync(g => g.Id == Id);
        }
    }
}
