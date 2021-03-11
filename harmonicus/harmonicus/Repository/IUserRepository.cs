using harmonicus.Data.VO;
using harmonicus.Model;

namespace harmonicus.Repository
{
    public interface IUserRepository
    {
        User ValidadeCredentials(UserVO user);
        User ValidadeCredentials(string username);

        bool RevokeToken(string username);

        User RefreshUserInfo(User user);
    }
}
