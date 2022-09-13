using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DS1h_292_H2 : SimTemplate //* 稳固射击 Steady Shot
//<b>Hero Power</b>Deal $2 damage to the enemy hero.@<b>Hero Power</b>Deal $2 damage.
//<b>英雄技能</b>对敌方英雄造成$2点伤害。@<b>英雄技能</b>造成$2点伤害。 
	{
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getHeroPowerDamage(2) : p.getEnemyHeroPowerDamage(2);
            if (target == null) target = ownplay ? p.enemyHero : p.ownHero;
            p.minionGetDamageOrHeal(target, dmg);
		}		
		
		
		

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_MINION_OR_ENEMY_HERO),
                new PlayReq(CardDB.ErrorType2.REQ_STEADY_SHOT),
            };
        }
	}
}
