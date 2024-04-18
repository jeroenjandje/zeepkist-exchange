using System;
using ZeepSDK.ChatCommands;

namespace ZeepkistExchange.commands;

public class HelpCommand : ILocalChatCommand
{
    public static Action OnHandle;
    public string Prefix => "/";
    public string Command => "vote help";
    public string Description => "Vote help";
    public void Handle(string arguments)
    {
        OnHandle?.Invoke();
    }
}