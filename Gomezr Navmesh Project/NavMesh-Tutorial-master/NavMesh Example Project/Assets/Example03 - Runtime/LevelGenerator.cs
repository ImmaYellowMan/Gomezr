using UnityEngine;
using UnityEngine.AI;

public class LevelGenerator : MonoBehaviour
{

    public NavMeshSurface surface;
	public int width = 10;
	public int height = 10;

	public GameObject wall;
	public GameObject player;
    public GameObject enemy;
    public GameObject portal;

	private bool playerSpawned = false;

	// Use this for initialization
	void Start () {
		GenerateLevel();

        surface.BuildNavMesh();
	}
	
	// Create a grid based level
	void GenerateLevel()
	{
		// Loop over the grid
		for (int x = 0; x <= width; x+=2)
		{
			for (int y = 0; y <= height; y+=2)
			{
                // Should we place a wall?
                if (Random.value > .8f)
                {
                    // Spawn a wall
                    Vector3 pos = new Vector3(x - width / 2f, 1f, y - height / 2f);
                    Instantiate(wall, pos, Quaternion.identity, transform);
                }
                else if (!playerSpawned) // Should we spawn a player?
                {
                    // Spawn the player, enemy, and the portal to win
                    Vector3 pos = new Vector3(x - width / 2f, 1.25f, y - height / 2f);
                    Instantiate(player, pos, Quaternion.identity);
                    Vector3 pos2 = new Vector3(x - width / -2f, -1.25f, y - height / -2f);
                    Instantiate(enemy, pos2, Quaternion.identity);
                    Vector3 pos3 = new Vector3(x - width / -2f, 1.25f, y - height / -2f);
                    Instantiate(portal, pos3, Quaternion.identity);
                    playerSpawned = true;
                }
                
			}
		}
	}

}