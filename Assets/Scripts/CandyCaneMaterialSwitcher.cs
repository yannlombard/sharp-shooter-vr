﻿using UnityEngine;
using System.Collections;

public class CandyCaneMaterialSwitcher : MonoBehaviour
{
	public Material localCaneMaterial;
	public Material notLocalCaneMaterial;

	Renderer candyCaneRenderer;

	void Awake()
	{
		candyCaneRenderer = GetComponent<Renderer>();
		SwitchMaterial(false);
	}

	public void SwitchMaterial(bool isLocalPlayer)
	{
		if (isLocalPlayer)
			candyCaneRenderer.material = localCaneMaterial;
		else
			candyCaneRenderer.material = notLocalCaneMaterial;
	}
}