
using UnityEngine;
using UnityEngine.AI;

public class UI : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject panel;
    public New_Enemy new_Enemy;
    public GameObject key;
    public Unlock_Gate gate;

    Vector3 playerPos;
    Vector3 enemyPos;

    void Start()
    {
        playerPos = player.transform.position;
        enemyPos = enemy.transform.position;
    }
    public void Exit()
    {
        Debug.Log("Quit");
        Application.Quit();

    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif 
    }

    public void Reset()
    {
        Debug.Log("Reset");
        player.transform.position = playerPos;
        enemy.transform.position = enemyPos;
        gate.ResetKey();
        new_Enemy.resetSpeed();
        enemy.SetActive(false);
        panel.SetActive(false);
        PauseController.setPause(false);
    }
}
