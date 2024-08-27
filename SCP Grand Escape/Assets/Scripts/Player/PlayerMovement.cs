using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingControl : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 3.0f;


    private CharacterController _controller;
    [SerializeField]
    private Playerstats _stats;


    void Start()
    {
        _controller = GetComponent<CharacterController>();//���� � ��������� ���� ��� �������� ������� �� ���������� ��������
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        _stats=new Playerstats();
    }

    void Update()
    {
        //���
        if (Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.LeftControl) && _stats.Stamina>=30 && Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A)&& !Input.GetKey(KeyCode.S)&& !Input.GetKey(KeyCode.D))
        {
            _moveSpeed = 6.0f;
        }
        else
        {
            _moveSpeed = 3.0f;
        }


        float horisontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");


        Vector3 moveDeraction = transform.forward * verticalInput + transform.right * horisontalInput;


        moveDeraction.y -= 9.81f * Time.deltaTime;

        _controller.Move(moveDeraction * _moveSpeed * Time.deltaTime);
    }
}
