using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Smash
{
    public class ICharacterController
    {
        public interface ICharacter
        {
            void SetCharacter(ICharacter character);
            void Logic(float frameTime);
        }

    }
    public class CPUController : ICharacterController
    {
        public void SetCharacter(ICharacter character)
        {
            throw new NotImplementedException();
        }

        public void Logic(float frametime)
        {
            throw new NotImplementedException();
        }
        
    }
    public class PlayerController : ICharacterController
    {
        IInputDevice InputDevice;
        public PlayerController(IInputDevice inputKey)
        {
            this.InputDevice = inputKey;
        }

        public void SetCharacter(ICharacter character)
        {
            //Player selects character who he/she wants to play
            throw new NotImplementedException();
        }

        public void Logic(float frametime)
        {
            if (InputDevice.IsDown(GameButton.HIT))
            {
                //It will hit the CPU
            }
            if (InputDevice.IsDown(GameButton.DODGE))
            {
                // Dodge the CPU
            }
            if (InputDevice.IsDown(GameButton.JUMP))
            {
                //jump the player
            }
        }

        
    }
}



  


