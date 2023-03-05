using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrianTile : MonoBehaviour
{
    [SerializeField]
    Vector2Int tilePosition;

    void Start()
    {
        GetComponentInParent<WorldScrolling>().Add(gameObject, tilePosition);

        transform.position = new Vector3(-100, -100, 0);
    }
}
