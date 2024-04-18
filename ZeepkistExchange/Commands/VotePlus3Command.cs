using System;
using ZeepSDK.ChatCommands;

namespace ZeepkistExchange.commands;

public class VotePlus3Command : ILocalChatCommand
{
    public static Action<string> OnHandle;
    public string Prefix => "";
    public string Command => "+++";
    public string Description => "Vote +3";

    public void Handle(string arguments)
    {
        OnHandle?.Invoke(arguments);
    }
}