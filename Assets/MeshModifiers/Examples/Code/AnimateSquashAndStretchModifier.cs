﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (SquashAndStretchModifier))]
public class AnimateSquashAndStretchModifier : MonoBehaviour
{
	private SquashAndStretchModifier sas;

	private void Start ()
	{
		sas = GetComponent<SquashAndStretchModifier> ();
	}
	private void Update ()
	{
		sas.amount = Mathf.Sin (Time.time * 2f) / 2f;
	}
}