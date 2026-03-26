using UnityEngine;

public class PlayerController : MonoBehaviour
{
    int playerHP = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("게임이 시작되었어요.");
        Debug.Log(playerHP);
        Debug.Log("플레이어의 체력: " + playerHP);
        Debug.Log($"플레이어의 체력은 {playerHP}입니다.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
