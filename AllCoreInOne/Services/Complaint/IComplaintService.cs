using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AllCoreInOne.Services.Complaint
{
    public interface IComplaintService
    {
        Task<Models.Complaint> CreateComplaint(Models.Complaint model, CancellationToken ct = default);
        Task<IEnumerable<Models.Complaint>> FetchComplaint(CancellationToken ct = default);
    }
}
