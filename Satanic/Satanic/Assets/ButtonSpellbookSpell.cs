using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpellbookSpell : MonoBehaviour {
    public SpellID mySpell;
    public Text ButtonText;
    public Image image;
    public void Setup(SpellID spell)
    {
        mySpell = spell;
        ButtonText.text = Spell.Definitions[spell].name;
        image.sprite = Spell.Definitions[spell].sprite;
    }

    public void Click()
    {
        Engine.SetCurrentSpell(mySpell);
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
