using System;
using ZeepkistClient;
using ZeepSDK.Chat;
using ZeepSDK.ChatCommands;

namespace ZeepkistExchange.commands;

public class VoteMinusCommand : ILocalChatCommand
{
    public static Action<string> OnHandle;
    public string Prefix => "";
    public string Command => "-";
    public string Description => "Vote -1";

    public void Handle(string arguments)
    {
        var username = ZeepkistNetwork.LocalPlayer.Username;
        ChatApi.SendMessage($"{username} voted -1");
        OnHandle?.Invoke(arguments);
    }
}