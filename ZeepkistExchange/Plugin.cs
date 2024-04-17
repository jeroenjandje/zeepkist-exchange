using BepInEx;
using HarmonyLib;
using ZeepkistExchange.commands;
using ZeepSDK.ChatCommands;

namespace ZeepkistExchange;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
[BepInDependency("ZeepSDK")]
public class Plugin : BaseUnityPlugin
{
    private Harmony harmony;

    private void Awake()
    {
        harmony = new Harmony(MyPluginInfo.PLUGIN_GUID);
        harmony.PatchAll();
        
        ChatCommandApi.RegisterLocalChatCommand<VotePlusCommand>();
        ChatCommandApi.RegisterLocalChatCommand<VotePlus2Command>();
        ChatCommandApi.RegisterLocalChatCommand<VotePlus3Command>();
        ChatCommandApi.RegisterLocalChatCommand<VoteMinusCommand>();
        ChatCommandApi.RegisterLocalChatCommand<VoteMinus2Command>();
        ChatCommandApi.RegisterLocalChatCommand<VoteMinus3Command>();

        // Plugin startup logic
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
    }

    private void OnDestroy()
    {
        harmony?.UnpatchSelf();
        harmony = null;
    }
}