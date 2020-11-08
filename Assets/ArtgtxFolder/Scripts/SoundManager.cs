using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource music;
    public AudioSource effects;
    public static SoundManager sm;
    public AudioClip addGnomeClip;
    public AudioClip shootLeftClip;
    public AudioClip shootRightClip;
    public AudioClip explosionClip;
    public AudioClip deathGnomeClip;
    public AudioClip stingAttackClip;
    public AudioClip stingDeathClip;
    public AudioClip levelUpClip;
    public AudioClip levelDownClip;
    public AudioClip themeClip;
    
    
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
