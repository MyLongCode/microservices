using ProfileDal.Roles.Interfaces;
using ProfileDal.Roles.Models;
using ProfileLogic.Roles.Interfaces;
using ProfileLogic.Roles.Models;

namespace ProfileLogic.Users;

/// <inheritdoc />
internal class RoleLogicManager : IRoleLogicManager
{
    private readonly IRoleRepository _roleRepository;

    public RoleLogicManager(IRoleRepository roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public async Task<string> GetRoleNameAsync(Guid userId)
    {
        return await _roleRepository.GetRoleNameAsync(userId);
    }

    public async Task<string> DeleteRoleAsync(Guid userId)
    {
        return await _roleRepository.DeleteRoleAsync(userId);
    }

    public async Task<Guid> CreateRoleAsync(RoleDal role)
    {
        return await _roleRepository.CreateRoleAsync(new RoleDal
        {
            Name = role.Name,
        });
    }
}