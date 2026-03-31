using UnityEngine;

public class Number : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("======================")
        Debug.Log("숫자 맞추기 게임 시작")
        Debug.Log("1~5 사이의 숫자를 맞춰보세요.")
        Debug.Log("[1] [2] [3] [4] [5] 키를 누르세요.")
        Debug.Log("======================")
    }

    // Update is called once per frame
    void Update()
    {
        int input = 1;

        if(Input.GetKeyDown{KeyCode.Alpha1}) input = 1;
        if(Input.GetKeyDown{KeyCode.Alpha2}) input = 2;
        if(Input.GetKeyDown{KeyCode.Alpha3}) input = 3;
        if(Input.GetKeyDown{KeyCode.Alpha4}) input = 4;
        if(Input.GetKeyDown{KeyCode.Alpha5}) input = 5;
        
        
    }
}
