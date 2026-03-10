
using UnityEditor.ShortcutManagement;
using UnityEngine;
using UnityEngine.AI;

public class UI : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public GameObject panel;

    public GameObject key;

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
        enemy.SetActive(false);
        Debug.Log("Enemy active: "+enemy.activeSelf);
        panel.SetActive(false);
        key.SetActive(true);
        PauseController.setPause(false);
        
    }
}
