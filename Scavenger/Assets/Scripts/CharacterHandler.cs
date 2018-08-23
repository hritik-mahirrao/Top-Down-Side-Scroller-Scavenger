using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterHandler : MonoBehaviour
{
    public enum CharacterWeaponary
    {
        Holster,
        Pistol
    };

    public CharacterWeaponary characterWeaponary;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DetermineWeapon();
    }

    public void DetermineWeapon()
    {
        switch (characterWeaponary)
        {
            case CharacterWeaponary.Pistol:
                break;
        }
    }
}
