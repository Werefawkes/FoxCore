using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Foxthorne.Utilities
{
    public class LineOfSight : MonoBehaviour
    {
        public List<Vector3> points = new();
		public LayerMask LayerMask;

        public float GetVisibilityFrom(Vector3 position)
		{
			int hitCount = 0;
			foreach (Vector3 p in points)
			{
				Vector3 target = transform.position + p;
				if (!Physics.Raycast(position, target - position, Vector3.Distance(position, target), LayerMask))
				{
					hitCount++;
				}
			}

			Debug.Log(hitCount);
			return (float)hitCount / points.Count;
		}

		private void OnDrawGizmosSelected()
		{
			foreach (Vector3 p in points)
			{
				Gizmos.DrawSphere(transform.position + p, 0.05f);
			}
		}
	}
}
