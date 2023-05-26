using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MothDetails : MonoBehaviour
{
    // NAMES
    [Header("Names:")]
    [SerializeField] private string commonName;
    [SerializeField] private string scientificName;

    // RARITY
    [Header("Rarity:")]
    Dictionary<string, bool> rarities = new Dictionary<string, bool>()
    {
        {"common", false},
        {"uncommon", false},
        {"rare", false},
        {"epic", false},
        {"legendary", false}
    };
}
