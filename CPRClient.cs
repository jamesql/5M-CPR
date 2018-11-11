using static CitizenFX.Core.Native.API;
using CitizenFX.Core;
using System;
using CitizenFX.Core.Native;
using System.Collections.Generic;

namespace CPR.Client
{
    public class ClientScript : BaseScript
    {
        Random rand = new Random();
        public ClientScript()
        {
            // Events
            EventHandlers.Add("startcpr", new Action<int, int>(revive));
            // Commands
            API.RegisterCommand("cpr", new Action<int, List<object>, string>(cprCommand), false);
        }
        private void cprCommand(int source, List<object> arguments, string content)
        {
            int selfId = GetPlayerServerId(source);
            // gets argument
            int selectId = (int)arguments[0];
            // checks if null
            if (selectId !=  0)
            {
                // start cpr on this ped
                // Finish this method
                //AttachEntityToEntity(source, GetPlayerFromServerId(selectId));
                TriggerEvent("startcpr", selfId, selectId);
            }
            else
            {
                //  find nearest ped then start cpr
            }
        }
        //
        private void revive(int user, int player)
        {
            if (randNum() >  79)
            {

            }
            else
            {

            }
        }
        private int randNum()
        {
            return rand.Next(99) + 1;
        }
    }
}
