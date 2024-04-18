using System;
using ZeepkistClient;
using ZeepSDK.Chat;
using ZeepSDK.ChatCommands;

namespace ZeepkistExchange.commands;

public class VotePlusCommand : ILocalChatCommand
{
    public static Action<string> OnHandle;
    public string Prefix => "";
    public string Command => "+";
    public string Description => "Vote +1";

    public void Handle(string arguments)
    {
        
        var userFullname = ZeepkistNetwork.LocalPlayer.playerTag + ZeepkistNetwork.LocalPlayer.Username;
        ChatApi.SendMessage($"{userFullname} voted +");
        
        OnHandle?.Invoke(arguments);
    }
}