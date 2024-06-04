using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private GameObject pausePanel;
    PlayerMovement playerMove;
    Shoot shoot;
    SuperPower supPower;
    public bool haveGun;
    public bool mayFire;
    public bool directionRay;
    PlayerInput input;
    [SerializeField] private LayerMask lay;
    [SerializeField] private float distanceRay, reloadTime, maxBullets;
    private float coolDown, currentReloadTime, countBullets;
    public bool canUsePower, powerEnable;

    private void Awake()
    {
        countBullets = maxBullets;
        currentReloadTime = 0;
        supPower = GetComponent<SuperPower>();
        haveGun = false;
        playerMove = GetComponent<PlayerMovement>();
        shoot = GetComponent<Shoot>();
        coolDown = 0;
    }

    private void Update()
    {
        float direction = Input.GetAxis(GlobalStringVar.HORIZONTAL_AXIS);
        bool jump = Input.GetButton(GlobalStringVar.JUMP);

        if (countBullets <= 0)
        {
            mayFire = false;
            currentReloadTime += Time.deltaTime;
        }
        if (currentReloadTime >= reloadTime)
        {
            mayFire = true;
            currentReloadTime = 0;
            countBullets = maxBullets;
        }

        if (haveGun == true)
        {
            if (mayFire == true)
            {
                if (Input.GetButtonDown(GlobalStringVar.FIRE_1))
                {
                    shoot.Fire(direction);
                    countBullets--;
                }
            }
        }
        
        coolDown -= Time.deltaTime;
        if (coolDown <= 0)
        {
            if (powerEnable)
            {

                if (canUsePower == true)
                {
                    if (direction > 0)
                        directionRay = true;
                    if (directionRay == true)
                        if (Physics2D.Raycast(transform.position, Vector2.right, distanceRay, lay))
                        {
                            if (Input.GetKeyDown(KeyCode.F))
                            {
                                supPower.UsePower(distanceRay);
                                coolDown = 15;
                            }
                        }
                    if (direction < 0)
                        directionRay = false;
                    if (directionRay == false)
                        if (Physics2D.Raycast(transform.position, Vector2.left, distanceRay, lay))
                        {
                            if (Input.GetKeyDown(KeyCode.F))
                            {
                                supPower.UsePower(distanceRay);
                                coolDown = 15;
                            }
                        }
                }
            }
        }
        playerMove.Move(direction, jump);
        if(Input.GetKeyDown(KeyCode.Escape)) 
        {
            pausePanel.SetActive(!pausePanel.activeSelf);
        }
    }
}
