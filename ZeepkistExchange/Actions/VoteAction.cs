using ZeepkistExchange.Client;

namespace ZeepkistExchange.Actions;

/**
 * Used to process a vote action
 */
public class VoteAction
{
    public void Handle(string arguments)
    {
        // get which vote command we are using
        // http get request get current level information
        // process vote command
        // http post request post current level information
        // send message, [currentLevel]([levelTotalVotes]): [levelTotalPoints] ([voteCommand]) 
    }
}