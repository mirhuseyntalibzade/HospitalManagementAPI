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
    public class InsuranceRepository : GenericRepository<Insurance>, IInsuranceRepository
    {
        readonly AppDbContext _context;
        public InsuranceRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Insurance> GetInsuranceByIdWithPatients(int Id)
        {
            return await _context.Insurances.Include(p => p.Patients)
                .FirstOrDefaultAsync(g=>g.Id == Id);
        }
    }
}
