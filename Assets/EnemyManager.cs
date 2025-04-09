using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    private void Start()
    {
        Enemy[] allEnemies = Object.FindObjectsByType<Enemy>(FindObjectsSortMode.None);

        foreach (Enemy enemy in allEnemies)
        {
            if (enemy.HasTag("flying"))
            {
                Debug.Log($"{enemy.name} uçan dü?man.");
            }

            if (enemy.HasTag("explosive"))
            {
                Debug.Log($"{enemy.name} patlayan dü?man.");
            }

            if (enemy.HasTag("boss"))
            {
                Debug.Log($"{enemy.name} boss dü?man.");
            }
        }
    }
}


