using AllCoreInOne.Data;
using AllCoreInOne.Services.CurrentUser;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AllCoreInOne.Services.Complaint
{
    public class ComplaintService : IComplaintService
    {
        private ApplicationDbContext DbContext { get; }
        private ICurrentUser CurrentUser { get; }
        public ComplaintService(ApplicationDbContext dbContext, ICurrentUser currentUser)
        {
            DbContext = dbContext;
            CurrentUser = currentUser;
        }

        public async Task<Models.Complaint> CreateComplaint(Models.Complaint model, CancellationToken ct = default)
        {
            DbContext.Add(model);
            await DbContext.SaveChangesAsync(ct);
            return model;
        }

        public async Task<IEnumerable<Models.Complaint>> FetchComplaint(CancellationToken ct = default)
        {
            return await DbContext.Complaints.ToListAsync(ct);
        }
    }
}
