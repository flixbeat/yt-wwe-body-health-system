using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageBody : MonoBehaviour
{
    // reference to body parts images
    [SerializeField] Image head;
    [SerializeField] Image torso;
    [SerializeField] Image lArm;
    [SerializeField] Image rArm;
    [SerializeField] Image legs;
    [SerializeField] Image feet;

    // color references
    private Color32 fine = new Color32(55,200,35,255); // green
    private Color32 bruised = new Color32(180,217,103,255); // yellow green
    private Color32 damaged = new Color32(193,191,41,255); // yellow orange
    private Color32 severed = new Color32(193,58,41,255); // red

    // body parts hp vars
    private int headHP = 100;
    private int torsoHP = 100;
    private int lArmHP = 100;
    private int rArmHP = 100;
    private int legsHP = 100;
    private int feetHP = 100;

    // button damage
    [SerializeField] int headDmg;
    [SerializeField] int torsoDmg;
    [SerializeField] int lArmDmg;
    [SerializeField] int rArmDmg;
    [SerializeField] int legsDmg;
    [SerializeField] int feetDmg;

    public void damageHead()
    {
        // deal damage
        headHP -= headDmg;

        // apply color
        if (headHP >= 85) head.color = fine; // 85 and above green
        else if (headHP >= 61 && headHP <= 84) head.color = bruised; // 61 - 84 yellow green
        else if (headHP >= 41 && headHP <= 60) head.color = damaged; // 41 - 60 yellow orange
        else head.color = severed; // 40 and below - red
    }

    public void damageTorso()
    {
        // deal damage
        torsoHP -= torsoDmg;

        // apply color
        if (torsoHP >= 85) torso.color = fine; // 85 and above green
        else if (torsoHP >= 61 && torsoHP <= 84) torso.color = bruised; // 61 - 84 yellow green
        else if (torsoHP >= 41 && torsoHP <= 60) torso.color = damaged; // 41 - 60 yellow orange
        else torso.color = severed; // 40 and below - red
    }

    public void damageLArm()
    {
        // deal damage
        lArmHP -= lArmDmg;

        // apply color
        if (lArmHP >= 85) lArm.color = fine; // 85 and above green
        else if (lArmHP >= 61 && lArmHP <= 84) lArm.color = bruised; // 61 - 84 yellow green
        else if (lArmHP >= 41 && lArmHP <= 60) lArm.color = damaged; // 41 - 60 yellow orange
        else lArm.color = severed; // 40 and below - red
    }
    
    public void damageRArm()
    {
        // deal damage
        rArmHP -= rArmDmg;

        // apply color
        if (rArmHP >= 85) rArm.color = fine; // 85 and above green
        else if (rArmHP >= 61 && rArmHP <= 84) rArm.color = bruised; // 61 - 84 yellow green
        else if (rArmHP >= 41 && rArmHP <= 60) rArm.color = damaged; // 41 - 60 yellow orange
        else rArm.color = severed; // 40 and below - red
    }
    
    public void damageLegs()
    {
        // deal damage
        legsHP -= legsDmg;

        // apply color
        if (legsHP >= 85) legs.color = fine; // 85 and above green
        else if (legsHP >= 61 && legsHP <= 84) legs.color = bruised; // 61 - 84 yellow green
        else if (legsHP >= 41 && legsHP <= 60) legs.color = damaged; // 41 - 60 yellow orange
        else legs.color = severed; // 40 and below - red
    }
    
    public void damageFeet()
    {
        // deal damage
        feetHP -= feetDmg;

        // apply color
        if (feetHP >= 85) feet.color = fine; // 85 and above green
        else if (feetHP >= 61 && feetHP <= 84) feet.color = bruised; // 61 - 84 yellow green
        else if (feetHP >= 41 && feetHP <= 60) feet.color = damaged; // 41 - 60 yellow orange
        else feet.color = severed; // 40 and below - red
    }

    public void clear()
    {
        // reset colors
        head.color = fine;
        torso.color = fine;
        lArm.color = fine;
        rArm.color = fine;
        legs.color = fine;
        feet.color = fine;

        // reset hp
        headHP = 100;
        torsoHP = 100;
        rArmHP = 100;
        lArmHP = 100;
        legsHP = 100;
        feetHP = 100;
    }
}
