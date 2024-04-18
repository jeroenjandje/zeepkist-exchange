using System;
using ZeepSDK.ChatCommands;

namespace ZeepkistExchange.commands;

public class VotePlus2Command : ILocalChatCommand
{
    public static Action<string> OnHandle;
    public string Prefix => "";
    public string Command => "++";
    public string Description => "Vote +2";

    public void Handle(string arguments)
    {
        OnHandle?.Invoke(arguments);
    }
}