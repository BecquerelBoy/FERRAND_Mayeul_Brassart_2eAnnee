using JetBrains.Annotations;
using UnityEngine;

public class Wizard : Character
{
    private new int maxHealth = 10;
    private new string characterName = "Harry";

    private int manaPoints = 15;

    public override void Move(Vector3 input)
    {
        //Method to move around with keyboard action
    }

    public void CastFireball(IDestructible[] destructibleArray)
    {
        //Fireball destroy all element from destructibleArray
    }
}