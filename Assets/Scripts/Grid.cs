using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public enum PieceType
    {
        NORMAL,
        COUNT,
    }

    [System.Serializable] // to make the custom struct show in the inspector
    public struct PiecePrefab
    {
        public PieceType type;
        public GameObject prefab;
    }
    public int xDim;
    public int yDim;

    public PiecePrefab[] piecePrefabs;

    private Dictionary<PieceType, GameObject> piecePrefabDict;


    // Start is called before the first frame update
    void Start()
    {
        // copy the piece prefab array from the inspector into the dictionary array by instantiating a new dictionary
        piecePrefabDict = new Dictionary<PieceType, GameObject>();
        // loop through the dictionary
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
