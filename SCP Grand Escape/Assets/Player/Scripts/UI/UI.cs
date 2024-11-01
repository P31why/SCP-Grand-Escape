using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using System.Timers;
using TMPro;
using UnityEngine.UI;
using Button = UnityEngine.UI.Button;

public class UI : MonoBehaviour
{
   // [SerializeField] private GameObject _panel;
    //[SerializeField] private Text[] _itemButtonsTexts = new Text[4];
    [SerializeField] private GameObject _buttonExit;
    [SerializeField] private bool _menuOpen;
    //[SerializeField] private bool _inventoryOpen;
   // [SerializeField] private PlayerInventary _playerInventary;
 //   [SerializeField] private int _selectedItem;


    private void Start()
    {
       // _selectedItem = 0;
        _menuOpen = false;
        
        //_inventoryOpen = false;
        // for (int i = 0; i < 2; i++)
        // {
        //     SetText(_itemButtonsTexts[i], _playerInventary.Items[i].Name);
        // }
        //
        
    }



    //
    // private static void SetText(Text button, string text)
    // {
    //     button.GetComponentInChildren<Text>().text = text ?? "nothing";
    // }

    // public void SetSelectedItem(int item)
    // {
    //     _selectedItem = _selectedItem == item ? 0 : item;
    //    
    //     UnityEngine.Cursor.lockState = !_inventoryOpen ? CursorLockMode.None : CursorLockMode.Locked;
    //     UnityEngine.Cursor.visible = !_inventoryOpen;
    //     _panel.SetActive(!_inventoryOpen);
    //     _inventoryOpen = !_inventoryOpen;
    //   
    //     // for (int i = 0; i < 2; i++)
    //     // {
    //     //     _playerInventary.Items[i].SetActive(false);
    //     // }
    //     //
    //     // if (_selectedItem != 0)
    //     // {
    //     //     _playerInventary.Items[_selectedItem - 1].SetActive(true);
    //     // }
    // }




    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Backspace) /*&& !_inventoryOpen*/)
        {
            
            UnityEngine.Cursor.lockState = !_menuOpen ? CursorLockMode.None : CursorLockMode.Locked;
            UnityEngine.Cursor.visible = !_menuOpen;
            _buttonExit.SetActive(!_menuOpen);
            _menuOpen = !_menuOpen;
           
        }

        // if (Input.GetKeyDown(KeyCode.I) && !_menuOpen)
        // {
        //     UnityEngine.Cursor.lockState = !_inventoryOpen ? CursorLockMode.None : CursorLockMode.Locked;
        //     UnityEngine.Cursor.visible = !_inventoryOpen;
        //     _panel.SetActive(!_inventoryOpen);
        //     _inventoryOpen = !_inventoryOpen; ;
        // }

        // switch (_selectedItem)
        // {
        //     case 1:
        //     {
        //         if (Input.GetKey(KeyCode.F))
        //         {
        //             ((FlashlightItem)_playerInventary.Items[0]).ToggleFlashlight();
        //             _ready = false;
        //             _timer.Start();
        //         }
        //         break;
        //     }
        //     case 2:
        //     {
        //         if (Input.GetKey(KeyCode.F) && _ready)
        //         {
        //             ((Laptop)_playerInventary.Items[1]).SwapPage();
        //             _ready = false;
        //             _timer.Start();
        //         }
        //         break;
        //     }
        // }
       
    }
}