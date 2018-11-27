using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(PointVisualization), true)]
public class PointVisualizationEditor : Editor
{
	PointVisualization	pointVisualization;

	private void OnEnable()
	{
		pointVisualization = target as PointVisualization;
	}

	public override void OnInspectorGUI()
	{
		DrawDefaultInspector();

		if (GUILayout.Button("Generate"))
		{
			pointVisualization.GeneratePoints();
			SceneView.RepaintAll();
		}
	}

	void OnSceneGUI()
	{
		var pos = pointVisualization.transform.position;
		if (pointVisualization.points != null)
		{
			foreach (var p in pointVisualization.points)
			{
				Handles.color = new Color(p.x, p.y, p.z, 1);
				Handles.DotHandleCap(0, pos + p, Quaternion.identity, .05f, EventType.Repaint);
			}
		}
	}
}
