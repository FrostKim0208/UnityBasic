using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player"); // game object �� ã�Ƽ� ��ü�� ����
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 PlayerPos = player.transform.position; // �÷��̾ �������� ���� ������Ʈ�� ��ġ�� ���
        transform.position = new Vector3(transform.position.x, PlayerPos.y, transform.position.z); // �÷��̾ �������� ������Ʈ�� y ���� ī�޶��� ��ǥ�� �ѱ�
    }
}