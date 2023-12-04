using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Foxthorne.Utilities
{
    public class LineOfSight : MonoBehaviour
    {
        public List<Vector3> points = new();

        public float VisibilityFrom(Vector3 position)
		{
			throw new NotImplementedException();
		}

		private void OnDrawGizmosSelected()
		{
			foreach (Vector3 p in points)
			{
				Gizmos.DrawSphere(transform.position + p, 0.1f);
			}
		}
	}
}
