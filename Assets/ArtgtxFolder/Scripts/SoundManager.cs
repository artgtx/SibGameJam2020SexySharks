using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField]private AudioSource music;
    [SerializeField]private AudioSource effects;
    public static SoundManager sm;
    [SerializeField]private AudioClip addGnomeClip;
    [SerializeField]private AudioClip shootLeftClip;
    [SerializeField]private AudioClip shootRightClip;
    [SerializeField]private AudioClip explosionClip;
    [SerializeField]private AudioClip deathGnomeClip;
    [SerializeField]private AudioClip stingAttackClip;
    [SerializeField]private AudioClip stingDeathClip;
    [SerializeField]private AudioClip levelUpClip;
    [SerializeField]private AudioClip levelDownClip;
    [SerializeField]private AudioClip themeClip;
    
    
    // Start is called before the first frame update
    private void Start()
    {
        sm = this;
        mainTheme();
    }

    public void mainTheme()
    {
        music.clip = themeClip;
        music.Play();
    }
    public void addGnome()
    {
        effects.PlayOneShot(addGnomeClip);
    }
    public void shootLeft()
    {
        effects.PlayOneShot(shootLeftClip);
    }
    public void shootRight()
    {
        effects.PlayOneShot(shootRightClip);
    }
    public void explosion()
    {
        effects.PlayOneShot(explosionClip);
    }
    public void deathGnome()
    {
        effects.PlayOneShot(deathGnomeClip);
    }
    
    public void stingAttack()
    {
        effects.PlayOneShot(stingAttackClip);
    }
    public void stingDeath()
    {
        effects.PlayOneShot(stingDeathClip);
    }
    public void levelUp()
    {
        effects.PlayOneShot(levelUpClip);
    }
    public void levelDown()
    {
        effects.PlayOneShot(levelDownClip);
    }

}
