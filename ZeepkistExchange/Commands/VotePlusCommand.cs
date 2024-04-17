using System;
using ZeepSDK.ChatCommands;

namespace ZeepkistExchange.commands;

public class VotePlusCommand : ILocalChatCommand
{
    public static Action<string> OnHandle;
    public string Prefix => "/";
    public string Command => "/vote +";
    public string Description => "Vote +1";

    public void Handle(string arguments)
    {
        OnHandle?.Invoke(arguments);
    }
}