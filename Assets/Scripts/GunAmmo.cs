using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAmmo : MonoBehaviour
{
    public int magSize;
    public GrenadeLauncher gun;

    private int _loadedAmmo;

    public int LoadedAmmo
    {
        get => _loadedAmmo;
        set
        {
            _loadedAmmo = value;
            if (_loadedAmmo <= 0)
            {
                Reload();
            }
            else
            {
                UnlockShooting();
            }
        }
    }
    private void Start()
    {
        RefillAmmo();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }
    }
    private void Reload()
    {
        LockShooting();
    }
    public void AddAmmo()

    {
        RefillAmmo();
    }
    public void SingleFireAmmoCounter()
    {
        _loadedAmmo--;
    }
    private void LockShooting()
    {
        gun.enabled = false;
    }
    private void UnlockShooting()
    {
        gun.enabled = true;
    }
    private void RefillAmmo()
    {
        LoadedAmmo = magSize;
    }
}
