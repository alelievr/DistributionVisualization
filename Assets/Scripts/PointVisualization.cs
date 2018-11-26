using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PointVisualization : MonoBehaviour
{
	public List< Vector3 >		points;
	public int					numPoints = 50;

	public abstract void GeneratePoints();
}
