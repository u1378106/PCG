using UnityEngine;

[CreateAssetMenu(menuName = "Room Data")]
public class RoomData : ScriptableObject
{
    public GameObject room;
    public Vector2Int size;
    public int startPos;
    public Vector2 offset;
}
