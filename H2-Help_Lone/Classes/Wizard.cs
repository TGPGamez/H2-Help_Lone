using System;
using System.Collections.Generic;
using System.Text;

namespace H2_Help_Lone
{
    public class Wizard : ICharacter, IThrowFrostBolt, IThrowMagicMissile, ITeleport
    {
        public void Die()
        {
            throw new NotImplementedException();
        }

        public void Fight()
        {
            throw new NotImplementedException();
        }

        public void Heal()
        {
            throw new NotImplementedException();
        }

        public void Teleport(int x, int y)
        {
            throw new NotImplementedException();
        }

        public void ThrowFrostNova()
        {
            throw new NotImplementedException();
        }

        public void ThrowMagicMisile()
        {
            throw new NotImplementedException();
        }
    }
}
