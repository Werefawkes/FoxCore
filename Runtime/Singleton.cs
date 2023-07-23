using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Foxthorne.Utilities
{
	public abstract class Singleton<T> : MonoBehaviour where T : Singleton<T>
	{
		public static T Instance { get; private set; }

		[Header("Singleton")]
		public bool Persistent = true;

		protected virtual void Awake()
		{
			if (Instance != null && Instance != this)
			{
				Debug.Log("Duplicate singleton " + typeof(T).Name + " found, destroying");
				Destroy(gameObject);
				return;
			}
			else
			{
				DontDestroyOnLoad(this);
				Instance = this as T;
			}
		}
	}
}
