using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* One Shot State Machine script created by Oussama Bouanani, SoumiDelRio.
 * This script is part of the Unity RTS Engine */

namespace RTSEngine
{
	public class MovementStateMachine : StateMachineBehaviour {

		//allows the unit to know when it enters and exists the movement state
		override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
			animator.SetBool ("InMvtState", true);
        }

		//allows the unit to know when it enters and exists the movement state
		override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
			animator.SetBool ("InMvtState", false);
        }
	}
}
