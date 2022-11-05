using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    DungeonGenerator dungeonGenerator;

    public RoomData nextDungeon;

    private void Start()
    {
        dungeonGenerator = GameObject.FindObjectOfType<DungeonGenerator>();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag.Equals("MainCamera"))
        {
            dungeonGenerator.rooms[0] = (RoomData)(Resources.Load("RoomObjects/Room2"));
            dungeonGenerator.StartMazeGeneration();
        }
    }
}
