
namespace Shared
{
    public enum ClientBound
    {
        LOGIN,
        REGISTER,
        BAN,
        MUTE,
        MESSAGE
    }

    public enum ServerBound
    {
        ON_SUCCESS_LOGIN,
        ON_SUCCESS_REGISTRATION,
        ON_SUCCESS_BAN,
        ON_SUCCESS_MUTE,
        ON_SUCCESS_MESSAGE
    }
}