using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class MovingControl : MonoBehaviour
{
    private float _moveSpeed = 3f;
    [SerializeField]
    private CharacterController _controller;
    [SerializeField]
    private Playerstats _stats;
    private float _gravity = 2.0f;
    private Vector3 _velocity;
    private float _jumpStrenght = 2.0f;




    void Start()
    {
        _controller = GetComponent<CharacterController>();//���� � ��������� ���� ��� �������� ������� �� ���������� ��������
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        _stats=new Playerstats();
    }



    void Update()
    {
       
        //������
        if (Input.GetKey(KeyCode.Space) && _controller.isGrounded)
        {
            Jump();
        }
        //��������
        if (Input.GetKey(KeyCode.LeftControl) && _controller.isGrounded)
        {
           //�������� ����� ����� ����� �������� ���������, � �� ���� ���� �� ��� ����� ������� � ��� �� ������ �������� ��������� �� ��� � ������ (12.09.2024)
        }
        //���
        if (Input.GetKey(KeyCode.LeftShift) && _controller.isGrounded && !Input.GetKey(KeyCode.LeftControl) && _stats.Stamina >= 30 && Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D) && _stats.Stamina>0)
        {
            _moveSpeed = 6.0f;
            _stats.Stamina -= 6f*Time.deltaTime;   

        }
        else
        {
            _moveSpeed = 3.0f;
            _stats.Stamina += 3f * Time.deltaTime;
         
        }
        float horisontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 moveDeraction = transform.forward * verticalInput + transform.right * horisontalInput;
        moveDeraction.y -= 9.81f * Time.deltaTime;
        _controller.Move(moveDeraction * _moveSpeed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        Gravity();
    }

    private void Jump()
    {
        _velocity.y = 2f;
        _controller.Move(_velocity * Time.deltaTime);
    }
    private void Gravity()
    {
        _velocity.y -= 0.06f;
        if (_velocity.y < -8.0f)
        {
            _velocity.y = -8f;
        }

        _controller.Move(_velocity * Time.deltaTime);
    }

  
}
