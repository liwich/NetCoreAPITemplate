using System.Collections.Generic;
using System.Threading.Tasks;
using Training.DTO;

namespace Training.API.Contracts
{
    public interface IUsersRepository
    {
        Task<List<User>> GetAll();

        Task<User> Create(UserSignup user);

        Task<bool> Exists(UserSignup user);
    }
}
