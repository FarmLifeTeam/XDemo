﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Treasure script created by Oussama Bouanani, SoumiDelRio.
 * This script is part of the Unity RTS Engine */

namespace RTSEngine
{
	public class Treasure : MonoBehaviour {

        [SerializeField]
        private ResourceManager.Resources[] content = new ResourceManager.Resources[0]; //the resources to give the faction when it claims this treasure.
        [SerializeField]
        private AudioClip claimAudio = null; //audio played when the treasure is claimed by a faction
        [SerializeField]
        private EffectObj claimEffect = null; //effect spawned when the treasure is claimed

        //a method called to assign the treasure for a faction
        public void Trigger (int factionID, GameManager gameMgr)
        {
            gameMgr.ResourceMgr.UpdateRequiredResources(content, true, factionID); //add the treasure's resources

            if(factionID == GameManager.PlayerFactionID) //if this is the local player's faction then play the claim audio
                AudioManager.Play(gameMgr.GetGeneralAudioSource(), claimAudio, false);

            if (claimEffect == null) //if there's no effect object, stop here
                return;

            gameMgr.EffectPool.SpawnEffectObj(claimEffect, transform.position, Quaternion.identity); //spawn the claim effect object
        }
	}
}