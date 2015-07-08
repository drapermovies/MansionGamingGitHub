//Created by Joel Draper for MansionGaming.
#pragma strict

var Target : Transform;
var Distance = -222;
var height = 1;

function Update () {
    transform.position = Target.position + Vector3(0, -1, -250); //The camera tracks the players exact position but the player is 10 away from the camera

    transform.LookAt (Target);
}