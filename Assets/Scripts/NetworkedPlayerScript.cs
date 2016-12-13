﻿using System;
using UnityEngine;
using UnityEngine.Networking;
using UnityStandardAssets.Characters.FirstPerson;


public class NetworkedPlayerScript : NetworkBehaviour
{
	
	public FirstPersonController fpsController;
	public Camera fpsCamera;
	public AudioListener audioListener;
	public ShootingScript shootingScript;

	Renderer[] renderers;

	void Start ()
	{
		renderers = GetComponentsInChildren<Renderer> ();
	}

	public override void OnStartLocalPlayer ()
	{
		fpsController.enabled = true;
		fpsCamera.enabled = true;
		audioListener.enabled = true;
		shootingScript.enabled = true;

		gameObject.name = "LOCAL Player";
		base.OnStartLocalPlayer ();
	}

	//void ToggleRenderer (bool isAlive)
	//{
	//		for (int i = 0; i < renderers.Length; i++)
	//			renderers [i].enabled = isAlive;
	//	}

	//	void ToggleControls (bool isAlive)
	//	{
	//		fpsController.enabled = isAlive;
	//		shootingScript.enabled = isAlive;
	//		fpsCamera.cullingMask = ~fpsCamera.cullingMask;
	//	}
	//
	//[ClientRpc]
	//public void RpcResolveHit ()
	//{
	//		ToggleRenderer (false);

	//		if (isLocalPlayer) {
	//			Transform spawn = NetworkManager.singleton.GetStartPosition ();
	//			transform.position = spawn.position;
	//			transform.rotation = spawn.rotation;
	//
	//		ToggleControls (false);
	//	}

	//	Invoke ("Respawn", 2f);
	//}

	//void Respawn ()
	//{
	//		ToggleRenderer (true);
	//
	//	if (isLocalPlayer)
	//		ToggleControls (true);
	//}
}