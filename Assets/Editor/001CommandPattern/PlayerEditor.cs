using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(Player))]
public class PlayerEditor : Editor
{
    [DrawGizmo(GizmoType.Selected | GizmoType.NonSelected)]
    static void DrawGizmosSelected(Player myPlayer, GizmoType gizmoType)
    {
        Gizmos.DrawWireSphere(myPlayer.groundCheck.transform.position, myPlayer.checkRadius);
    }

    private void OnSceneGUI()
    {
        Player myPlayer = (Player)target;
        var transform = myPlayer.groundCheck.transform;

        myPlayer.checkRadius = Handles.RadiusHandle(transform.rotation, transform.position, myPlayer.checkRadius);
    }
}
