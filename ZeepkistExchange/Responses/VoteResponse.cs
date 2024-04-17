using ZeepSDK.Chat;

namespace ZeepkistExchange.Responses;

public class VoteResponse
{
    public void Handle(string arguments)
    {
        ChatApi.SendMessage(arguments);
    }
}