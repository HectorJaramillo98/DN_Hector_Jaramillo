using System;
using GymManager.Core.MembershipTypes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManager.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;

namespace GymManager.AplicationsServices.MembershipTypes
{
    public class MembershipTypeAppService : IMembershipTypeAppService
    {
       

        private readonly IRepository<int, MembershipType> _repository;

        public MembershipTypeAppService(IRepository<int, MembershipType> repository)
        {
            _repository = repository;
        }
        public async Task<int> AddMembershipTypesAsync(MembershipType membershipType)
        {
            await _repository.AddAsync(membershipType);
            return membershipType.Id;          
        }

        public async Task DeleteMembershipTypesAsync(int membershipTypesId)
        {
            await _repository.DeleteAsync(membershipTypesId);
        }

        public async Task EditMembershipTypesAsync(MembershipType membershipType)
        {
            await _repository.UpdateAsync(membershipType);
        }

        public async Task<MembershipType> GetMembershipTypeAsync(int membershipTypeId)
        {
            return await _repository.GetAsync(membershipTypeId);
        }

        public async Task<List<MembershipType>> GetMembershipTypesAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }
    }
}
