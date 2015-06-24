//Created by Joel Draper for MansionGaming.
#pragma strict

var Target : Transform;

function Update () {
    transform.position = Target.position + Vector3(0, 4, 0);
}