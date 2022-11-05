using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    DungeonGenerator _dungeonGenerator;

    public GameObject generator;
    public GameObject checkpointPrefab;

    // Start is called before the first frame update
    void Start()
    {
        _dungeonGenerator = GameObject.FindObjectOfType<DungeonGenerator>();
        _dungeonGenerator.StartMazeGeneration();
        if (_dungeonGenerator.isMazeDone)
        {
            GameObject checkpoint = GameObject.Instantiate(checkpointPrefab, _dungeonGenerator.endPoint, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
