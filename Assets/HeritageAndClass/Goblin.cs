using UnityEngine;

public class Gobelin : Character, IDestructible
{
    private new int maxHealth = 3;
    private new string characterName = "Giboul";

    private Vector3 currentPosition = Vector3.zero;
    private Vector3 wantedDestination = Vector3.one;


    private void MoveToPoint()
    {
        Move(currentPosition);
        //Do something, then...
        Move(wantedDestination);
    }

    public void Destroy()
    {
        //Destroy the goblin
    }
}