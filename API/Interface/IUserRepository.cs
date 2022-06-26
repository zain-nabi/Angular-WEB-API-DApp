using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interface
{
    public interface IUserRepository
    {
        void Update(ApplicationUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<ApplicationUser>> GetUsersAsync();
        Task<ApplicationUser> GetUserByIDAsync(int id);
        Task<ApplicationUser> GetUserByUsername(string username);
        Task<IEnumerable<MemberDto>> GetMembersAsync();
        Task<MemberDto> GetMemberAsync(string username);
    }
}