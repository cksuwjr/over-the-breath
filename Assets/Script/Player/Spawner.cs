using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;


public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    private void Start()
    {
        if (GameManager.Instance.Player == null)
            PlayerSpawn();
        GameObject.Find("CAM").GetComponent<CinemachineVirtualCamera>().Follow = GameManager.Instance.Player.transform;
        GameManager.Instance.UIManager.SetPlayerUIActive(true);
    }
    public void PlayerSpawn()
    {
        if (playerPrefab != null)
        {
            Instantiate(playerPrefab, transform.position, Quaternion.identity);
        }
    }
    public void PlayerReSpawn()
    {
        var player = GameManager.Instance.Player;
        player.transform.position = transform.position;
        player.gameObject.SetActive(true);
    }
}
