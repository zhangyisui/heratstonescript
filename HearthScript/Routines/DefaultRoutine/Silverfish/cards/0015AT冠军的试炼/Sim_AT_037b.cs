using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_AT_037b : SimTemplate //* 并蒂树苗 One, Two, Trees!
//Summon two 1/1 Saplings.
//召唤两个1/1的树苗。 
	{
		
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_037t); 
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            
            p.callKid(kid, place, ownplay, false);
            p.callKid(kid, place, ownplay);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1),
            };
        }
	}
}