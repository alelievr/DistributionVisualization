using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphericalToCartesianCoords : PointVisualization
{
	public override void GeneratePoints()
	{
		points.Clear();

		float r = Mathf.Sqrt(2);

		for (int i = 0; i < numPoints; i++)
		{
			float phi = Random.value * Mathf.PI * 2;
			float theta = Random.value * Mathf.PI;
			
			points.Add(new Vector3(
				r * Mathf.Sin(phi) * Mathf.Cos(theta),
				r * Mathf.Sin(phi) * Mathf.Sin(theta),
				r * Mathf.Cos(phi)
			));
		}
	}
}
