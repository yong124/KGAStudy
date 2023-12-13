using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class UiManager : MonoBehaviour
{
    public Image BG;
    public Sprite changeImage;
    public Button PressBt;
    public int testValue = 1;
    bool isChanged;
    [SerializeField]
    Sprite defaultSprite;
    public TextMeshProUGUI deceive;
    
    public void Start()
    {
        defaultSprite = BG.sprite;
    }
    public void ChangeColor()
    {
        
        
        if (isChanged == false)
        {

            isChanged = true;
            BG.sprite = changeImage;
            deceive.text = "JJangu you decive me?";


        }
        else
        {
            isChanged = false;
            BG.sprite = defaultSprite;
            deceive.text = "Father   you decive me?";
            
        }
        
    }
   
}
