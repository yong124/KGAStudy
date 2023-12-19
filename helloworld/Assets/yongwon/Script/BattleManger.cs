using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BattleManger : MonoBehaviour
{
    public float enemyMaxHp;
    private float enemyCurHp;
    public float playerMaxHp;
    private float playerCurHp;
    public float playerAttack;
    public float enemyAttack;
    public float healPercent;

    public float criticalChance;
    public float criticalMul;

    public float enemyCriticalChance;
    public float enemyCriticalMul;
    public Button attackButton;
    public Slider enemyhpBar;
    public Slider playerhpBar;
    private bool isRampaged = false;
    private int turn = 0;
    private bool firstAttack;
    private float damage;
    public void SetHp() //*Hp설정
{
        enemyCurHp = enemyMaxHp;
        playerCurHp = playerMaxHp;

}
     void CheckHp()
    {
        if (enemyhpBar != null)
            enemyhpBar.value = enemyCurHp/enemyMaxHp;
        if (playerhpBar != null)
            playerhpBar.value = playerCurHp / playerMaxHp;

    }

    float Damage(float playerAttack, float criticalChance,float criticalMul)
    {
        if (Random.value <= criticalChance)
        {
            return playerAttack * criticalMul;
        }
        else
        {
            return playerAttack;
        }
    }
    public void attack()
    {
        if((enemyMaxHp==0 || enemyCurHp <= 0) || (playerMaxHp==0 || playerCurHp<=0))
        {
            return;
        }

        damage=Damage(playerAttack,criticalChance,criticalMul);
        enemyCurHp -= damage;

        damage = Damage(enemyAttack, criticalChance, enemyCriticalMul);
        playerCurHp -= damage;
        if (enemyCurHp / enemyMaxHp <= 0.5)
        {
            if (!isRampaged)
            {
                enemyCurHp += enemyMaxHp * healPercent;
                Debug.Log("체력회복함");
                isRampaged = true;
            }
        }

        if(playerMaxHp==0 || playerCurHp <= 0)
        {
            Debug.Log("너 죽음");
            return;
        }
        playerCurHp -= damage;


        CheckHp();
        Debug.Log(enemyCurHp);
    }




    private void SetTurn()
    {
        if (Random.value > 0.5)
        {
            firstAttack= false;
        }
        else
        {
            firstAttack= true;
        }
        
    }


    private void Start()
    {
        SetHp();
        CheckHp();
        SetTurn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
