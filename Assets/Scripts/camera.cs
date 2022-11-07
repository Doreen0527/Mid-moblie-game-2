using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject target; 
    private Vector3 offset; // 與目標的座標差異

    // Start is called before the first frame update
    void Start()
    {
        // 遊戲開始時，先計算自己與目標的座標差異，並儲存起來
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
          // 遊戲執行時，一直將自己座標設為：目標座標 + 差異數
        transform.position = target.transform.position + offset;
    }
}
