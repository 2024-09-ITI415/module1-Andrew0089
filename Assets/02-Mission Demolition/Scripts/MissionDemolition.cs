using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
public enum GameMode
{
    idle,
    playing,
    levelEnd
}
public class MissionDemolition : MonoBehaviour
static private MissionDemolition S;

[Header("Setin Inspector")]
public Text uitLevel;
public Text uitShots;
public Text uitButoon;
public Vector3 castlePos;
public GameObject[] castles;

[Header("Set Dynamically")]

public int level;
public int levelMax;
public int shotsTaken;
public GameObject castle;
public GameMode mode = GameMode.idle;
public string showing = "Show Slingshot";
