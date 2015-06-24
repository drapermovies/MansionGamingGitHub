//Created by Joel Draper for MansionGaming.
#pragma strict

var Target : Transform;
var Distance = -10;

function Update () {
    transform.position = Target.position + Vector3(0, 0, Distance);

    transform.LookAt (Target);
}